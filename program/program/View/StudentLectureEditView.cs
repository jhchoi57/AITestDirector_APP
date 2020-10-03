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
    public partial class StudentLectureEditView : Form
    {
        private MainController mainController;
        public StudentLectureEditView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
        }

        private void minimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void exitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        private void myLectureMinimizeBtn_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void myLectureExitBtn_Click(object sender, EventArgs e) { Application.Exit(); }

        private void StudentLectureEditView_Load(object sender, EventArgs e)
        {
            // 테이블 행 추가

            lectureTable.Rows.Add(false, "운영체제", "안용학", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "데이터베이스", "신동일", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "Unix프로그래밍", "노재춘", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "웹프로그래밍", "김영복", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "디지털시스템", "송상훈", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "기계학습", "유성준", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "알고리즘", "국형준", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "운영체제2", "안용학", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "데이터베이스2", "신동일", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "Unix프로그래밍2", "노재춘", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "웹프로그래밍2", "김영복", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "디지털시스템2", "송상훈", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "기계학습2", "유성준", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "알고리즘2", "국형준", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "운영체제3", "안용학", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "데이터베이스3", "신동일", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "Unix프로그래밍3", "노재춘", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "웹프로그래밍3", "김영복", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "디지털시스템3", "송상훈", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "기계학습3", "유성준", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "알고리즘3", "국형준", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "운영체제4", "안용학", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "데이터베이스4", "신동일", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "Unix프로그래밍4", "노재춘", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "웹프로그래밍4", "김영복", "2020-08-10", "14:00 - 15:00", "일단틀만");
            lectureTable.Rows.Add(false, "디지털시스템4", "송상훈", "2020-08-08", "14:00 - 15:00", "아몰랑");
            lectureTable.Rows.Add(false, "기계학습4", "유성준", "2020-08-09", "14:00 - 15:00", "뭐넣지");
            lectureTable.Rows.Add(false, "알고리즘4", "국형준", "2020-08-10", "14:00 - 15:00", "일단틀만");

            myLectureTable.Rows.Add(false, "데이터베이스", "신동일", "뭐넣징");
            myLectureTable.Rows.Add(false, "Unix프로그래밍", "노재춘", "나중에");
            myLectureTable.Rows.Add(false, "웹프로그래밍", "김영복", "정해지면");
            myLectureTable.Rows.Add(false, "운영체제", "안용학", "넣어야징");

            // 이미지
            homePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            homePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/home.png");
            lecturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lecturePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/lecture.png");

            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            minimizeButton.Font = customFonts.LabelFont();
            exitButton.Font = customFonts.LabelFont();
            myLectureExitBtn.Font = customFonts.LabelFont();

            professorNameLbl.Font = customFonts.LabelFont();
            lectureNameLbl.Font = customFonts.LabelFont();

            myLectureLbl.Font = customFonts.SubTitleFont();

            lectureNameTxtBox.Font = customFonts.TextBoxFont();
            professorNameTxtBox.Font = customFonts.TextBoxFont();
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void lectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            if(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("False"))
                lectureTable.Rows[e.RowIndex].Cells[0].Value = true;
            else
                lectureTable.Rows[e.RowIndex].Cells[0].Value = false;
        }

        private void myLectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("False"))
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = true;
            else
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = false;
        }

        private void addLectureBtn_Click(object sender, EventArgs e)
        {
            string testMsg = "";

            int count = 0;

            for(int i = 0; i < lectureTable.Rows.Count; i++)
            {
                // 체크박스가 체크되어 있다면
                if (lectureTable.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    testMsg = testMsg + lectureTable.Rows[i].Cells[1].Value.ToString() + "\n";
                    count++;
                }
            }

            if (count == 0) MessageBox.Show("강의를 선택해주세요!");
            else MessageBox.Show(testMsg);
            
        }

        private void deleteLectureBtn_Click(object sender, EventArgs e)
        {
            string testMsg = "";

            int count = 0;

            for (int i = 0; i < myLectureTable.Rows.Count; i++)
            {
                // 체크박스가 체크되어 있다면
                if (myLectureTable.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    testMsg = testMsg + myLectureTable.Rows[i].Cells[1].Value.ToString() + "\n";
                    count++;
                }
            }

            if (count == 0) MessageBox.Show("강의를 선택해주세요!");
            else MessageBox.Show(testMsg);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (professorNameTxtBox.Text.Equals("") && lectureNameTxtBox.Text.Equals(""))
            {
                MessageBox.Show("교수명 또는 강의명을 입력해주세요!!");
            }
            else
            {
                MessageBox.Show("검색 이벤트!");
            }
        }

        private void professorNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("검색 이벤트!");
            }
        }

        private void lectureNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("검색 이벤트!");
            }
        }
    }
}
