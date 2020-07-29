using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace program.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;

        }

        private void imagePanel_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Image img = Image.FromFile("../../src/Assets/Images/Login.jpg");
            //g.DrawImage(img, 0, 0);
        }

        // 나가기 버튼
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 최소화 버튼
        private void minimizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Email TextBox placeholder
        private void emailTextBox_Enter_1(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "example@sejong.ac.kr")
            {
                emailTextBox.Text = "";
            }
        }

        private void emailTextBox_Leave_1(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "example@sejong.ac.kr";
            }
        }

        // Password TextBox placeholder
        private void passwordTextBox_Enter_1(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "**********")
            {
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_Leave_1(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "**********";
            }
        }

        // 로그인 버튼 클릭
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (email == "example@sejong.ac.kr" || !email.Contains("@") || password == "**********")
            {
                MessageBox.Show("이메일과 비밀번호를 정확히 입력하세요.");
            }
            MessageBox.Show(email + password);

            // 서버와 연동 
        }

        // 회원가입 버튼 클릭
        private void registerButton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("회원가입 창!");

            // 로그인 패널 가리고 회원가입 패널 보여줌
            loginPanel.Visible = false;
            signupPanel.Visible = true;
            
        }

        // 로그인 뷰 로드
        private void LoginView_Load_1(object sender, EventArgs e)
        {
            emailTextBox.Text = "example@sejong.ac.kr";
            passwordTextBox.Text = "**********";
            loginButton.Focus();

            //Image panel backgroundimage setting
            string backgroundImageRoute = "../../src/Assets/Images/Login.jpg";
            System.IO.FileInfo backgroundImage = new System.IO.FileInfo(backgroundImageRoute);
            if (backgroundImage.Exists)
            {
                imagePanel.BackgroundImage = Bitmap.FromFile(backgroundImageRoute);
                imagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("LoginView 배경 이미지가 존재하지 않습니다.");
            }

            // Font setting
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            Font labelFont = new Font(privateFont.Families[1], 14f);
            Font textBoxFont = new Font(privateFont.Families[1], 10f);
            Font copyrightFont = new Font(privateFont.Families[2], 8f);

            exitButton.Font = labelFont;
            minimizeButton.Font = labelFont;
            emailLabel.Font = labelFont;
            emailTextBox.Font = textBoxFont;
            passwordLabel.Font = labelFont;
            passwordTextBox.Font = textBoxFont;
            loginButton.Font = labelFont;
            registerButton.Font = labelFont;
            copyrightLabel.Font = copyrightFont;

            signupNameLabel.Font = labelFont;
            signupEmailLabel.Font = labelFont;
            signupPasswordLabel.Font = labelFont;
            signupPasswordCheckLabel.Font = labelFont;
            signupEmailAuthLabel.Font = labelFont;
            signupBirthLabel.Font = labelFont;
            signupPositionLabel.Font = labelFont;


        }

        private void signupCancelButton_Click(object sender, EventArgs e)
        {
            // 회원가입 패널 가리고 로그인 패널 보여줌
            loginPanel.Visible = true;
            signupPanel.Visible = false;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("회원가입 이벤트!");
        }
    }
}
