using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class MainQuestionPanel : Panel
    {
        private AddSubQuestionButton addSubQuestionButton { get; set; }
        private QuestionKindPanel questionKindPanel;
        private ScorePanel totalScorePanel { get; set; }
        private Label mainQuestionLabel { get; set; }
        private TextBox mainQuestionTextBox { get; set; }
        private List<SubQuestionPanel> subQuestionPanelsList { get; set; }

        private CustomFonts customFonts;
        public AddSubQuestionButton AddQuestionButton
        {
            get { return addSubQuestionButton; }
            set { addSubQuestionButton = value; }
        }
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
        public TextBox MainQuestionTextBox
        {
            get { return mainQuestionTextBox; }
            set { mainQuestionTextBox = value; }
        }
        public List<SubQuestionPanel> SubQuestionPanelsList
        {
            get { return subQuestionPanelsList; }
            set { subQuestionPanelsList = value; }
        }
        

        public MainQuestionPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(800, 500);
            this.BackColor = Color.White;
            this.ControlRemoved += ControlRemoved_1;
            this.Click += Click_1;

            this.customFonts = customFonts;

            questionKindPanel = new QuestionKindPanel(customFonts);
            questionKindPanel.Location = new Point(385, 11);
            this.Controls.Add(questionKindPanel);
            questionKindPanel.QuestionKindComboBox.SelectedIndexChanged += questionKindComboBox_SelectedIndexChanged_1;

            addSubQuestionButton = new AddSubQuestionButton(customFonts);
            addSubQuestionButton.Location = new Point(560, 11);
            this.Controls.Add(addSubQuestionButton);
            addSubQuestionButton.Click += addSubQuestionButton_Click_1;

            totalScorePanel = new ScorePanel(customFonts);
            totalScorePanel.Location = new Point(670, 11);
            totalScorePanel.ScoreTextBox.Text = "0";
            totalScorePanel.ScoreTextBox.BackColor = Color.White;
            totalScorePanel.ScoreTextBox.ReadOnly = true;
            this.Controls.Add(totalScorePanel);

            mainQuestionTextBox = new TextBox();
            mainQuestionTextBox.Location = new Point(50, 50);
            mainQuestionTextBox.Size = new Size(700, 100);
            mainQuestionTextBox.Multiline = true;
            mainQuestionTextBox.ScrollBars = ScrollBars.Vertical;
            mainQuestionTextBox.Text = "○/✕ 문제입니다. 각각의 문제의 올바른 답 버튼을 눌러주세요.";
            mainQuestionTextBox.Font = customFonts.TextBoxFont();
            mainQuestionTextBox.Visible = false;
            this.Controls.Add(mainQuestionTextBox);
            mainQuestionTextBox.LostFocus += mainQuestionTextBox_LostFocus_1;

            mainQuestionLabel = new Label();
            mainQuestionLabel.Location = new Point(50, 53);
            mainQuestionLabel.Visible = true;
            mainQuestionLabel.MaximumSize = new Size(700, 0);
            mainQuestionLabel.AutoSize = true;
            mainQuestionLabel.Text = "○/✕ 문제입니다. 각각의 문제의 올바른 답 버튼을 눌러주세요.";
            mainQuestionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(mainQuestionLabel);
            mainQuestionLabel.Click += mainQuestionLabel_Click_1;

            subQuestionPanelsList = new List<SubQuestionPanel>();
        }

        private void mainQuestionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = this.mainQuestionTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                this.mainQuestionTextBox.Visible = false;
                this.mainQuestionLabel.Visible = true;
                this.mainQuestionLabel.Text = this.mainQuestionTextBox.Text;

                moveListItems(0);
            }
        }

        private void mainQuestionLabel_Click_1(object sender, EventArgs e)
        {
            this.mainQuestionLabel.Visible = false;
            this.mainQuestionTextBox.Visible = true;
            moveListItems(0);
            this.mainQuestionTextBox.Focus();

        }

        private void addSubQuestionButton_Click_1 (object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            int count = subQuestionPanelsList.Count;
            Panel parentPanel = (Panel)this.Parent;

            if (index == 0)
            {
                OXPanel oxPanel = new OXPanel(customFonts);
                this.Controls.Add(oxPanel);
                subQuestionPanelsList.Add(oxPanel);
            }
            else if (index == 1)
            {
                ShortAnswerQuestionPanel shortAnswerQuestionPanel = new ShortAnswerQuestionPanel(customFonts);
                this.Controls.Add(shortAnswerQuestionPanel);
                subQuestionPanelsList.Add(shortAnswerQuestionPanel);
            }
            else if (index == 2)
            {
                EssayQuestionPanel essayQuestionPanel = new EssayQuestionPanel(customFonts);
                this.Controls.Add(essayQuestionPanel);
                subQuestionPanelsList.Add(essayQuestionPanel);
                essayQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += subQuestion_essayAnswerTextBox_LostFocus_1;
                essayQuestionPanel.AnswerPanel.AnswerLabel.Click += subQuestion_essayAnswerLabel_Click_1;
            }
            else if (index == 3)
            {
                MultipleChoiceQuestionPanel multipleChoiceQuestionPanel = new MultipleChoiceQuestionPanel(customFonts);
                this.Controls.Add(multipleChoiceQuestionPanel);
                subQuestionPanelsList.Add(multipleChoiceQuestionPanel);
                multipleChoiceQuestionPanel.AddButton.Click += subQuestion_addExampleButton_Click_1;
            }
            else
            {
                return;
            }

            if (count == 0)
            {
                if (mainQuestionTextBox.Visible)
                {
                    subQuestionPanelsList[count].Location = new Point(100, mainQuestionTextBox.Location.Y + mainQuestionTextBox.Height + 50);
                }
                else
                {
                    subQuestionPanelsList[count].Location = new Point(100, mainQuestionLabel.Location.Y + mainQuestionLabel.Height + 50);
                }
            }
            else
            {
                subQuestionPanelsList[count].Location = new Point(100, subQuestionPanelsList[count - 1].Location.Y + subQuestionPanelsList[count - 1].Height + 20);
            }
            subQuestionPanelsList[count].DeleteButton.Click += subQuestionDeleteButton_Click_1;
            subQuestionPanelsList[count].QuestionLabel.Click += subQuestionLabel_Click_1;
            subQuestionPanelsList[count].QuestionTextBox.LostFocus += subQuestionTextBox_LostFocus_1;
            subQuestionPanelsList[count].Click += Click_1;
            subQuestionPanelsList[count].ExamScorePanel.ScoreTextBox.TextChanged += scoreTextBox_TextChanged;
            subQuestionPanelsList[count].QuestionTextBox.Focus();
            totalScorePanel.ScoreTextBox.Text = (int.Parse(totalScorePanel.ScoreTextBox.Text) + 10).ToString();
            questionKindPanel.QuestionKindComboBox.Enabled = false;
            this.Height = subQuestionPanelsList[count].Location.Y + subQuestionPanelsList[count].Height + 20;
            parentPanel.AutoScrollPosition = new Point(0, parentPanel.Height);
        }

        private void subQuestionDeleteButton_Click_1(object sender, EventArgs e)
        {
            int count;
            int idx;

            QuestionDeleteButton deleteButton = (QuestionDeleteButton)sender;
            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)deleteButton.Parent;
            count = subQuestionPanelsList.Count;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            for (int i = count - 1; i > idx; i--)
            {
                subQuestionPanelsList[i].Location = subQuestionPanelsList[i - 1].Location;
            }
            subQuestionPanelsList.RemoveAt(idx);
            this.Controls.Remove(subQuestionPanel);
            moveListItems(idx);
            count = subQuestionPanelsList.Count;
            if (count == 0)
            {
                questionKindPanel.QuestionKindComboBox.Enabled = true;
                this.Height = 500;
            }
            else
            {
                this.Height = subQuestionPanelsList[count - 1].Location.Y + subQuestionPanelsList[count - 1].Height + 20;
            }
            totalScorePanel.ScoreTextBox.Text = (int.Parse(totalScorePanel.ScoreTextBox.Text) - int.Parse(subQuestionPanel.ExamScorePanel.ScoreTextBox.Text)).ToString();
        }

        private void moveListItems(int moveStartIndex)
        {
            int count;

            count = subQuestionPanelsList.Count;
            if (moveStartIndex == 0 && count > 0)
            {
                if (mainQuestionTextBox.Visible)
                {
                    subQuestionPanelsList[moveStartIndex++].Location = new Point(100, mainQuestionTextBox.Location.Y + mainQuestionTextBox.Height + 50);
                }
                else
                {
                    subQuestionPanelsList[moveStartIndex++].Location = new Point(100, mainQuestionLabel.Location.Y + mainQuestionLabel.Height + 50);
                }
            }

            for (int i = moveStartIndex; i < count; i++)
            {
                subQuestionPanelsList[i].Location = new Point(100, subQuestionPanelsList[i - 1].Location.Y + subQuestionPanelsList[i - 1].Height + 20);
            }

            if (count > 0)
                this.Height = subQuestionPanelsList[count - 1].Location.Y + subQuestionPanelsList[count - 1].Height + 20;

        }

        private void subQuestionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int idx;
            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)textBox.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void subQuestionLabel_Click_1(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int idx;

            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)label.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);

        }

        private void subQuestion_essayAnswerTextBox_LostFocus_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int idx;
            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)textBox.Parent.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void subQuestion_essayAnswerLabel_Click_1(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int idx;

            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)label.Parent.Parent;
            idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void subQuestion_addExampleButton_Click_1(object sender, EventArgs e)
        {
            Panel parentPanel = (Panel)this.Parent;
            AddExampleButton addExampleButton = (AddExampleButton)sender;
            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)addExampleButton.Parent;
            MultipleChoiceQuestionPanel multipleChoiceQuestionPanel = (MultipleChoiceQuestionPanel)addExampleButton.Parent;
            multipleChoiceQuestionPanel.ChoicePaneList[multipleChoiceQuestionPanel.ChoicePaneList.Count - 1].DeleteButton.Click += subQuestion_deleteExampleButton_Click_1;
            int idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
            parentPanel.AutoScrollPosition = new Point(0, parentPanel.Height);
            multipleChoiceQuestionPanel.ChoicePaneList[multipleChoiceQuestionPanel.ChoicePaneList.Count - 1].ExampleTextBox.Focus();
        }

        private void subQuestion_deleteExampleButton_Click_1(object sender, EventArgs e)
        {
            QuestionDeleteButton deleteButton = (QuestionDeleteButton)sender;
            SubQuestionPanel subQuestionPanel = (SubQuestionPanel)deleteButton.Parent.Parent;
            int idx = subQuestionPanelsList.IndexOf(subQuestionPanel);
            moveListItems(idx + 1);
        }

        private void questionKindComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            if (index == 0)
            {
                mainQuestionTextBox.Text = "○/✕ 문제입니다. 각각의 문제의 올바른 답 버튼을 눌러주세요.";
            }
            else if (index == 1)
            {
                mainQuestionTextBox.Text = "단답형 문제입니다. 각각의 문제에 맞는 답을 기입해주세요.";
            }
            else if (index == 2)
            {
                mainQuestionTextBox.Text = "서술형 문제입니다. 각각의 문제에 올바른 서술형 답을 기입해주세요.";
            }
            else
            {
                mainQuestionTextBox.Text = "객관식(선다형) 문제입니다. 각각의 문제에 올바른 답을 체크해주세요.";
            }
            mainQuestionTextBox.Visible = true;
            mainQuestionLabel.Visible = false;
            mainQuestionTextBox.Focus();
        }

        private void scoreTextBox_TextChanged(object sender, EventArgs e)
        {
            int count;
            int sum = 0;

            count = subQuestionPanelsList.Count;

            for (int i = 0; i < count; i++)
            {
                int value = 0;
                if (!subQuestionPanelsList[i].ExamScorePanel.ScoreTextBox.Text.Equals(""))
                {
                    value = int.Parse(subQuestionPanelsList[i].ExamScorePanel.ScoreTextBox.Text);
                }
                sum += value;
            }

            totalScorePanel.ScoreTextBox.Text = sum.ToString();
        }

        private void ControlRemoved_1(object sender, EventArgs e)
        {
            //MessageBox.Show("count: " + oxPanelList.Count);
        }

        private void Click_1(object sender, EventArgs e)
        {
            questionKindPanel.QuestionKindLabel.Focus();
        }
    }
}
