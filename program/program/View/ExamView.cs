using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class ExamView : Form
    {
        private CustomFonts customFonts;

        public ExamView()
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
        }

        private void ExamView_Load1(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();

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

            this.examMainQuestionPanelList = new List<ExamMainQuestionPanel>();
            sample_subQuestions();

            this.examPageNavigationPanel.PageLeftButton.Click += pageLeftButton_Click_1;
            this.examPageNavigationPanel.PageRightButton.Click += pageRightButton_Click_1;
            this.examPageNavigationPanel.NowPageTextBox.KeyPress += nowPageTextBox_KeyPress_1;
            this.examPageNavigationPanel.NowPageTextBox.LostFocus += nowPageTextBox_LostFocus_1;
            this.examPageNavigationPanel.NowPageTextBox.TextChanged += nowPageTextBox_TextChanged_1;
        }

        private void sample_subQuestions()
        {
            List<ExamSubQuestionPanel> examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            ExamMainQuestionPanel examMainQuestionPanel;

            for (int i = 0; i < 5; i++)
            {
                ExamOXPanel examOXPanel = new ExamOXPanel(customFonts, "ox question" + i, 10);
                examSubQuestionPanelList.Add(examOXPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "OX sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = new ExamShortAnswerQuestionPanel(customFonts, "short answer question" + i, 10);
                examSubQuestionPanelList.Add(examShortAnswerQuestionPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "short answer sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                ExamEssayQuestionPanel examEssayQuestionPanel = new ExamEssayQuestionPanel(customFonts, "essay question" + i, 10, 4000);
                examSubQuestionPanelList.Add(examEssayQuestionPanel);
            }
            examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, "essay sample", examSubQuestionPanelList);
            examMainQuestionPanelList.Add(examMainQuestionPanel);

            examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
            for (int i = 0; i < 5; i++)
            {
                string[] question = { "hi", "bye", "good" };
                ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = new ExamMultipleChoiceQuestionPanel(customFonts, "multiple choice question" + i, 10, question);
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
    }
}
