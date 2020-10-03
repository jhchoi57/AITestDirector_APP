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
    public partial class ProfessorLectureEditView : Form
    {
        private MainController mainController;
        public ProfessorLectureEditView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }   

        private void ProfessorLectureEditView_Load(object sender, EventArgs e)
        {
            // 이미지
            lecturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lecturePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/lecture.png");

            // Sample
            myLectureTable.Rows.Add("데이터베이스", "신동일", "월수14:00-15:00");
            myLectureTable.Rows.Add("Unix프로그래밍", "노재춘", "월수14:00-15:00");
            myLectureTable.Rows.Add("웹프로그래밍", "김영복", "월수14:00-15:00");
            myLectureTable.Rows.Add("운영체제", "안용학", "월수14:00-15:00 수18:00-20:00");

            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            myLectureExitBtn.Font = customFonts.LabelFont();
            myLectureLbl.Font = customFonts.LabelFont();
            myLectureTable.Font = customFonts.TextBoxFont();

            lectureNameLbl.Font = customFonts.LabelFont();
            lectureNameTextBox.Font = customFonts.TextBoxFont();
            professorLbl.Font = customFonts.LabelFont();
            professorTxtBox.Font = customFonts.TextBoxFont();
            lectureTimeLbl.Font = customFonts.LabelFont();
            lectureTimeTextBox.Font = customFonts.TextBoxFont();
            lectureTotalStuentLbl.Font = customFonts.LabelFont();
            lectureTotalStudentTextBox.Font = customFonts.TextBoxFont();
            lectureSemesterLbl.Font = customFonts.LabelFont();
            lectureSemesterTextBox.Font = customFonts.TextBoxFont();
            assistantLbl.Font = customFonts.LabelFont();
            assistantTextBox.Font = customFonts.TextBoxFont();


        }

        private void myLectureExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myLectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            professorTxtBox.Text = myLectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            lectureTimeTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (!myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = "▶" + myLectureTable.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void myLectureTable_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
        }
    }
}
