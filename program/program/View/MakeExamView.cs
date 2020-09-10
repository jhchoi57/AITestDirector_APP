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

        public MakeExamView()
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;

        }

        private void MakeExamView_Load1(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();
            string[] lectureItems = { "운영체제", "컴퓨터구조론", "C프로그래밍및실습" };

            this.exitButton = new ExitButton(customFonts);
            this.settingPanel.Controls.Add(this.exitButton);
            this.exitButton.Location = new System.Drawing.Point(349, 0);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);

            this.minimizeButton = new MinimizeButton(customFonts);
            this.settingPanel.Controls.Add(this.minimizeButton);
            this.minimizeButton.Location = new System.Drawing.Point(319, 0);
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(0, 640);
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
            this.examTimeLabel.Font = customFonts.LabelFont();
            this.examTimeLabel2.Font = customFonts.LabelFont();
            this.examTimeTextBox.Font = customFonts.TextBoxFont();
            this.saveButton.Font = customFonts.LabelFont();
            this.cancelButton.Font = customFonts.LabelFont();

            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;

            this.examLectureNameComboBox.Items.AddRange(lectureItems);
            this.examLectureNameComboBox.SelectedIndex = 0;

            this.mainQuestionPanelList = new List<MainQuestionPanel>();
            this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
            this.mainQuestionPanelList[0].Location = new Point(30, 30);
            this.examPanel.Controls.Add(this.mainQuestionPanelList[0]);
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

        // 메인 문제 페이지 추가 버튼
        private void addPageButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;
            this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
            this.mainQuestionPanelList[count].Location = new Point(30, 30);
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

                examPageNavigationPanel.NowPageTextBox.Text = (count - 1).ToString();
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
    }
}
