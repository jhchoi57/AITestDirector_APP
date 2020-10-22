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
using program.View.Components;
using program.Controller;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace program.View
{
    public partial class StudentHomeView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private string selectedID;
        public StudentHomeView(MainController mainController)
        {
            InitializeComponent();
                  // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
            Console.WriteLine("호출 되나요?");
        }

        private void signupMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void signupExitButton_Click(object sender, EventArgs e) { Application.Exit(); }
        private void editMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void editExitButton_Click(object sender, EventArgs e) { Application.Exit(); }
        private void testInfoMinimizeBtn_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void testInfoExitBtn_Click(object sender, EventArgs e) { Application.Exit(); }


        private void StudentHomeView_Load(object sender, EventArgs e)
        {
            CustomFonts customFonts = new CustomFonts();

            lectureTable.ColumnCount = 6;
            lectureTable.Columns[5].Name = "id";
            lectureTable.Columns[5].Visible = false;
            // 테이블 행 높이 설정
            lectureTable.RowTemplate.Height = 35;

            // 테이블 행 추가
            // Sample
            
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
            
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            lectureTable.Font = customFonts.NormalFont();

            //testInfoMinimizeBtn.Font = customFonts.LabelFont();
            //testInfoExitBtn.Font = customFonts.LabelFont();

            univLabel.Font = customFonts.LabelFont();
            stuNumLabel.Font = customFonts.LabelFont();
            nameLabel.Font = customFonts.LabelFont();
            emailLabel.Font = customFonts.LabelFont();

            editBirthLabel.Font = customFonts.LabelFont();
            editEmailLabel.Font = customFonts.LabelFont();
            editNameLabel.Font = customFonts.LabelFont();
            editPasswordCheckLabel.Font = customFonts.LabelFont();
            editPasswordLabel.Font = customFonts.LabelFont();
            editStdNumLabel.Font = customFonts.LabelFont();
            editUnivLabel.Font = customFonts.LabelFont();

            editUnivTextBox.Font = customFonts.TextBoxFont();
            editStdNumTextBox.Font = customFonts.TextBoxFont();
            editNameTextBox.Font = customFonts.TextBoxFont();
            editEmailTextBox.Font = customFonts.TextBoxFont();
            editPasswordTextBox.Font = customFonts.TextBoxFont();
            editPasswordCheckTextBox.Font = customFonts.TextBoxFont();
            editBirthPicker.Font = customFonts.TextBoxFont();

            testInfoLectureLbl.Font = customFonts.TitleFont();
            testInfoTestNameLbl.Font = customFonts.SubTitleFont();
            testInfoProfNameLbl.Font = customFonts.LabelFont();
            testInfoDayLbl.Font = customFonts.LabelFont();
            testInfoTimeLbl.Font = customFonts.LabelFont();

            cameraLabel.Font = customFonts.LabelFont();

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            editButton.Click += editButton_Click;
            setUserInfo();
            setUserExam();
            selectedID = "";
        }

        private void setUserInfo()
        {
            try
            {
                string response = mainController.getStudentInfoRequest();
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                string birth = (string)jObject["birth_day"];
                string school = (string)jObject["institute"];
                string email = (string)jObject["email"];
                Boolean profileImage = (Boolean)jObject["profile_image"];
                int year = int.Parse(birth.Substring(0, 4));
                int month = int.Parse(birth.Substring(5, 2));
                int day = int.Parse(birth.Substring(8));
                editStdNumTextBox.Text = mainController.Me.ID;
                editUnivTextBox.Text = school;
                editNameTextBox.Text = mainController.Me.Name;
                editEmailTextBox.Text = email;
                editBirthPicker.Value = new DateTime(year, month, day);
                univLabel.Text = school;
                stuNumLabel.Text = mainController.Me.ID;
                nameLabel.Text = mainController.Me.Name;
                emailLabel.Text = email;
                if (profileImage)
                {
                    pictureBox.Load("https://test.inchang.dev:9000/account/student/" + mainController.Me.ID + "/profile-image");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setUserExam()
        {
            try
            {
                string response = mainController.getAllExamReqeust();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                int cnt = jArray.Count;
                for (int i = 0; i < cnt; i++)
                {
                    JObject jObject = (JObject)jArray[i];
                    string id = (string)jObject["uuid"];
                    string examName = (string)jObject["exam_name"];
                    string startTime = (string)jObject["start_at"];
                    string endTime = (string)jObject["finish_at"];
                    string professor = (string)jObject["professor_name"];
                    string lectureName = (string)jObject["lecture_name"];
                    string date = startTime.Substring(0, 10);
                    string time = startTime.Substring(11, 5) + " - " + endTime.Substring(11, 5);

                    lectureTable.Rows.Add(lectureName, professor, date, time, examName, id);

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            // 마이페이지 가리고 정보수정 패널 보여줌
            myPagePanel.Visible = false;
            editPanel.Visible = true;
            editPasswordTextBox.Text = "";
            editPasswordCheckTextBox.Text = "";

        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (editNameTextBox.Text == "" || editPasswordTextBox.Text == "")
            {
                MessageBox.Show("빈 칸 없이 모든 정보를 입력해주세요.", "개인 정보 수정 오류");
                return;
            }
            else if (editPasswordTextBox.Text != editPasswordCheckTextBox.Text)
            {
                MessageBox.Show("비밀번호를 동일하게 입력해주세요.", "개인 정보 수정 오류");
                return;
            }
            MessageBox.Show("정보수정 이벤트!");
            try
            {
                string name = editNameTextBox.Text;
                string email = editEmailTextBox.Text;
                string birth = editBirthPicker.Value.ToString("yyyy-MM-dd");
                string school = editUnivTextBox.Text;
                string password = editPasswordCheckTextBox.Text;
                string response = mainController.modifyStudentInfoRequest(name, email, birth, school, password);
                mainController.Me.Name = name;

                setUserInfo();
                myPagePanel.Visible = true;
                editPanel.Visible = false;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
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
            if (lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                lectureTable.Rows[e.RowIndex].Cells[0].Value = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
            }
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
                selectedID = lectureTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void testStartBtn_Click(object sender, EventArgs e)
        {
            // 연동 화면 열기
            /*
            cameraPanel.Visible = true;
            testPanel.Enabled = false;
            testInfoPanel.Enabled = false;
            */
            if (selectedID == "")
            {
                MessageBox.Show("시험을 선택해주세요.", "시험 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExamView examView = new ExamView(mainController, selectedID, mainController.Me.Token, true);
            mainController.moveToNextForm(examView);
        }

        private void cameraCancelBtn_Click(object sender, EventArgs e)
        {
            // 연동 화면 닫기
            cameraPanel.Visible = false;
            testPanel.Enabled = true;
            testInfoPanel.Enabled = true;
        }

        private void editLectureBtn_Click(object sender, EventArgs e)
        {
            StudentLectureEditView studentLectureEditView = new StudentLectureEditView(mainController);
            mainController.moveToNextForm(studentLectureEditView);
        }

        private void checkScoreBtn_Click(object sender, EventArgs e)
        {
            StudentScoreCheckView studentScoreCheckView = new StudentScoreCheckView(mainController);
            mainController.moveToNextForm(studentScoreCheckView);
        }

        private void imageEditBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지 수정 이벤트 !");
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "jpg";
            openFile.Multiselect = false;
            openFile.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                Console.WriteLine(openFile);
                string response = mainController.modifyStudentImageRequest(openFile.FileName);
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                string code = (string)jObject["code"];
                if (code.Equals("OK"))
                {
                    pictureBox.Load("https://test.inchang.dev:9000/account/student/" + mainController.Me.ID + "/profile-image");
                }
                else
                {
                    MessageBox.Show("이미지 등록에 실패했습니다.\n 다시 시도해 주세요.", "이미지 등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
