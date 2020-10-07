using Newtonsoft.Json.Linq;
using program.Controller;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class MakeExamView : Form
    {
        private CustomFonts customFonts;
        private MainController mainController;
        private List<MainQuestionPanel> mainQuestionPanelList;
        private List<ShortCutButton> shortCutButtonList;
        private int questionCount;

        public MakeExamView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
            this.mainController = mainController;
        }

        private void MakeExamView_Load1(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();
            string[] lectureItems = { "운영체제", "컴퓨터구조론", "C프로그래밍및실습" };

            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(0, 612);
            this.mainPanel.Controls.Add(this.examPageNavigationPanel);
            
            this.examPageNavigationPanel.PageLeftButton.Click += pageLeftButton_Click_1;
            this.examPageNavigationPanel.PageRightButton.Click += pageRightButton_Click_1;
            this.examPageNavigationPanel.NowPageTextBox.KeyPress += nowPageTextBox_KeyPress_1;
            this.examPageNavigationPanel.NowPageTextBox.LostFocus += nowPageTextBox_LostFocus_1;
            this.examPageNavigationPanel.NowPageTextBox.TextChanged += nowPageTextBox_TextChanged_1;
            this.examPageNavigationPanel.AddPageButton.Click += addPageButton_Click_1;
            this.examPageNavigationPanel.RemovePageButton.Click += removePageButton_Click_1;

            this.examNameLabel.Font = customFonts.LabelFont();
            this.examNameTextBox.Font = customFonts.TextBoxFont();
            this.examLectureNameLabel.Font = customFonts.LabelFont();
            this.examLectureNameComboBox.Font = customFonts.LabelFont();
            this.examPercentLabel.Font = customFonts.LabelFont();
            this.examPercentLabel2.Font = customFonts.LabelFont();
            this.examPercentTextBox.Font = customFonts.TextBoxFont();
            this.examPeriodLabel.Font = customFonts.LabelFont();
            this.startDateTimePicker.Font = customFonts.TextBoxFont();
            this.endDateTimePicker.Font = customFonts.TextBoxFont();
            this.startDateTimeLabel.Font = customFonts.TextBoxFont();
            this.endDateTimeLabel.Font = customFonts.TextBoxFont();
            this.saveButton.Font = customFonts.LabelFont();
            this.cancelButton.Font = customFonts.LabelFont();
            this.examShortCutLabel.Font = customFonts.LabelFont();

            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;

            this.examLectureNameComboBox.Items.AddRange(lectureItems);
            this.examLectureNameComboBox.SelectedIndex = 0;

            this.mainQuestionPanelList = new List<MainQuestionPanel>();
            this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
            this.mainQuestionPanelList[0].Location = new Point(30, 30);
            this.mainQuestionPanelList[0].AddQuestionButton.Click += addSubQuestionButton_Click;
            this.examPanel.Controls.Add(this.mainQuestionPanelList[0]);

            this.saveButton.Click += saveButton_Click_1;
            this.cancelButton.Click += cancelButton_Click_1;

            this.shortCutButtonList = new List<ShortCutButton>();
            questionCount = 0;
        }

        // 메인 문제 페이지 추가 버튼
        private void addPageButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;
            this.examPanel.VerticalScroll.Value = 0;
            this.examPanel.PerformLayout();
            this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
            this.mainQuestionPanelList[count].Location = new Point(30, 30);
            this.mainQuestionPanelList[count].AddQuestionButton.Click += addSubQuestionButton_Click;
            this.examPanel.Controls.Add(this.mainQuestionPanelList[count]);
            this.examPageNavigationPanel.WholePageLabel.Text = (count + 1).ToString();
            this.examPageNavigationPanel.NowPageTextBox.Text = (count + 1).ToString();
        }

        // 현재 메인 문제 페이지 삭제 버튼
        private void removePageButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;

            if (count == 1)
            {
                MessageBox.Show("문제 페이지는 하나 이상 존재해야합니다.", "문제 페이지");
                return;
            }

            if (MessageBox.Show("문제 페이지를 정말 삭제하시겠습니까?", "문제 페이지 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
                this.examPanel.Controls.Remove(mainQuestionPanelList[page]);
                mainQuestionPanelList.Remove(mainQuestionPanelList[page]);

                examPageNavigationPanel.NowPageTextBox.Text = "1";
                examPageNavigationPanel.WholePageLabel.Text = (count - 1).ToString();
            }
        }

        private void nowPageTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void nowPageTextBox_LostFocus_1(object sender, EventArgs e)
        {
            if (this.examPageNavigationPanel.NowPageTextBox.Text == "" || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > mainQuestionPanelList.Count || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = "1";
            }
        }

        private void nowPageTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int page = 0;
            int count = mainQuestionPanelList.Count;

            if (this.examPageNavigationPanel.NowPageTextBox.Text == "")
                return;

            if(!this.examPageNavigationPanel.NowPageTextBox.Equals("") && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= mainQuestionPanelList.Count && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > 0)
            {
                page = int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) - 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (page != i)
                {
                    mainQuestionPanelList[i].Visible = false;
                }
            }
            mainQuestionPanelList[page].Visible = true;
        }

        private void pageLeftButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;

            if (page > 0 )
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = page.ToString();
            }
        }

        private void pageRightButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            int count = mainQuestionPanelList.Count;

            if (page < count - 1)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = (page + 2).ToString();
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;
            JArray jArray = new JArray();
            int num = 0;

            for (int i = 0; i < count; i++)
            {
                List<SubQuestionPanel> subQuestionPanelList = mainQuestionPanelList[i].SubQuestionPanelsList;
                int cnt = subQuestionPanelList.Count;
                JObject mainJObject = new JObject();
                JArray subArray = new JArray();
                mainJObject.Add("question", mainQuestionPanelList[i].MainQuestionLabel.Text);
                for (int j = 0; j < cnt; j++)
                {
                    int type = subQuestionPanelList[j].Type;
                    JObject jObject = new JObject();
                    jObject.Add("type", type);

                    if (subQuestionPanelList[j].QuestionLabel.Text == "")
                    {
                        MessageBox.Show("문제를 작성해주세요. (" + (num + 1).ToString() + "번 문제)", "출제 오류");
                        shortCutButtonList[num].PerformClick();
                        return;
                    }

                    jObject.Add("question", subQuestionPanelList[j].QuestionLabel.Text);
                    if (type == 0)
                    {
                        OXPanel oxPanel = (OXPanel)subQuestionPanelList[j];
                        jObject.Add("answer", oxPanel.Answer);
                    }
                    else if (type == 1)
                    {
                        ShortAnswerQuestionPanel shortAnswerQuestionPanel = (ShortAnswerQuestionPanel)subQuestionPanelList[j];
                        jObject.Add("answer", shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text);
                    }
                    else if (type == 2)
                    {
                        EssayQuestionPanel essayQuestionPanel = (EssayQuestionPanel)subQuestionPanelList[j];
                        jObject.Add("answer", essayQuestionPanel.AnswerPanel.AnswerLabel.Text);
                    }
                    else
                    {
                        MultipleChoiceQuestionPanel multipleChoiceQuestionPanel = (MultipleChoiceQuestionPanel)subQuestionPanelList[j];
                        List<MultipleChoicePanel> multipleChoicePanelList = multipleChoiceQuestionPanel.ChoicePaneList;
                        int len = multipleChoicePanelList.Count;
                        if (len == 0)
                        {
                            MessageBox.Show("객관식 문제는 보기가 반드시 필요합니다. (" + (num + 1).ToString() + "번 문제)", "출제 오류");
                            shortCutButtonList[num].PerformClick();
                            return;
                        }
                        else if (multipleChoiceQuestionPanel.Answer == -1)
                        {
                            MessageBox.Show("객관식 문제의 정답은 반드시 필요합니다. (" + (num + 1).ToString() + "번 문제)", "출제 오류");
                            shortCutButtonList[num].PerformClick();
                            return;
                        }
                        jObject.Add("answer", multipleChoiceQuestionPanel.Answer);
                    }
                    subArray.Add(jObject);
                    num++;
                }
                mainJObject.Add("subQuestions", subArray);
                if (cnt > 0)
                {
                    jArray.Add(mainJObject);
                }
            }
            Console.WriteLine(jArray);
        }

        private void addSubQuestionButton_Click(object sender, EventArgs e)
        {
            int locationX, locationY;
            int nowPageIndex;
            ShortCutButton shortCutButton = new ShortCutButton(customFonts, questionCount + 1);
            locationY = (questionCount / 4) * 27;
            locationX = (questionCount % 4) * 77;
            this.examShortCutPanel.Controls.Add(shortCutButton);
            this.shortCutButtonList.Add(shortCutButton);
            shortCutButton.Location = new Point(locationX, locationY);
            nowPageIndex = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            shortCutButton.MainQuestionNo = nowPageIndex;
            shortCutButton.SubQuestionNo = mainQuestionPanelList[nowPageIndex].SubQuestionPanelsList.Count - 1;
            mainQuestionPanelList[nowPageIndex].SubQuestionPanelsList[shortCutButton.SubQuestionNo].DeleteButton.Click += removeSubQuestionButton_Click;
            shortCutButton.Click += shortCutButton_Click_1;
            questionCount++;
        }

        private void removeSubQuestionButton_Click(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count, i;
            int locationY;
            int locationX;
            int index = 0;

            for (i = 0; i < count; i++)
            {
                int subCount = mainQuestionPanelList[i].SubQuestionPanelsList.Count;

                for (int j = 0; j < subCount; j++)
                {
                    ShortCutButton shortCutButton = this.shortCutButtonList[index];
                    locationY = (index / 4) * 27;
                    locationX = (index % 4) * 77;
                    shortCutButton.Location = new Point(locationX, locationY);
                    shortCutButton.MainQuestionNo = i;
                    shortCutButton.SubQuestionNo = j;
                    index++;
                }
            }

            for (i = index; i < questionCount; i++)
            {
                this.examShortCutPanel.Controls.Remove(this.shortCutButtonList[i]);
                this.shortCutButtonList.RemoveAt(i);
            }
            questionCount = index;
        }

        private void shortCutButton_Click_1(object sender, EventArgs e)
        {
            ShortCutButton shortCutButton = (ShortCutButton)sender;
            int i = shortCutButton.MainQuestionNo;
            int j = shortCutButton.SubQuestionNo;
            int locationY;

            locationY = mainQuestionPanelList[i].SubQuestionPanelsList[j].Location.Y;
            Console.WriteLine("Click" + i.ToString() + "," + j.ToString() + ", " + locationY.ToString());
            this.examPageNavigationPanel.NowPageTextBox.Text = (i + 1).ToString();

            try
            {
                this.examPanel.VerticalScroll.Value = locationY;
                this.examPanel.PerformLayout();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
