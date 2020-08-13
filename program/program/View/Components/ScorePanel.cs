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

        public ScorePanel() : base()
        {
            this.Size = new Size(80, 28);

            scoreLabel = new Label();
            scoreLabel.Location = new Point(0, 4);
            scoreLabel.Text = "(           점)";
            scoreLabel.Font = CustomFonts.LabelFont;
            this.Controls.Add(scoreLabel);

            scoreTextBox = new TextBox();
            scoreTextBox.Size = new Size(40, 28);
            scoreTextBox.BackColor = Color.Beige;
            scoreTextBox.Text = "10";
            scoreTextBox.Font = CustomFonts.LabelFont;
            scoreTextBox.Location = new Point(14, 5);
            scoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            scoreTextBox.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(ScoreTextBox);
            scoreTextBox.BringToFront();

        }

    }
}
