using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.View.Components
{
    class ExamEssayQuestionPanel : ExamSubQuestionPanel
    {
        private EssayAnswerPanel answerPanel { get; set; }

        public EssayAnswerPanel AnswerPanel
        {
            get { return answerPanel; }
            set { answerPanel = value; }
        }

        public ExamEssayQuestionPanel(CustomFonts customFonts, string question, int score, int maxLength) : base(customFonts, question, score)
        {
            this.Size = new Size(645, 400);

            answerPanel = new EssayAnswerPanel(customFonts);
            answerPanel.Location = new Point(0, 120);
            this.Controls.Add(answerPanel);
            answerPanel.MaxLengthTextBox.Text = maxLength.ToString();
            answerPanel.MaxLengthTextBox.ReadOnly = true;
            answerPanel.AnswerTextBox.LostFocus += answerTextBox_LostFocus_2;
            answerPanel.AnswerLabel.Click += answerLabel_Click_2;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            QuestionLabel.Location = new Point(0, 10);
            answerPanel.Location = new Point(0, QuestionLabel.Location.Y + QuestionLabel.Height + 20);
            this.Height = answerPanel.Location.Y + answerPanel.Height;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
        }
        
        private void answerTextBox_LostFocus_2(object sender, EventArgs e)
        {
            this.Height = answerPanel.Height + answerPanel.Location.Y;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
        }

        private void answerLabel_Click_2(object sender, EventArgs e)
        {
            this.Height = answerPanel.Height + answerPanel.Location.Y;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
        }
    }
}
