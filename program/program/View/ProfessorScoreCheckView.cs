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
using program.View.Components;

namespace program.View
{
    public partial class ProfessorScoreCheckView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        public ProfessorScoreCheckView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }

        private void ProfessorScoreCheckView_Load(object sender, EventArgs e)
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
            scorePictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/score.png");


            // 테이블 Sample 값 추가

            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "퀴즈1", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "퀴즈5", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "퀴즈3", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "퀴즈4", "2020/4/27 16:00~17:30", "80", "65", "30%");
            lectureTable.Rows.Add("운영체제", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("운영체제", "퀴즈1", "2020/4/27 16:00~17:30", "90", "65", "30%");
            lectureTable.Rows.Add("데이터베이스", "기말고사", "2020/6/29 13:00~14:30", "100", "67", "35%");
            lectureTable.Rows.Add("Unix프로그래밍", "중간고사", "2020/4/25 16:00~17:30", "100", "65", "30%");
            lectureTable.Rows.Add("컴퓨터구조", "중간고사", "2020/4/27 16:00~17:30", "100", "65", "30%");

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lectureTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            String lectureName, testName , testDay, totalScore, avgScore;

            // 강의명
            lectureName = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();

            // 시험명
            testName = lectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();

            // 시험 날짜
            testDay = lectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();

            // 총 점수
            totalScore = lectureTable.Rows[e.RowIndex].Cells[3].Value.ToString();

            // 평균 점수
            avgScore = lectureTable.Rows[e.RowIndex].Cells[4].Value.ToString();

            MessageBox.Show("강의명 : " + lectureName + "\n" +
                "시험명 : " + testName + "\n" +
                "시험 날짜 " + testDay + "\n" +
                "총 점수 : " + totalScore + "\n" +
                "평균 점수 : " + avgScore + "\n"
                );

            ProfessorDetailScoreView professorDetailScoreView = new ProfessorDetailScoreView(mainController);
            professorDetailScoreView.SetScoreData(lectureName, testName, testDay, totalScore, avgScore);
            mainController.moveToNextForm(professorDetailScoreView);
        }
    }
}
