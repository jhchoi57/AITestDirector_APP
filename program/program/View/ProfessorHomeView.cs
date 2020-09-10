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
    public partial class ProfessorHomeView : Form
    {
        public ProfessorHomeView()
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
        }

        private void ProfessorHomeView_Load(object sender, EventArgs e)
        {
            // 테이블 행 높이 설정
            lectureTable.RowTemplate.Height = 35;

            // 테이블 행 추가
            // Sample
            lectureTable.Rows.Add("운영체제1", "안용학1", "2020-08-08", "14:00 - 15:00", "중간고사");
            lectureTable.Rows.Add("운영체제2", "안용학2", "2020-08-09", "14:00 - 15:00", "기말고사");
            lectureTable.Rows.Add("운영체제3", "안용학3", "2020-08-10", "14:00 - 15:00", "퀴즈1");

            // 이미지
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/user.png");

            // SampleText
            univLabel.Text = "세종대학교";
            nameLabel.Text = "홍길동 교수님";
            emailLabel.Text = "exam@naver.com";

            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            lectureTable.Font = customFonts.NormalFont();

            exitButton.Font = customFonts.LabelFont();
            minimizeButton.Font = customFonts.LabelFont();
            editExitButton.Font = customFonts.LabelFont();
            editMinimizeButton.Font = customFonts.LabelFont();


            univLabel.Font = customFonts.LabelFont();
            nameLabel.Font = customFonts.LabelFont();
            emailLabel.Font = customFonts.LabelFont();

            editBirthLabel.Font = customFonts.LabelFont();
            editEmailLabel.Font = customFonts.LabelFont();
            editNameLabel.Font = customFonts.LabelFont();
            editPasswordCheckLabel.Font = customFonts.LabelFont();
            editPasswordLabel.Font = customFonts.LabelFont();
            editUnivLabel.Font = customFonts.LabelFont();

            editUnivTextBox.Font = customFonts.TextBoxFont();
            editNameTextBox.Font = customFonts.TextBoxFont();
            editEmailTextBox.Font = customFonts.TextBoxFont();
            editPasswordTextBox.Font = customFonts.TextBoxFont();
            editPasswordCheckTextBox.Font = customFonts.TextBoxFont();
            editBirthPicker.Font = customFonts.TextBoxFont();
        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            // 마이페이지 가리고 정보수정 패널 보여줌
            myPagePanel.Visible = false;
            editPanel.Visible = true;

            // 초기화
            // example
            editUnivTextBox.Text = "세종대학교";
            editNameTextBox.Text = "홍길동";
            editEmailTextBox.Text = "example@sju.co.kr";
            editBirthPicker.Value = new DateTime(1998, 11, 25);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보수정 이벤트!");
        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            // 정보수정 패널 가리고 마이페이지 패널 보여줌
            myPagePanel.Visible = true;
            editPanel.Visible = false;
        }

        private void lectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            { // 버튼 컬럼 위치
                MessageBox.Show(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n"
                    + lectureTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "\n"
                    + lectureTable.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
            }
        }

        private void editMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void editExitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        private void minimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void exitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        private void checkScoreBtn_Click(object sender, EventArgs e)
        {
            ProfessorScoreCheckView ProfessorScoreCheckView = new ProfessorScoreCheckView();
            ProfessorScoreCheckView.Show();
        }
    }
}
