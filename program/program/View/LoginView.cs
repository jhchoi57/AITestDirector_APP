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
using program.View.Components;
using program.Controller;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace program.View
{
    public partial class LoginView : Form
    {
        private MainController mainController;
        private CustomFonts customFonts;
        private TopBarPanel topBarPanel;

        public LoginView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
            this.mainController = mainController;
            this.Load += Load_1;
        }

        private void Load_1(object sender, EventArgs e)
        {
            studentRadioBtn.Checked = true;
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

            /*
            if (email == "example@sejong.ac.kr" || !email.Contains("@") || password == "**********")
            {
                MessageBox.Show("이메일과 비밀번호를 정확히 입력하세요.");
                return;
            }
            */
            try
            {
                if (studentRadioBtn.Checked)
                {
                    string response = mainController.studentLoginRequest(email, password);
                    JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                    string result = (string)jObject["code"];
                    string message = (string)jObject["message"];
                    if (result.Equals("ok"))
                    {
                        string name = (string)jObject["name"];
                        string id = ((int)jObject["id"]).ToString();
                        mainController.setUserInfo(name, id, message, true);
                        StudentHomeView studentHomeView = new StudentHomeView(mainController);
                        mainController.moveToNextForm(studentHomeView);
                    }
                    else
                    {
                        MessageBox.Show(message, "로그인 실패");
                    }
                }
                else if (professorRadioBtn.Checked)
                {
                    string response = mainController.professorLoginRequest(email, password);
                    JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                    string result = (string)jObject["code"];
                    string message = (string)jObject["message"];
                    if (result.Equals("ok"))
                    {
                        string name = (string)jObject["name"];
                        string id = (string)jObject["id"];
                        mainController.setUserInfo(name, id, message, false);
                        ProfessorHomeView professorHome = new ProfessorHomeView(mainController);
                        mainController.moveToNextForm(professorHome);
                    }
                    else
                    {
                        MessageBox.Show(message, "로그인 실패");
                    }
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        // 회원가입 버튼 클릭
        private void registerButton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("회원가입 창!");

            // 로그인 패널 가리고 회원가입 패널 보여줌
            loginPanel.Visible = false;
            signupPanel.Visible = true;

            // 회원가입 패널 초기화
            signupUnivTextBox.Text = null;
            signupStdNumTextBox.Text = null;
            signupNameTextBox.Text = null;
            signupEmailTextBox.Text = null;
            signupPasswordTextBox.Text = null;
            signupPasswordCheckTextBox.Text = null;
            signupBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            signupPositionComboBox.Text = null;

        }

        // 로그인 뷰 로드
        private void LoginView_Load_1(object sender, EventArgs e)
        {
            emailTextBox.Text = "example@sejong.ac.kr";
            passwordTextBox.Text = "**********";
            loginButton.Focus();

            // Font setting
            customFonts = new CustomFonts();

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts, true);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            //Image panel backgroundimage setting
            string backgroundImageRoute = "./src/Assets/Images/Login.jpg";
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

            
            emailLabel.Font = customFonts.LabelFont();
            emailTextBox.Font = customFonts.TextBoxFont();
            passwordLabel.Font = customFonts.LabelFont();
            passwordTextBox.Font = customFonts.TextBoxFont();
            loginButton.Font = customFonts.LabelFont();
            registerButton.Font = customFonts.LabelFont();
            copyrightLabel.Font = customFonts.CopyRightFont();

            // 회원가입 패널 폰트 설정

            // 학교
            signupUnivLabel.Font = customFonts.LabelFont();
            signupUnivTextBox.Font = customFonts.TextBoxFont();
            signupUnivButton.Font = customFonts.TextBoxFont();

            // 학번
            signupStdNumLabel.Font = customFonts.LabelFont();
            signupStdNumTextBox.Font = customFonts.TextBoxFont();

            // 이름
            signupNameLabel.Font = customFonts.LabelFont();
            signupNameTextBox.Font = customFonts.TextBoxFont();

            // 이메일
            signupEmailLabel.Font = customFonts.LabelFont();
            signupEmailTextBox.Font = customFonts.TextBoxFont();

            // 비밀번호
            signupPasswordLabel.Font = customFonts.LabelFont();
            signupPasswordTextBox.Font = customFonts.TextBoxFont();

            // 비밀번호 확인
            signupPasswordCheckLabel.Font = customFonts.LabelFont();
            signupPasswordCheckTextBox.Font = customFonts.TextBoxFont();

            // 생년월일
            signupBirthLabel.Font = customFonts.LabelFont();
            signupBirthPicker.Font = customFonts.TextBoxFont();            

            // 구분
            signupPositionLabel.Font = customFonts.LabelFont();
            signupPositionComboBox.Font = customFonts.NormalFont();

            // 버튼
            signupButton.Font = customFonts.TextBoxFont();
            signupCancelButton.Font = customFonts.TextBoxFont();

            // 라디오 버튼
            studentRadioBtn.Font = customFonts.NormalFont();
            professorRadioBtn.Font = customFonts.NormalFont();

            // ComboBox setting
            signupPositionComboBox.Items.Clear();
            signupPositionComboBox.Items.Add("학생");
            signupPositionComboBox.Items.Add("교수");
        }

        private void signupCancelButton_Click(object sender, EventArgs e)
        {
            // 회원가입 패널 가리고 로그인 패널 보여줌
            loginPanel.Visible = true;
            signupPanel.Visible = false;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string univ = signupUnivTextBox.Text;
            string stdNum = signupStdNumTextBox.Text;
            string name = signupNameTextBox.Text;
            string email = signupEmailTextBox.Text;
            string password = signupPasswordTextBox.Text;
            string passwordCheck = signupPasswordCheckTextBox.Text;
            string birth = signupBirthPicker.Value.ToString("yyyy-MM-dd");
            string position = signupPositionComboBox.Text;

            // 학생/교수/조교 선택 확인
            if (position.Length == 0) MessageBox.Show("구분을 선택해주세요.");

            // 학생이면 학번 입력했는지 확인
            else if (position.Equals("학생") && stdNum.Length == 0) MessageBox.Show("학번을 입력해주세요.");
                        
            // 학교 선택 확인
            else if (univ.Length == 0) MessageBox.Show("학교를 선택해주세요.");

            // 이름 입력 확인
            else if (name.Length == 0) MessageBox.Show("이름을 입력해주세요.");

            // 이메일 입력 확인
            else if (email.Length == 0) MessageBox.Show("이메일을 입력해주세요.");

            // 비밀번호 입력 확인
            else if (password.Length == 0) MessageBox.Show("비밀번호를 입력해주세요.");

            // 비밀번호 확인 입력 확인
            else if (passwordCheck.Length == 0) MessageBox.Show("비밀번호 확인을 입력해주세요.");

            // 비밀번호 - 비밀번호 확인 입력이 같은지 확인
            else if (!password.Equals(passwordCheck)) MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");


            else
            {
                string response;
                try
                {
                    if (position.Equals("학생"))
                    {
                        response = mainController.studentSignupRequest(email, password, name, univ, int.Parse(stdNum), birth);
                    }
                    else
                    {
                        response = mainController.professorSignupRequest(email, password, name, univ, birth);
                    }

                    JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                    string message = (string)jObject["message"];

                    MessageBox.Show(message, "회원가입");

                    if (message.Equals("Student SignUp Success") || message.Equals("professor SignUp Success"))
                    {
                        loginPanel.Visible = true;
                        signupPanel.Visible = false;
                    }
                } 
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }

        private void signupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signupUnivButton_Click(object sender, EventArgs e)
        {
            signupUnivTextBox.Text = "세종대학교";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
