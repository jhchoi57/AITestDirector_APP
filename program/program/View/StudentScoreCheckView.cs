using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program.Controller;
using program.Model.Exams;
using program.View.Components;

namespace program.View
{
    public partial class StudentScoreCheckView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        public StudentScoreCheckView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentScoreCheckView_Load(object sender, EventArgs e)
        {
            

            // Font setting
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            lectureTable.Font = customFonts.NormalFont();
            scoreCheckLabel.Font = customFonts.TitleFont();

            // PictureBox Setting
            scorePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scorePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/score.png");


            // 테이블 Sample 값 추가

            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "퀴즈1", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "퀴즈5", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "퀴즈3", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "퀴즈4", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "퀴즈1", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "56 / 100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "78 / 100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "78 / 100", "65", "30%");

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

        }

        private void minimizeBtn_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void exitBtn_Click(object sender, EventArgs e) { Application.Exit(); }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }
    }
}
