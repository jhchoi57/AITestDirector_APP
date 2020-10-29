using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamOXPanel : ExamSubQuestionPanel
    {
        private int answer { get; set; }  // 0: 체크 안 함, 1: ○, 2: ✕
        private Button oButton { get; set; }
        private Button xButton { get; set; }

        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public Button OButton
        {
            get { return oButton; }
            set { oButton = value; }
        }

        public Button XButton
        {
            get { return xButton; }
            set { xButton = value; }
        }

        public ExamOXPanel(CustomFonts customFonts, string question, int score) : base(customFonts, question, score)
        {
            int margin = 10;
            int height;

            this.Size = new System.Drawing.Size(645, 45);

            answer = 0;

            Type = 0;

            oButton = new Button();
            oButton.Text = "○";
            oButton.Size = new System.Drawing.Size(30, 28);
            oButton.FlatAppearance.BorderSize = 0;
            oButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            oButton.Font = customFonts.TextBoxFont();
            this.Controls.Add(oButton);
            oButton.Click += oButton_Click_1;

            xButton = new Button();
            xButton.Text = "✕";
            xButton.Size = new System.Drawing.Size(30, 28);
            xButton.FlatAppearance.BorderSize = 0;
            xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            xButton.Font = customFonts.LabelFont();
            this.Controls.Add(xButton);
            xButton.Click += xButton_Click_1;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);

            QuestionLabel.Location = new Point(0, 10);
            height = margin * 2 + QuestionLabel.Height;
            this.Height = height;
            oButton.Location = new Point(460, (height - oButton.Height) / 2);
            xButton.Location = new Point(490, (height - xButton.Height) / 2);
            ExamScorePanel.Location = new Point(520, (height - ExamScorePanel.Height) / 2);
        }

        private void oButton_Click_1(object sender, EventArgs e)
        {
            answer = 1;
            oButton.ForeColor = Color.White;
            oButton.BackColor = Color.Black;
            xButton.ForeColor = Color.Black;
            xButton.BackColor = Color.White;
        }

        private void xButton_Click_1(object sender, EventArgs e)
        {
            answer = 2;
            xButton.ForeColor = Color.White;
            xButton.BackColor = Color.Black;
            oButton.ForeColor = Color.Black;
            oButton.BackColor = Color.White;
        }
    }
}
