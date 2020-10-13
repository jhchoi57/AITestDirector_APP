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
    public partial class ProfessorDetailScoreView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        public ProfessorDetailScoreView(MainController mainController)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }

        private void ProfessorDetailScoreView_Load(object sender, EventArgs e)
        {


            // ProfessorScoreCheckView에서 강의, 시험 정보 받아서 텍스트 바꿔줘야 함

            // example
            
            // 강의명
            lectureText.Text = "운영체제";

            // 시험명
            testNameText.Text = "중간고사";

            // 시험 날짜
            testDayText.Text = "2020/4/27 16:00~17:30";

            // 총 점수
            totalScoreText.Text = "100";

            // 평균 점수
            avgScoreText.Text = "78";




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

            // 강의명
            lectureLbl.Font = customFonts.SubTitleFont();
            lectureText.Font = customFonts.SubTitleFont();

            // 시험명
            testNameLbl.Font = customFonts.SubTitleFont();
            testNameText.Font = customFonts.SubTitleFont();

            // 시험 날짜
            testDayLbl.Font = customFonts.SubTitleFont();
            testDayText.Font = customFonts.SubTitleFont();

            // 총 점수
            totalScoreLbl.Font = customFonts.SubTitleFont();
            totalScoreText.Font = customFonts.SubTitleFont();

            // 평균 점수
            avgScoreLbl.Font = customFonts.SubTitleFont();
            avgScoreText.Font = customFonts.SubTitleFont();

            // PictureBox Setting
            scorePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scorePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/score.png");


            // 테이블 Sample 값 추가

            // 강의명, 시험명, 시험 날짜, 총 점수, 평균 점수 받아야됨

            // 학생명 학생점수 채점 여부 표시
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("최모씨", "56", "X");
            lectureTable.Rows.Add("이모씨", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("최모씨", "56", "X");
            lectureTable.Rows.Add("이모씨", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("최모씨", "56", "X");
            lectureTable.Rows.Add("이모씨", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("최모씨", "56", "X");
            lectureTable.Rows.Add("이모씨", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");
            lectureTable.Rows.Add("최모씨", "56", "X");
            lectureTable.Rows.Add("이모씨", "78", "O");
            lectureTable.Rows.Add("김모씨", "78", "X");
            lectureTable.Rows.Add("홍길동", "78", "O");

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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
