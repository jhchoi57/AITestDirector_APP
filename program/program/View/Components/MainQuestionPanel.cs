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
        private AddSubQuestionButton addSubQuestionButton;
        private QuestionKindPanel questionKindPanel;
        private ScorePanel totalScorePanel { get; set; }
        private Label mainQuestionLabel { get; set; }
        private TextBox mainQuestionTextBox { get; set; }
        private List<OXPanel> oxPanelList { get; set; }

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
        public TextBox MainQuestionTextBox
        {
            get { return mainQuestionTextBox; }
            set { mainQuestionTextBox = value; }
        }
        public List<OXPanel> OXPanelList
        {
            get { return oxPanelList; }
            set { oxPanelList = value; }
        }
        

        public MainQuestionPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(800, 500);
            this.BackColor = Color.White;
            this.ControlRemoved += ControlRemoved_1;

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
            this.Controls.Add(totalScorePanel);

            mainQuestionTextBox = new TextBox();
            mainQuestionTextBox.Location = new Point(50, 50);
            mainQuestionTextBox.Size = new Size(700, 100);
            mainQuestionTextBox.AutoSize = true;
            mainQuestionTextBox.Multiline = true;
            mainQuestionTextBox.ScrollBars = ScrollBars.Vertical;
            mainQuestionTextBox.Font = customFonts.TextBoxFont();
            this.Controls.Add(mainQuestionTextBox);
            mainQuestionTextBox.LostFocus += mainQuestionTextBox_LostFocus_1;

            mainQuestionLabel = new Label();
            mainQuestionLabel.Location = new Point(50, 53);
            mainQuestionLabel.Visible = false;
            mainQuestionLabel.MaximumSize = new Size(700, 0);
            mainQuestionLabel.AutoSize = true;
            mainQuestionLabel.Font = customFonts.TextBoxFont();
            this.Controls.Add(mainQuestionLabel);
            mainQuestionLabel.Click += mainQuestionLabel_Click_1;

            oxPanelList = new List<OXPanel>();
        }

        private void mainQuestionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            string str = this.mainQuestionTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;

                this.mainQuestionTextBox.Visible = false;
                this.mainQuestionLabel.Visible = true;
                this.mainQuestionLabel.Text = this.mainQuestionTextBox.Text;

                moveListItems(index, 0);
            }
        }

        private void mainQuestionLabel_Click_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;

            this.mainQuestionLabel.Visible = false;
            this.mainQuestionTextBox.Visible = true;
            moveListItems(index, 0);
            this.mainQuestionTextBox.Focus();

        }

        private void addSubQuestionButton_Click_1 (object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            int count;
            Panel parentPanel = (Panel)this.Parent;

            if (index == 0)
            {
                OXPanel oxPanel = new OXPanel(customFonts);
                count = oxPanelList.Count;
                if (count == 0)
                {
                    if (mainQuestionTextBox.Visible)
                    {
                        oxPanel.Location = new Point(100, mainQuestionTextBox.Location.Y + mainQuestionTextBox.Height + 50);
                    }
                    else
                    {
                        oxPanel.Location = new Point(100, mainQuestionLabel.Location.Y + mainQuestionLabel.Height + 50);
                    }
                }
                else
                {
                    oxPanel.Location = new Point(100, oxPanelList[count - 1].Location.Y + oxPanelList[count - 1].Height + 20);
                }
                this.Controls.Add(oxPanel);
                oxPanelList.Add(oxPanel);
                oxPanel.DeleteButton.Click += subQuestionDeleteButton_Click_1;
                oxPanel.QuestionLabel.Click += subQuestionLabel_Click_1;
                oxPanel.QuestionTextBox.LostFocus += subQuestionTextBox_LostFocus_1;
                oxPanel.QuestionTextBox.Focus();
                this.Height = oxPanel.Location.Y + oxPanel.Height + 20;
            }

            questionKindPanel.QuestionKindComboBox.Enabled = false;
            parentPanel.AutoScrollPosition = new Point(0, parentPanel.Height);
        }

        private void subQuestionDeleteButton_Click_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            int count;
            int idx;

            if (index == 0)
            {
                QuestionDeleteButton deleteButton = (QuestionDeleteButton)sender;
                OXPanel oxPanel = (OXPanel)deleteButton.Parent;
                count = oxPanelList.Count;
                idx = oxPanelList.IndexOf(oxPanel);
                for (int i = count - 1; i > idx; i--)
                {
                    oxPanelList[i].Location = oxPanelList[i - 1].Location;
                }
                oxPanelList.RemoveAt(idx);
                this.Controls.Remove(oxPanel);
                count = oxPanelList.Count;
                if (count == 0)
                {
                    questionKindPanel.QuestionKindComboBox.Enabled = true;
                    this.Height = 500;
                } 
                else
                {
                    this.Height = oxPanelList[count - 1].Location.Y + oxPanelList[count - 1].Height + 20;
                }
            }
        }

        private void moveListItems(int comboBoxIndex, int moveStartIndex)
        {
            int count;
            if (comboBoxIndex == 0)
            {
                count = oxPanelList.Count;
                if (moveStartIndex == 0 && count > 0)
                {
                    if (mainQuestionTextBox.Visible)
                    {
                        oxPanelList[moveStartIndex++].Location = new Point(100, mainQuestionTextBox.Location.Y + mainQuestionTextBox.Height + 50);
                    }
                    else
                    {
                        oxPanelList[moveStartIndex++].Location = new Point(100, mainQuestionLabel.Location.Y + mainQuestionLabel.Height + 50);
                    }
                }
            
                for (int i = moveStartIndex; i < count; i++)
                {
                    oxPanelList[i].Location = new Point(100, oxPanelList[i - 1].Location.Y + oxPanelList[i - 1].Height + 20);
                }

                if (count > 0)
                    this.Height = oxPanelList[count - 1].Location.Y + oxPanelList[count - 1].Height + 20;
            }
        }

        private void subQuestionTextBox_LostFocus_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            TextBox textBox = (TextBox)sender;
            int idx;
            if (index == 0)
            {
                OXPanel oxPanel = (OXPanel)textBox.Parent;
                idx = oxPanelList.IndexOf(oxPanel);
                moveListItems(index, idx + 1);
            }
        }

        private void subQuestionLabel_Click_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            Label label = (Label)sender;
            int idx;

            if (index == 0)
            {
                OXPanel oxPanel = (OXPanel)label.Parent;
                idx = oxPanelList.IndexOf(oxPanel);
                moveListItems(index, idx + 1);
            }
            
        }

        private void questionKindComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = questionKindPanel.QuestionKindComboBox.SelectedIndex;
            if (index == 0)
            {
                mainQuestionTextBox.Text = "○/✕ 문제입니다. 각각의 문제의 올바른 답 버튼을 눌러주세요.";
                mainQuestionTextBox.Visible = true;
                mainQuestionLabel.Text = "○/✕ 문제입니다. 각각의 문제의 올바른 답 버튼을 눌러주세요.";
                mainQuestionLabel.Visible = false;
            }
            else if (index == 1)
            {
                mainQuestionTextBox.Text = "단답형 문제입니다. 각각의 문제에 맞는 답을 기입해주세요.";
                mainQuestionTextBox.Visible = true;
                mainQuestionLabel.Text = "단답형 문제입니다. 각각의 문제에 맞는 답을 기입해주세요.";
                mainQuestionLabel.Visible = false;
            }
            else if (index == 2)
            {
                mainQuestionTextBox.Text = "서술형 문제입니다. 각각의 문제에 올바른 서술형 답을 기입해주세요.";
                mainQuestionTextBox.Visible = true;
                mainQuestionLabel.Text = "서술형 문제입니다. 각각의 문제에 올바른 서술형 답을 기입해주세요.";
                mainQuestionLabel.Visible = false;
            }
            else if (index == 3)
            {
                mainQuestionTextBox.Text = "객관식(선다형) 문제입니다. 각각의 문제에 올바른 답을 체크해주세요.";
                mainQuestionTextBox.Visible = true;
                mainQuestionLabel.Text = "객관식(선다형) 문제입니다. 각각의 문제에 올바른 답을 체크해주세요.";
                mainQuestionLabel.Visible = false;
            }
            else
            {
                mainQuestionTextBox.Text = "빈 칸 채우기 문제입니다. 각각의 문제에 올바른 답을 채워주세요.";
                mainQuestionTextBox.Visible = true;
                mainQuestionLabel.Text = "빈 칸 채우기 문제입니다. 각각의 문제에 올바른 답을 채워주세요.";
                mainQuestionLabel.Visible = false;
            }
        }

        private void ControlRemoved_1(object sender, EventArgs e)
        {
            MessageBox.Show("count: " + oxPanelList.Count);
        }
    }
}
