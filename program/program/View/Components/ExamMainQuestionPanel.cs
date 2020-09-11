using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExamMainQuestionPanel : Panel
    {
        private ScorePanel totalScorePanel { get; set; }
        private Label mainQuestionLabel { get; set; }
        private List<ExamSubQuestionPanel> subQuestionPanelsList { get; set; }

        private CustomFonts customFonts;
        public ScorePanel TotalScorePanel
        {
            get { return totalScorePanel; }
            set { totalScorePanel = value; }
        }
        public Label MainQuestionLabel
        {
            get { return mainQuestionLabel; }
            set { mainQuestionLabel = value; }
        }
        public List<ExamSubQuestionPanel> SubQuestionPanelsList
        {
            get { return subQuestionPanelsList; }
            set { subQuestionPanelsList = value; }
        }

        public ExamMainQuestionPanel(CustomFonts customFonts, string question, List<ExamSubQuestionPanel> subQuestionPanelsList) : base()
        {
            this.Size = new Size(800, 500);
            this.BackColor = Color.White;
            this.Click += Click_1;

            this.customFonts = customFonts;

            totalScorePanel = new ScorePanel(customFonts);
            totalScorePanel.Location = new Point(670, 11);
            totalScorePanel.ScoreTextBox.Text = "0";
            totalScorePanel.ScoreTextBox.BackColor = Color.White;
            totalScorePanel.ScoreTextBox.ReadOnly = true;
            this.Controls.Add(totalScorePanel);

            mainQuestionLabel = new Label();
            mainQuestionLabel.Text = question;
            mainQuestionLabel.Location = new Point(50, 53);
            mainQuestionLabel.MaximumSize = new Size(700, 0);
            mainQuestionLabel.AutoSize = true;
            mainQuestionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(mainQuestionLabel);

            this.subQuestionPanelsList = subQuestionPanelsList;
            addSubQuestions();
            moveListItems(0);
        }

        private void addSubQuestions()
        {
            int count = subQuestionPanelsList.Count;
            int totalScore = 0;

            for (int i = 0; i < count; i++)
            {
                this.Controls.Add(subQuestionPanelsList[i]);
                totalScore += int.Parse(subQuestionPanelsList[i].ExamScorePanel.ScoreTextBox.Text);
                if (subQuestionPanelsList[i].Type == 2)
                {
                    ExamEssayQuestionPanel examEssayQuestionPanel = (ExamEssayQuestionPanel)subQuestionPanelsList[i];
                    examEssayQuestionPanel.AnswerPanel.AnswerLabel.Click += subQuestion_essayAnswerLabel_Click_1;
                    examEssayQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += subQuestion_essayAnswerTextBox_LostFocus_1;
                }
            }

            this.totalScorePanel.ScoreTextBox.Text = totalScore.ToString();
        }
        
        private void moveListItems(int moveStartIndex)
        {
            int count;

            count = subQuestionPanelsList.Count;
            if (moveStartIndex == 0 && count > 0)
            {
                subQuestionPanelsList[moveStartIndex++].Location = new Point(100, mainQuestionLabel.Location.Y + mainQuestionLabel.Height + 50);
            }

            for (int i = moveStartIndex; i < count; i++)
            {
                subQuestionPanelsList[i].Location = new Point(100, subQuestionPanelsList[i - 1].Location.Y + subQuestionPanelsList[i - 1].Height + 20);
            }

            if (count > 0)
                this.Height = subQuestionPanelsList[count - 1].Location.Y + subQuestionPanelsList[count - 1].Height + 20;

        }

        private void subQuestion_essayAnswerTextBox_LostFocus_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int idx;
            ExamSubQuestionPanel subQuestionPanel = (ExamSubQuestionPanel)textBox.Parent.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void subQuestion_essayAnswerLabel_Click_1(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int idx;

            ExamSubQuestionPanel subQuestionPanel = (ExamSubQuestionPanel)label.Parent.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void Click_1(object sender, EventArgs e)
        {
            totalScorePanel.ScoreLabel.Focus();
        }
    }
}
