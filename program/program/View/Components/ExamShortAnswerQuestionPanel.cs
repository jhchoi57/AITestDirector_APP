﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.View.Components
{
    class ExamShortAnswerQuestionPanel : ExamSubQuestionPanel
    {
        private ShortAnswerPanel answerPanel { get; set; }

        public string Answer
        {
            get { return answerPanel.AnswerTextBox.Text; }
            set { answerPanel.AnswerTextBox.Text = value; }
        }

        public ShortAnswerPanel AnswerPanel
        {
            get { return answerPanel; }
            set { answerPanel = value; }
        }

        public ExamShortAnswerQuestionPanel(CustomFonts customFonts, string question, int score) : base(customFonts, question, score)
        {
            int height;

            this.Size = new Size(725, 147);
            this.Click += Click_1;

            Type = 1;

            answerPanel = new ShortAnswerPanel(customFonts);
            this.Controls.Add(answerPanel);

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);

            QuestionLabel.Location = new Point(0, 10);
            answerPanel.Location = new Point(300, QuestionLabel.Location.Y + QuestionLabel.Height + 20);
            height = answerPanel.Location.Y + answerPanel.Height;
            this.Height = height;
            ExamScorePanel.Location = new Point(520, (height - ExamScorePanel.Height) / 2);
            StudentScorePanel.Location = new Point(600, (height - StudentScorePanel.Height) / 2);
        }
        
        private void Click_1(object sender, EventArgs e)
        {
            this.QuestionLabel.Focus();
        }
    }
}
