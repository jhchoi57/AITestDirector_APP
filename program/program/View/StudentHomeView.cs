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

        private void signupMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signupExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentHomeView_Load(object sender, EventArgs e)
        {
            // 테이블 행 추가
            // Sample
            lectureTable.Rows.Add("운영체제", "안용학", "2020-08-08", "14:00 - 15:00", "중간고사");
            lectureTable.Rows.Add("운영체제", "안용학", "2020-08-08", "14:00 - 15:00", "중간고사");
            lectureTable.Rows.Add("운영체제", "안용학", "2020-08-08", "14:00 - 15:00", "중간고사");

            univLabel.Text = "세종대학교";
            stuNumLabel.Text = "123456";
            nameLabel.Text = "홍길동";
            emailLabel.Text = "exam@naver.com";


            // 이미지
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/user.png");

            // 폰트
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            Font Font = new Font(privateFont.Families[1], 10f);
            Font LabelFont = new Font(privateFont.Families[1], 14f);
            Font copyrightFont = new Font(privateFont.Families[2], 8f);

            lectureTable.Font = Font;
            univLabel.Font = LabelFont;
            stuNumLabel.Font = LabelFont;
            nameLabel.Font = LabelFont;
            emailLabel.Font = LabelFont;
            signupExitButton.Font = Font;
            signupMinimizeButton.Font = Font;

        }
    }
}
