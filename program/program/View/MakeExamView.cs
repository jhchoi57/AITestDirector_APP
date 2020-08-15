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
            CustomFonts customFonts = new CustomFonts();
            string[] lectureItems = { "운영체제", "컴퓨터구조론", "C프로그래밍및실습" };

            this.exitButton.Font = customFonts.LabelFont();
            this.minimizeButton.Font = customFonts.LabelFont();
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
            this.pageLeftButton.Font = customFonts.LabelFont();
            this.pageRightButton.Font = customFonts.LabelFont();
            this.nowPageTextBox.Font = customFonts.TextBoxFont();
            this.pageSlashLabel.Font = customFonts.LabelFont();
            this.wholePageLabel.Font = customFonts.TextBoxFont();
            this.addQuestionButton.Font = customFonts.TextBoxFont();
            this.removeQuestionButton.Font = customFonts.TextBoxFont();

            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;

            this.examLectureNameComboBox.Items.AddRange(lectureItems);
            this.examLectureNameComboBox.SelectedIndex = 0;

            this.mainQuestionPanel = new MainQuestionPanel(customFonts);
            this.mainQuestionPanel.Location = new Point(30, 30);
            this.examPanel.Controls.Add(this.mainQuestionPanel);
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


    }
}
