using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace program.View
{
    public partial class StudentHomeView : Form
    {
        public StudentHomeView()
        {
            InitializeComponent();
                  // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
                  // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
        }

        private void signupMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void signupExitButton_Click(object sender, EventArgs e) { Application.Exit(); }
        private void editMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void editExitButton_Click(object sender, EventArgs e) { Application.Exit(); }
        private void testInfoMinimizeBtn_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void testInfoExitBtn_Click(object sender, EventArgs e) { Application.Exit(); }


        private void StudentHomeView_Load(object sender, EventArgs e)
        {
            // 테이블 행 높이 설정
            lectureTable.RowTemplate.Height = 35;

            // 테이블 행 추가
            // Sample
            lectureTable.Rows.Add("운영체제1", "안용학1", "2020-08-08", "14:00 - 15:00", "중간고사");
            lectureTable.Rows.Add("운영체제2", "안용학2", "2020-08-09", "14:00 - 15:00", "기말고사");
            lectureTable.Rows.Add("운영체제3", "안용학3", "2020-08-10", "14:00 - 15:00", "퀴즈1");

            univLabel.Text = "세종대학교";
            stuNumLabel.Text = "123456";
            nameLabel.Text = "홍길동";
            emailLabel.Text = "exam@naver.com";


            // 이미지
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/user.png");
            cameraPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cameraPictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/LinkImage.png");

            // 폰트
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            Font Font = new Font(privateFont.Families[1], 10f);
            Font LabelFont = new Font(privateFont.Families[1], 14f);
            Font TextBoxFont = new Font(privateFont.Families[1], 12f);
            Font copyrightFont = new Font(privateFont.Families[2], 8f);

            lectureTable.Font = Font;

            exitButton.Font = LabelFont;
            minimizeButton.Font = LabelFont;
            editExitButton.Font = LabelFont;
            editMinimizeButton.Font = LabelFont;
            testInfoMinimizeBtn.Font = LabelFont;
            testInfoExitBtn.Font = LabelFont;


            univLabel.Font = LabelFont;
            stuNumLabel.Font = LabelFont;
            nameLabel.Font = LabelFont;
            emailLabel.Font = LabelFont;

            editBirthLabel.Font = LabelFont;
            editEmailLabel.Font = LabelFont;
            editNameLabel.Font = LabelFont;
            editPasswordCheckLabel.Font = LabelFont;
            editPasswordLabel.Font = LabelFont;
            editStdNumLabel.Font = LabelFont;
            editUnivLabel.Font = LabelFont;

            editUnivTextBox.Font = TextBoxFont;
            editStdNumTextBox.Font = TextBoxFont;
            editNameTextBox.Font = TextBoxFont;
            editEmailTextBox.Font = TextBoxFont;
            editPasswordTextBox.Font = TextBoxFont;
            editPasswordCheckTextBox.Font = TextBoxFont;
            editBirthPicker.Font = TextBoxFont;

            testInfoLectureLbl.Font = new Font(privateFont.Families[1], 20f);
            testInfoTestNameLbl.Font = new Font(privateFont.Families[1], 17f);
            testInfoProfNameLbl.Font = LabelFont;
            testInfoDayLbl.Font = LabelFont;
            testInfoTimeLbl.Font = LabelFont;

            cameraLabel.Font = LabelFont;

        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            // 마이페이지 가리고 정보수정 패널 보여줌
            myPagePanel.Visible = false;
            editPanel.Visible = true;

            // 초기화
            // example
            editUnivTextBox.Text = "세종대학교";
            editStdNumTextBox.Text = "17011111";
            editNameTextBox.Text = "홍길동";
            editEmailTextBox.Text = "example@sju.co.kr";
            editBirthPicker.Value = new DateTime(1998,11,25);

        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            // 정보수정 패널 가리고 마이페이지 패널 보여줌
            myPagePanel.Visible = true;
            editPanel.Visible = false;
        }

        private void lectureTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void testInfoCancelBtn_Click(object sender, EventArgs e)
        {
            // 시험정보 패널 가리고 마이페이지 보여줌
            testInfoPanel.Visible = false;
            myPagePanel.Visible = true;
        }

        private void lectureTable_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
                lectureTable.Rows[e.RowIndex].Cells[0].Value = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
        }

        private void lectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            // 마이페이지 가리고 시험 정보 패널 보여줌
            testInfoPanel.Visible = true;
            myPagePanel.Visible = false;

            // 초기화            

            testInfoTestNameLbl.Text = lectureTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            testInfoProfNameLbl.Text = lectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            testInfoDayLbl.Text = lectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            testInfoTimeLbl.Text = lectureTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (!lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                testInfoLectureLbl.Text = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lectureTable.Rows[e.RowIndex].Cells[0].Value = "▶" + lectureTable.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void testStartBtn_Click(object sender, EventArgs e)
        {
            // 연동 화면 열기
            cameraPanel.Visible = true;
            testPanel.Enabled = false;
            testInfoPanel.Enabled = false;
        }

        private void cameraCancelBtn_Click(object sender, EventArgs e)
        {
            // 연동 화면 닫기
            cameraPanel.Visible = false;
            testPanel.Enabled = true;
            testInfoPanel.Enabled = true;
        }
    }
}
