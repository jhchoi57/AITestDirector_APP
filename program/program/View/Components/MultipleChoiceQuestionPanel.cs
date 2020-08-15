using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class MultipleChoiceQuestionPanel : SubQuestionPanel
    {
        private CustomFonts customFonts;
        private int answer { get; set; }
        private List<MultipleChoicePanel> choicePanelList { get; set; }
        private AddExampleButton addButton { get; set; }
        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public List<MultipleChoicePanel> ChoicePaneList
        {
            get { return choicePanelList; }
            set { choicePanelList = value; }
        }
        public AddExampleButton AddButton
        {
            get { return addButton; }
            set { addButton = value; }
        }
        public MultipleChoiceQuestionPanel(CustomFonts customFonts) : base(customFonts)
        {
            this.customFonts = customFonts;
            this.Size = new Size(645, 160);

            addButton = new AddExampleButton(customFonts);
            addButton.Location = new Point(420, 110);
            this.Controls.Add(addButton);
            addButton.Click += addButton_Click_1;

            choicePanelList = new List<MultipleChoicePanel>();

            QuestionTextBox.Size = new System.Drawing.Size(500, 100);
            QuestionTextBox.LostFocus += questionTextBox_LostFocus_1;

            QuestionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            QuestionLabel.Location = new Point(0, 10);
            QuestionLabel.Click += questionLabel_Click_1;

            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);

            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            MultipleChoicePanel choicePanel = new MultipleChoicePanel(customFonts);
            int count = choicePanelList.Count;
            if (count == 0)
            {
                choicePanel.Location = new Point(50, addButton.Location.Y + addButton.Height + 10);
            }
            else
            {
                choicePanel.Location = new Point(50, choicePanelList[count - 1].Location.Y + choicePanelList[count - 1].Height + 5);
            }
            this.Controls.Add(choicePanel);
            choicePanelList.Add(choicePanel);
            choicePanel.ExampleLabel.Click += exampleLabel_Click_2;
            choicePanel.ExampleTextBox.LostFocus += exampleTextBox_LostFocus_2;
            choicePanel.DeleteButton.Click += deleteButton_Click_1;
            choicePanel.ExampleRadioButton.Click += exampleRadioButton_Click_1;
            this.Height = choicePanelList[count].Location.Y + choicePanelList[count].Height + 20;
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
                QuestionTextBox.Visible = false;
                QuestionLabel.Visible = true;
                QuestionLabel.Text = QuestionTextBox.Text;
                addButton.Location = new Point(420, QuestionLabel.Location.Y + QuestionLabel.Height + 10);
                moveListItems(0);
                ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
                DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
            }
        }

        private void questionLabel_Click_1(object sender, EventArgs e)
        {
            QuestionTextBox.Visible = true;
            QuestionLabel.Visible = false;
            addButton.Location = new Point(420, 110);
            moveListItems(0);
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
            QuestionTextBox.Focus();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            QuestionDeleteButton deleteButton = (QuestionDeleteButton)sender;
            MultipleChoicePanel choicePanel = (MultipleChoicePanel)deleteButton.Parent;
            int index = choicePanelList.IndexOf(choicePanel);
            int count = choicePanelList.Count;
            for (int i = count - 1; i > index; i--)
            {
                choicePanelList[i].Location = choicePanelList[i - 1].Location;
            }
            this.Controls.Remove(choicePanel);
            choicePanelList.RemoveAt(index);
            moveListItems(index);
            count = choicePanelList.Count;
            if (count == 0)
            {
                this.Height = 300;
            }
            else
            {
                this.Height = choicePanelList[count - 1].Location.Y + choicePanelList[count - 1].Height + 20;
            }
            ExamScorePanel.Location = new Point(520, (this.Height - ExamScorePanel.Height) / 2);
            DeleteButton.Location = new Point(605, (this.Height - DeleteButton.Height) / 2);
        }

        private void exampleTextBox_LostFocus_2(object sender, EventArgs e)
        {
            TextBox exampleTextBox = (TextBox)sender;
            MultipleChoicePanel choicePanel = (MultipleChoicePanel)exampleTextBox.Parent;
            int index = choicePanelList.IndexOf(choicePanel);
            moveListItems(index + 1);
        }
        private void exampleLabel_Click_2(object sender, EventArgs e)
        {
            Label exampleLabel = (Label)sender;
            MultipleChoicePanel choicePanel = (MultipleChoicePanel)exampleLabel.Parent;
            int index = choicePanelList.IndexOf(choicePanel);
            moveListItems(index + 1);
        }
        private void moveListItems(int moveStartIndex)
        {
            int count;

            count = choicePanelList.Count;
            if (moveStartIndex == 0 && count > 0)
            {
                if (QuestionTextBox.Visible)
                {
                    choicePanelList[moveStartIndex++].Location = new Point(50, addButton.Location.Y + addButton.Height + 10);
                }
                else
                {
                    choicePanelList[moveStartIndex++].Location = new Point(50, addButton.Location.Y + addButton.Height + 10);
                }
            }

            for (int i = moveStartIndex; i < count; i++)
            {
                choicePanelList[i].Location = new Point(50, choicePanelList[i - 1].Location.Y + choicePanelList[i - 1].Height + 5);
            }

            if (count > 0)
                this.Height = choicePanelList[count - 1].Location.Y + choicePanelList[count - 1].Height + 20;
            else
                this.Height = addButton.Location.Y + addButton.Height + 20;
        }

        private void exampleRadioButton_Click_1(object sender, EventArgs e)
        {
            int count = choicePanelList.Count;
            RadioButton exampRadioButton = (RadioButton)sender;
            MultipleChoicePanel choicePanel = (MultipleChoicePanel)exampRadioButton.Parent;

            for (int i = 0; i < count; i++)
            {
                if (choicePanelList[i] != choicePanel)
                {
                    choicePanelList[i].ExampleRadioButton.Checked = false;
                }
            }
        }
    }
}
