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
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            Font font = new Font(privateFont.Families[1], 10f);
            Font labelFont = new Font(privateFont.Families[1], 13f);
            Font textBoxFont = new Font(privateFont.Families[1], 12f);
            Font smallFont = new Font(privateFont.Families[1], 8f);
            string[] lectureItems = { "운영체제", "컴퓨터구조론", "C프로그래밍및실습" };

            this.exitButton.Font = labelFont;
            this.minimizeButton.Font = labelFont;
            this.examNameLabel.Font = labelFont;
            this.examNameTextBox.Font = textBoxFont;
            this.examLectureNameLabel.Font = labelFont;
            this.examLectureNameComboBox.Font = labelFont;
            this.examPercentLabel.Font = labelFont;
            this.examPercentLabel2.Font = labelFont;
            this.examPercentTextBox.Font = textBoxFont;
            this.examPeriodLabel.Font = labelFont;
            this.startDateTimePicker.Font = textBoxFont;
            this.endDateTimePicker.Font = textBoxFont;
            this.startDateTimeLabel.Font = textBoxFont;
            this.endDateTimeLabel.Font = textBoxFont;
            this.examTimeLabel.Font = labelFont;
            this.examTimeLabel2.Font = labelFont;
            this.examTimeTextBox.Font = textBoxFont;
            this.saveButton.Font = labelFont;
            this.cancelButton.Font = labelFont;
            this.pageLeftButton.Font = labelFont;
            this.pageRightButton.Font = labelFont;
            this.nowPageTextBox.Font = textBoxFont;
            this.pageSlashLabel.Font = labelFont;
            this.wholePageLabel.Font = textBoxFont;
            this.addQuestionButton.Font = textBoxFont;
            this.removeQuestionButton.Font = textBoxFont;

            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;

            this.examLectureNameComboBox.Items.AddRange(lectureItems);
            this.examLectureNameComboBox.SelectedIndex = 0;

            
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
