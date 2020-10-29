using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamMultipleChoiceQuestionPanel : ExamSubQuestionPanel
    {
        private CustomFonts customFonts;
        private int answer { get; set; }
        private List<ExamMultipleChoicePanel> choicePanelList { get; set; }
        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public List<ExamMultipleChoicePanel> ChoicePaneList
        {
            get { return choicePanelList; }
            set { choicePanelList = value; }
        }
        public ExamMultipleChoiceQuestionPanel(CustomFonts customFonts, string question, int score, string[] multipleQuestions) : base(customFonts, question, score)
        {
            int count;

            this.customFonts = customFonts;
            this.Size = new Size(645, 160);

            answer = -1;
            Type = 3;

            choicePanelList = new List<ExamMultipleChoicePanel>();
            setMultipleQuestions(multipleQuestions);

            count = choicePanelList.Count;
            this.Height = choicePanelList[count - 1].Location.Y + choicePanelList[count - 1].Height + 20;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            QuestionLabel.Location = new Point(0, 10);

            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
        }

        private void setMultipleQuestions(string[] multipleQuestions)
        {
            int length = multipleQuestions.Length;

            for (int i = 0; i < length; i++)
            {
                ExamMultipleChoicePanel choicePanel = new ExamMultipleChoicePanel(customFonts, multipleQuestions[i]);
                if (i == 0)
                {
                    choicePanel.Location = new Point(50, QuestionLabel.Location.Y + QuestionLabel.Height + 30); 
                }
                else
                {
                    choicePanel.Location = new Point(50, choicePanelList[i - 1].Location.Y + choicePanelList[i - 1].Height + 5);
                }
                this.Controls.Add(choicePanel);
                choicePanelList.Add(choicePanel);
                choicePanel.ExampleRadioButton.Click += exampleRadioButton_Click_1;
            }
        }

        private void exampleRadioButton_Click_1(object sender, EventArgs e)
        {
            int count = choicePanelList.Count;
            RadioButton exampRadioButton = (RadioButton)sender;
            ExamMultipleChoicePanel choicePanel = (ExamMultipleChoicePanel)exampRadioButton.Parent;

            for (int i = 0; i < count; i++)
            {
                if (choicePanelList[i] != choicePanel)
                {
                    choicePanelList[i].ExampleRadioButton.Checked = false;
                } 
            }

            answer = choicePanelList.IndexOf(choicePanel);
        }
    }
}
