﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace program.View.Components
{
    class EssayQuestionPanel : SubQuestionPanel
    {
        private EssayAnswerPanel answerPanel { get; set; }

        public EssayAnswerPanel AnswerPanel
        {
            get { return answerPanel; }
            set { answerPanel = value; }
        }

        public EssayQuestionPanel(CustomFonts customFonts) : base(customFonts)
        {
            this.Size = new Size(645, 400);

            Type = 2;

            answerPanel = new EssayAnswerPanel(customFonts);
            answerPanel.Location = new Point(0, 120);
            this.Controls.Add(answerPanel);
            answerPanel.AnswerTextBox.LostFocus += answerTextBox_LostFocus_2;
            answerPanel.AnswerLabel.Click += answerLabel_Click_2;

            QuestionTextBox.Size = new System.Drawing.Size(500, 100);
            QuestionTextBox.LostFocus += questionTextBox_LostFocus_1;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            QuestionLabel.Location = new Point(0, 10);
            QuestionLabel.Click += questionLabel_Click_1;

            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);

            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }

        public void setLayout()
        {
            int height;
            answerPanel.Location = new Point(0, QuestionLabel.Location.Y + QuestionLabel.Height + 20);
            height = answerPanel.Location.Y + answerPanel.Height;
            this.Height = height;
            ExamScorePanel.Location = new Point(520, (height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (height - DeleteButton.Height) / 2);
        }

        private void questionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = QuestionTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                QuestionTextBox.Visible = false;
                QuestionLabel.Visible = true;
                QuestionLabel.Text = QuestionTextBox.Text;
                setLayout();
            }
        }

        private void questionLabel_Click_1(object sender, EventArgs e)
        {
            QuestionTextBox.Visible = true;
            QuestionLabel.Visible = false;
            answerPanel.Location = new Point(0, 120);
            this.Height = 120 + answerPanel.Height;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
            QuestionTextBox.Focus();
        }

        private void answerTextBox_LostFocus_2(object sender, EventArgs e)
        {
            this.Height = answerPanel.Height + answerPanel.Location.Y;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }

        private void answerLabel_Click_2 (object sender, EventArgs e)
        {
            this.Height = answerPanel.Height + answerPanel.Location.Y;
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }
    }
}
