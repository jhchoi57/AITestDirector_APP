using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class EssayAnswerPanel : Panel
    {
        private Label textLabel;
        private Label maxLengthLabel;
        private TextBox maxLengthTextBox { get; set; }
        private int maxLength { get; set; }
        private Label answerLabel { get; set; }
        private TextBox answerTextBox{ get; set; }

        public TextBox MaxLengthTextBox
        {
            get { return maxLengthTextBox; }
            set { maxLengthTextBox = value; }
        }
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; }
        }
        public Label AnswerLabel
        {
            get { return answerLabel; }
            set { answerLabel = value; }
        }
        public TextBox AnswerTextBox
        {
            get { return answerTextBox; }
            set { answerTextBox = value; }
        }

        public EssayAnswerPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(500, 280);

            maxLength = 4000;

            maxLengthLabel = new Label();
            maxLengthLabel.BackColor = Color.White;
            maxLengthLabel.Text = "최대 글자 수:";
            maxLengthLabel.Size = new Size(62, 13);
            maxLengthLabel.Location = new Point(380, 10);
            maxLengthLabel.Font = customFonts.SmallFont();
            this.Controls.Add(maxLengthLabel);

            maxLengthTextBox = new TextBox();
            maxLengthTextBox.Text = "4000";
            maxLengthTextBox.TextAlign = HorizontalAlignment.Center;
            maxLengthTextBox.BackColor = Color.Beige;
            maxLengthTextBox.MaxLength = 5;
            maxLengthTextBox.Size = new Size(40, 13);
            maxLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maxLengthTextBox.Location = new Point(442, 10);
            maxLengthTextBox.Font = customFonts.SmallFont();
            this.Controls.Add(maxLengthTextBox);
            maxLengthTextBox.KeyPress += maxLengthTextBox_KeyPress_1;
            maxLengthTextBox.LostFocus += maxLengthTextBox_LostFocus_1;

            textLabel = new Label();
            textLabel.Text = "답:";
            textLabel.Size = new Size(30, 21);
            textLabel.Location = new Point(0, 30);
            textLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(textLabel);

            answerLabel = new Label();
            answerLabel.Location = new Point(30, 30);
            answerLabel.MaximumSize = new Size(470, 0);
            answerLabel.Visible = false;
            answerLabel.AutoSize = true;
            answerLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(answerLabel);
            answerLabel.Click += answerLabel_Click_1;

            answerTextBox = new TextBox();
            answerTextBox.Size = new Size(470, 250);
            answerTextBox.Location = new Point(30, 27);
            answerTextBox.MaxLength = maxLength;
            answerTextBox.ScrollBars = ScrollBars.Vertical;
            answerTextBox.Font = customFonts.TextBoxFont();
            answerTextBox.Multiline = true;
            this.Controls.Add(answerTextBox);
            answerTextBox.LostFocus += answerTextBox_LostFocus_1;
        }
        private void maxLengthTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                   //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void maxLengthTextBox_LostFocus_1(object sender, EventArgs e)
        {
            if (maxLengthTextBox.Text == "") 
            {
                maxLengthTextBox.Text = "4000";
            }
            maxLength = int.Parse(maxLengthTextBox.Text);
            answerTextBox.MaxLength = maxLength;
        }

        private void answerTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = answerTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                answerLabel.Text = answerTextBox.Text;
                this.Height = answerLabel.Location.Y + answerLabel.Height;
                answerTextBox.Visible = false;
                answerLabel.Visible = true;
            }
        }

        private void answerLabel_Click_1(object sender, EventArgs e)
        {
            this.Height = 280;
            answerTextBox.Visible = true;
            answerLabel.Visible = false;
            answerTextBox.Focus();
        }
    }
}
