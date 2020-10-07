using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ShortAnswerPanel : Panel
    {
        private Label textLabel;
        private TextBox answerTextBox;
        private Label answerLabel;

        public Label TextLabel
        {
            get { return TextLabel; }
            set { TextLabel = value; }
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

        public ShortAnswerPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(200, 28);

            textLabel = new Label();
            textLabel.Size = new Size(30, 21);
            textLabel.Location = new Point(0, 3);
            textLabel.Text = "답:";
            textLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(textLabel);

            answerTextBox = new TextBox();
            answerTextBox.Size = new Size(170, 28);
            answerTextBox.Font = customFonts.TextBoxFont();
            answerTextBox.Location = new Point(30, 0);
            this.Controls.Add(answerTextBox);
            answerTextBox.LostFocus += answerTextBox_LostFocus_1;

            answerLabel = new Label();
            answerLabel.Size = new Size(170, 20);
            answerLabel.Font = customFonts.TextBoxFont();
            answerLabel.Location = new Point(30, 3);
            answerLabel.Visible = false;
            this.Controls.Add(answerLabel);
            answerLabel.Click += answerLabel_Click_1;
        }

        private void answerTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = answerTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                answerLabel.Text = answerTextBox.Text;
                answerTextBox.Visible = false;
                answerLabel.Visible = true;
            }
        }

        private void answerLabel_Click_1(object sender, EventArgs e)
        {
            answerTextBox.Visible = true;
            answerLabel.Visible = false;
            answerTextBox.Focus();
        }
    }
}
