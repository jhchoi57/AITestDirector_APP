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
        private TopBarPanel topBarPanel;
        private Color selectedColor = Color.FromArgb(51, 71, 97);
        private Color notSelectedColor = Color.Gray;

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
            myLectureTable.Rows.Add("데이터베이스", "월수14:00-15:00", "40", "2019-1학기");
            myLectureTable.Rows.Add("Unix프로그래밍", "월수14:00-15:00", "60", "2018-2학기");
            myLectureTable.Rows.Add("웹프로그래밍", "월수14:00-15:00", "50", "2020-여름학기");
            myLectureTable.Rows.Add("운영체제", "월수14:00-15:00 수18:00-20:00", "40", "2015-겨울학기");

            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            myLectureLbl.Font = customFonts.LabelFont();
            myLectureTable.Font = customFonts.TextBoxFont();

            lectureNameLbl.Font = customFonts.LabelFont();
            lectureNameTextBox.Font = customFonts.TextBoxFont();
            lectureTimeLbl.Font = customFonts.LabelFont();
            lectureTimeTextBox.Font = customFonts.TextBoxFont();
            lectureTotalStuentLbl.Font = customFonts.LabelFont();
            lectureTotalStudentTextBox.Font = customFonts.TextBoxFont();
            lectureSemesterLbl.Font = customFonts.LabelFont();
            lectureSemesterTextBox.Font = customFonts.TextBoxFont();
            backButton.Font = customFonts.SubTitleFont();
            confirmBtn.Font = customFonts.TextBoxFont();
            addLectureBtn.Font = customFonts.TextBoxFont();
            deleteBtn.Font = customFonts.TextBoxFont();
            editBtn.Font = customFonts.TextBoxFont();
            infoLbl.Font = customFonts.NormalFont();

            label1.Font = customFonts.SmallFont();
            label2.Font = customFonts.SmallFont();
            
            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);


        }

        private void myLectureExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myLectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            lectureTimeTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            lectureTotalStudentTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            lectureSemesterTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[3].Value.ToString();

            // 첫 글자에 화살표 없을때
            if (!myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = "▶" + myLectureTable.Rows[e.RowIndex].Cells[0].Value;
            }
            // 첫 글자에 화살표 있을때
            else
            {
                lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("▶","");
            }

            // 버튼 초기화
            addLectureBtn.BackColor = notSelectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = notSelectedColor;
            confirmBtn.Visible = false;

            // 

            // 읽기 전용 모드
            lectureNameTextBox.ReadOnly = true;
            lectureTimeTextBox.ReadOnly = true;
            lectureTotalStudentTextBox.ReadOnly = true;
            lectureSemesterTextBox.ReadOnly = true;
        }

        private void myLectureTable_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
        }

        private void addLectureBtn_Click(object sender, EventArgs e)
        {
            // 강의 추가 이벤트

            // 텍스트박스 초기화
            lectureNameTextBox.Text = null;
            lectureTimeTextBox.Text = null;
            lectureTotalStudentTextBox.Text = null;
            lectureSemesterTextBox.Text = null;
            lectureNameTextBox.ReadOnly = false;
            lectureTimeTextBox.ReadOnly = false;
            lectureTotalStudentTextBox.ReadOnly = false;
            lectureSemesterTextBox.ReadOnly = false;

            // 다른 버튼 회색으로 변경, 강의 추가 버튼만 진하게
            addLectureBtn.BackColor = selectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = notSelectedColor;

            // 확인 버튼
            confirmBtn.Visible = true;
            confirmBtn.Text = "추가 확인";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // 강의 수정 이벤트

            // 강의 선택 여부 확인
            if(lectureNameTextBox.ReadOnly == false)
            {
                MessageBox.Show("수정할 강의를 선택해주세요!!!");
                return;
            }

            // 읽기 전용 풀고
            // key 값은 풀면 안될듯? 일단 강의명만
            //lectureNameTextBox.ReadOnly = false;
            lectureTimeTextBox.ReadOnly = false;
            lectureTotalStudentTextBox.ReadOnly = false;
            lectureSemesterTextBox.ReadOnly = false;

            // 다른 버튼 회색으로 변경, 강의 수정 버튼만 진하게
            addLectureBtn.BackColor = notSelectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = selectedColor;

            // 확인 버튼
            confirmBtn.Visible = true;
            confirmBtn.Text = "수정 확인";

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 강의 삭제 이벤트

            // 표에서 강의 선택해서 전부 READONLY 일때(확실할때만) 삭제
            if(lectureNameTextBox.ReadOnly &&
            lectureTimeTextBox.ReadOnly &&
            lectureTotalStudentTextBox.ReadOnly &&
            lectureSemesterTextBox.ReadOnly)
            {
                // 다른 버튼 회색으로 변경, 강의 삭제 버튼만 진하게
                addLectureBtn.BackColor = notSelectedColor;
                deleteBtn.BackColor = selectedColor;
                editBtn.BackColor = notSelectedColor;

                // 확인 버튼
                confirmBtn.Visible = true;
                confirmBtn.Text = "삭제 확인";
            }
            // 하나라도 READONLY가 아닐 경우
            else
            {
                MessageBox.Show("표에서 강의를 다시 선택해주세요!!!");
            }
            
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // 확인 버튼 처리

            // 강의 추가 이벤트일 경우
            if(addLectureBtn.BackColor == selectedColor)
            {
                // 입력햇는지 입벌려 확인 들어갑니다
                // 강의명 입력 확인
                if (lectureNameTextBox.Text == null) MessageBox.Show("강의명을 입력해주세요!!!");
                // 강의 시간 입력 확인
                if (lectureTimeTextBox.Text == null) MessageBox.Show("강의 시간을 입력해주세요!!!");
                // 수강 학생 인원 입력 확인
                if (lectureTotalStudentTextBox.Text == null) MessageBox.Show("수강 학생 인원을 입력해주세요!!!");
                // 강의년도-학기 입력 확인
                if (lectureSemesterTextBox.Text == null) MessageBox.Show("강의년도-학기를 입력해주세요!!!");

                MessageBox.Show("강의 추가 이벤트!!!");
            }

            // 강의 수정 이벤트일 경우
            else if (editBtn.BackColor == selectedColor)
            {
                MessageBox.Show("강의 수정 이벤트!!!");
            }

            // 강의 삭제 이벤트일 경우
            else if (deleteBtn.BackColor == selectedColor)
            {
                MessageBox.Show("강의 삭제 이벤트!!!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }
    }
}
