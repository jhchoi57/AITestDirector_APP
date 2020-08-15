using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ScorePanel : Panel
    {
        private Label scoreLabel { get; set; }
        private TextBox scoreTextBox { get; set; }

        public Label ScoreLabel
        {
            get { return scoreLabel; }
            set { scoreLabel = value; }
        }

        public TextBox ScoreTextBox
        {
            get { return scoreTextBox; }
            set { scoreTextBox = value; }
        }

        public ScorePanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(80, 28);

            scoreLabel = new Label();
            scoreLabel.Location = new Point(0, 4);
            scoreLabel.Text = "(           점)";
            scoreLabel.Font = customFonts.LabelFont();
            this.Controls.Add(scoreLabel);

            scoreTextBox = new TextBox();
            scoreTextBox.Size = new Size(40, 28);
            scoreTextBox.BackColor = Color.Beige;
            scoreTextBox.Text = "10";
            scoreTextBox.Font = customFonts.LabelFont();
            scoreTextBox.Location = new Point(14, 5);
            scoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            scoreTextBox.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(ScoreTextBox);
            scoreTextBox.BringToFront();
            scoreTextBox.KeyPress += scoreTextBox_KeyPress_1;
            scoreTextBox.LostFocus += scoreTextBox_LostFocus_1;
        }

        private void scoreTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                   //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void scoreTextBox_LostFocus_1(object sender, EventArgs e)
        {
            if (scoreTextBox.Text == "")
            {
                scoreTextBox.Text = "0";
            }
        }
    }
}
