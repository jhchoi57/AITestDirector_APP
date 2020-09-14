using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program.View.Components;

namespace program.View
{
    public partial class ProfessorScoreCheckView : Form
    {
        public ProfessorScoreCheckView()
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ProfessorScoreCheckView_Load(object sender, EventArgs e)
        {
            // ComboBox setting
            semesterComboBox.Items.Clear();

            semesterComboBox.Items.Add("2017-1학기");
            semesterComboBox.Items.Add("2017-2학기");
            semesterComboBox.Items.Add("2018-1학기");
            semesterComboBox.Items.Add("2018-2학기");
            semesterComboBox.Items.Add("2019-1학기");
            semesterComboBox.Items.Add("2019-2학기");
            semesterComboBox.Items.Add("2020-1학기");
            semesterComboBox.Items.Add("2020-2학기");

            semesterComboBox.SelectedText = "-- 년도/학기 선택 --";

            // Font setting
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            semesterComboBox.Font = customFonts.LabelFont();
            lectureTable.Font = customFonts.NormalFont();
            exitBtn.Font = customFonts.LabelFont();
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

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
