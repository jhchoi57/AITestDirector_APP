using program.Controller;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class ExamView : Form
    {
        private CustomFonts customFonts;

        private Timer timer;
        private DateTime examDate;
        private List<ShortCutButton> shortCutButtonList;
        private ChatPanel chatPanel;

        private MainController mainController;

        public ExamView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
            DateTime date = DateTime.Now;
            examDate = date.AddHours(1);
            this.mainController = mainController;
        }       

        private void ExamView_Load1(object sender, EventArgs e)
        {
            // 프로세스 제어
            //ProcessController processController = new ProcessController();
            //processController.KillProcess();

            // 폰트
            customFonts = new CustomFonts();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick_1;
            timer.Start();

            shortCutButtonList = new List<ShortCutButton>();

            this.chatPanel = new ChatPanel(customFonts);
            this.chatPanel.Location = new Point(30, 240);
            this.mainPanel.Controls.Add(this.chatPanel);
            this.chatPanel.BringToFront();
            this.chatPanel.MinimizeBtn.Click += chatPanelMinimizeButton_Click_1;

            this.openChatBoxPanel.Click += openChatBoxPanel_Click_1;
            this.openChatBoxLabel.Click += openChatBoxPanel_Click_1;

            this.examLectureLabel.Font = customFonts.LabelFont();
            this.examNameLabel.Font = customFonts.LabelFont();
            this.examPercentLabel.Font = customFonts.LabelFont();
            this.openChatBoxLabel.Font = customFonts.NormalFont();
            this.openChatAlertLabel.Font = customFonts.SmallFont();

            this.exitButton = new ExitButton(customFonts);
            this.examInfoPanel.Controls.Add(this.exitButton);
            this.exitButton.Location = new System.Drawing.Point(349, 0);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);

            this.minimizeButton = new MinimizeButton(customFonts);
            this.examInfoPanel.Controls.Add(this.minimizeButton);
            this.minimizeButton.Location = new System.Drawing.Point(319, 0);
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(0, 640);
            this.mainPanel.Controls.Add(this.examPageNavigationPanel);
            this.examPageNavigationPanel.AddPageButton.Visible = false;
            this.examPageNavigationPanel.RemovePageButton.Visible = false;

            this.endExamButton.Font = customFonts.LabelFont();
            this.examTimeLabel.Font = customFonts.TimeLabelFont();
            this.examShortCutLabel.Font = customFonts.TextBoxFont();

            this.examMainQuestionPanelList = new List<ExamMainQuestionPanel>();
            sample_subQuestions();

            this.examPageNavigationPanel.PageLeftButton.Click += pageLeftButton_Click_1;
            this.examPageNavigationPanel.PageRightButton.Click += pageRightButton_Click_1;
            this.examPageNavigationPanel.NowPageTextBox.KeyPress += nowPageTextBox_KeyPress_1;
            this.examPageNavigationPanel.NowPageTextBox.LostFocus += nowPageTextBox_LostFocus_1;
            this.examPageNavigationPanel.NowPageTextBox.TextChanged += nowPageTextBox_TextChanged_1;

            this.examPageNavigationPanel.Controls.Add(this.openChatBoxPanel);
            initShortCutButton();

            this.endExamButton.Click += endExamButton_Click_1;
        }

        private void sample_subQuestions()
        {
            List<ExamSubQuestionPanel> examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            ExamMainQuestionPanel examMainQuestionPanel;
            int index = 1;

            for (int i = 0; i < 5; i++)
            {
                ExamOXPanel examOXPanel = new ExamOXPanel(customFonts, (index++).ToString() + ". " + "ox question" + i, 10);
                examSubQuestionPanelList.Add(examOXPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "OX sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = new ExamShortAnswerQuestionPanel(customFonts, (index++).ToString() + ". " + "short answer question" + i, 10);
                examSubQuestionPanelList.Add(examShortAnswerQuestionPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "short answer sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                ExamEssayQuestionPanel examEssayQuestionPanel = new ExamEssayQuestionPanel(customFonts, (index++).ToString() + ". " + "essay question" + i, 10, 4000);
                examSubQuestionPanelList.Add(examEssayQuestionPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "essay sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                string[] question = { "hi", "bye", "good" };
                ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = new ExamMultipleChoiceQuestionPanel(customFonts, (index++).ToString() + ". " + "multiple choice question" + i, 10, question);
                examSubQuestionPanelList.Add(examMultipleChoiceQuestionPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "multiple choice sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            for (int i = 0; i < 4; i++)
            {
                this.examMainQuestionPanelList[i].Location = new Point(30, 30);
                this.examPanel.Controls.Add(this.examMainQuestionPanelList[i]);
                if (i != 0)
                {
                    examMainQuestionPanelList[i].Visible = false;
                }
            }
            this.examPageNavigationPanel.WholePageLabel.Text = "4";
            this.examPageNavigationPanel.NowPageTextBox.Text = "1";
        }

        // 나가기 버튼
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 최소화 버튼
        private void minimizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (this.examPageNavigationPanel.NowPageTextBox.Text == "" || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > examMainQuestionPanelList.Count || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = "1";
            }
        }

        private void nowPageTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int page = 0;
            int count = examMainQuestionPanelList.Count;

            if (this.examPageNavigationPanel.NowPageTextBox.Text == "")
                return;

            if (!this.examPageNavigationPanel.NowPageTextBox.Equals("") && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= examMainQuestionPanelList.Count && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > 0)
            {
                page = int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) - 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (page != i)
                {
                    examMainQuestionPanelList[i].Visible = false;
                }
            }
            examMainQuestionPanelList[page].Visible = true;
        }

        private void pageLeftButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;

            if (page > 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = page.ToString();
            }
        }

        private void pageRightButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            int count = examMainQuestionPanelList.Count;

            if (page < count - 1)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = (page + 2).ToString();
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            double diffTotalSeconds = (examDate - date).TotalSeconds;

            int hour = (int)diffTotalSeconds / 3600;
            int minute = (int)diffTotalSeconds % 3600 / 60;
            int second = (int)diffTotalSeconds % 60;

            string hourString = hour.ToString();
            string minuteString;
            string secondString;

            if (minute < 10)
                minuteString = "0" + minute.ToString();
            else
                minuteString = minute.ToString();
            if (second < 10)
                secondString = "0" + second.ToString();
            else
                secondString = second.ToString();

            this.examTimeLabel.Text = hourString + ":" + minuteString + ":" + secondString;
        }

        private void initShortCutButton()
        {
            int index = 0, count = examMainQuestionPanelList.Count, i;
            int locationY;
            int locationX;

            for (i = 0; i < count; i++)
            {
                int subCount = examMainQuestionPanelList[i].SubQuestionPanelsList.Count;

                for (int j = 0; j < subCount; j++)
                {
                    ShortCutButton shortCutButton = new ShortCutButton(customFonts, index + 1);
                    locationY = (index / 4) * 27;
                    locationX = (index % 4) * 77;
                    this.examShortCutPanel.Controls.Add(shortCutButton);
                    this.shortCutButtonList.Add(shortCutButton);
                    shortCutButton.Location = new Point(locationX, locationY);
                    shortCutButton.MainQuestionNo = i;
                    shortCutButton.SubQuestionNo = j;
                    shortCutButton.Click += shortCutButton_Click_1;
                    index++;
                    ExamSubQuestionPanel examSubQuestionPanel = examMainQuestionPanelList[i].SubQuestionPanelsList[j];
                    switch (examSubQuestionPanel.Type)
                    {
                        case 0:
                            ExamOXPanel examOXPanel = (ExamOXPanel)examSubQuestionPanel;
                            examOXPanel.OButton.Click += ox_enter_answer;
                            examOXPanel.XButton.Click += ox_enter_answer;
                            break;
                        case 1:
                            ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = (ExamShortAnswerQuestionPanel)examSubQuestionPanel;
                            examShortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += short_enter_answer;
                            break;
                        case 2:
                            ExamEssayQuestionPanel examEssayQuestionPanel = (ExamEssayQuestionPanel)examSubQuestionPanel;
                            examEssayQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += essay_enter_answer;
                            break;
                        case 3:
                            ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = (ExamMultipleChoiceQuestionPanel)examSubQuestionPanel;
                            add_event_at_radiobutton(examMultipleChoiceQuestionPanel.ChoicePaneList);
                            break;
                        default: break;
                    }
                }
            }
        }

        private void add_event_at_radiobutton(List<ExamMultipleChoicePanel> choicePanelList)
        {
            int count = choicePanelList.Count;

            for (int i = 0; i < count; i++)
            {
                choicePanelList[i].ExampleRadioButton.Click += multiple_enter_answer;
            }
        }

        private void shortCutButton_Click_1(object sender, EventArgs e)
        {
            ShortCutButton shortCutButton = (ShortCutButton)sender;
            int i = shortCutButton.MainQuestionNo;
            int j = shortCutButton.SubQuestionNo;
            int locationY;
           
            locationY = examMainQuestionPanelList[i].SubQuestionPanelsList[j].Location.Y;
            
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

        private void ox_enter_answer(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ExamSubQuestionPanel examOXPanel = (ExamSubQuestionPanel)button.Parent;
            int index = Find_shortCutButton_index(examOXPanel);

            shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private void short_enter_answer(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ShortAnswerPanel shortAnswerPanel = (ShortAnswerPanel)textBox.Parent;
            ExamSubQuestionPanel examShortAnswerQuestionPanel = (ExamSubQuestionPanel)shortAnswerPanel.Parent;
            int index = Find_shortCutButton_index(examShortAnswerQuestionPanel);

            if (textBox.Visible == true)
                shortCutButtonList[index].BackColor = Color.White;
            else
                shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private void essay_enter_answer(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            EssayAnswerPanel essayAnswerPanel = (EssayAnswerPanel)textBox.Parent;
            ExamSubQuestionPanel examEssayQuestionPanel = (ExamSubQuestionPanel)essayAnswerPanel.Parent;
            int index = Find_shortCutButton_index(examEssayQuestionPanel);

            if (textBox.Visible == true)
                shortCutButtonList[index].BackColor = Color.White;
            else
                shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private void multiple_enter_answer(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            ExamMultipleChoicePanel multipleChoicePanel = (ExamMultipleChoicePanel)radioButton.Parent;
            ExamSubQuestionPanel multipleChoiceQuestionPanel = (ExamSubQuestionPanel)multipleChoicePanel.Parent;
            int index = Find_shortCutButton_index(multipleChoiceQuestionPanel);

            shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private int Find_shortCutButton_index(ExamSubQuestionPanel examSubQuestionPanel)
        {
            int index = 0;
            int count = examMainQuestionPanelList.Count;

            for (int i = 0; i < count; i++)
            {
                int subCount = examMainQuestionPanelList[i].SubQuestionPanelsList.Count;
                for (int j = 0; j < subCount; j++)
                {
                    if (examMainQuestionPanelList[i].SubQuestionPanelsList[j] == examSubQuestionPanel)
                    {
                        return index;
                    }

                    index++;
                }
            }

            return -1;
        }
        private void openChatBoxPanel_Click_1(object sender, EventArgs e)
        {
            openChatBoxPanel.Visible = false;
            chatPanel.Visible = true;
        }

        private void chatPanelMinimizeButton_Click_1(object sender, EventArgs e)
        {
            openChatBoxPanel.Visible = true;
            chatPanel.Visible = false;
        }

        private void endExamButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("시험을 종료하시겠습니까?\n(시험 종료 시 재접속이 불가능합니다.)", "시험 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 시험 결과 전송하는 함수 진행 후
                mainController.moveToPreviousForm();
            }
        }
    }
}
