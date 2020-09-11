using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ShortAnswerQuestionPanel : SubQuestionPanel
    {
        private string answer { get; set; }
        private ShortAnswerPanel answerPanel { get; set; }

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public ShortAnswerPanel AnswerPanel
        {
            get { return answerPanel; }
            set { answerPanel = value; }
        }
        public ShortAnswerQuestionPanel(CustomFonts customFonts) : base(customFonts)
        {
            this.Size = new Size(645, 147);

            Type = 1;

            answerPanel = new ShortAnswerPanel(customFonts);
            answerPanel.Location = new Point(300, 120);
            this.Controls.Add(answerPanel);

            QuestionTextBox.Size = new System.Drawing.Size(500, 100);
            QuestionTextBox.LostFocus += questionTextBox_LostFocus_1;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            QuestionLabel.Click += questionLabel_Click_1;

            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);

            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }

        private void questionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = QuestionTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                int height;
                QuestionTextBox.Visible = false;
                QuestionLabel.Visible = true;
                QuestionLabel.Text = QuestionTextBox.Text;
                answerPanel.Location = new Point(300, QuestionLabel.Location.Y + QuestionLabel.Height + 20);
                height = answerPanel.Location.Y + answerPanel.Height;
                this.Height = height;
                QuestionLabel.Location = new Point(0, 10);
                ExamScorePanel.Location = new Point(520, (height - ExamScorePanel.Height) / 2);
                DeleteButton.Location = new Point(605, (height - DeleteButton.Height) / 2);
            }
        }

        private void questionLabel_Click_1(object sender, EventArgs e)
        {
            this.Height = 147;
            QuestionTextBox.Visible = true;
            QuestionLabel.Visible = false;
            answerPanel.Location = new Point(300, 120);
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
            QuestionTextBox.Focus();
        }
    }
}
