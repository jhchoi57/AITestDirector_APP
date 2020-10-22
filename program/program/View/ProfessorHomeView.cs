using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.View.Components;

namespace program.View
{
    public partial class ProfessorHomeView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        public ProfessorHomeView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
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

            testAddBtn.Click += testAddBtn_Click_1;
            editLectureBtn.Click += editLectureBtn_Click_1;

            //mainController.professorAddLectureRequest("운영체제", "월수 16:30 ~ 18:00", 30, "2020-2학기");
            mainController.professorAllLecturesRequest();
            setUserInfo();

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);
        }

        private void setUserInfo()
        {
            try
            {
                string response = mainController.getProfessorInfoRequest();
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                string birth = (string)jObject["birth_day"];
                string school = (string)jObject["institute"];
                int year = int.Parse(birth.Substring(0, 4));
                int month = int.Parse(birth.Substring(5, 2));
                int day = int.Parse(birth.Substring(8));
                editUnivTextBox.Text = school;
                editNameTextBox.Text = mainController.Me.Name;
                editEmailTextBox.Text = mainController.Me.ID;
                editBirthPicker.Value = new DateTime(year, month, day);
                univLabel.Text = school;
                nameLabel.Text = mainController.Me.Name;
                emailLabel.Text = mainController.Me.ID;
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
                string birth = editBirthPicker.Value.ToString("yyyy-MM-dd");
                string school = editUnivTextBox.Text;
                string password = editPasswordCheckTextBox.Text;
                string response = mainController.modifyProfessorInfoRequest(name, birth, school, password);
                mainController.Me.Name = name;

                myPagePanel.Visible = true;
                editPanel.Visible = false;
                setUserInfo();
            }
            catch(Exception error)
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

        private void lectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex>=0)
            { // 버튼 컬럼 위치
                MessageBox.Show("수정  \n" + 
                    lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n"
                    + lectureTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "\n"
                    + lectureTable.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
                MakeExamView makeExamView = new MakeExamView(mainController);
                mainController.moveToNextForm(makeExamView);
            }
            else if(e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                MessageBox.Show("삭제  \n" +
                    lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n"
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
            ProfessorScoreCheckView ProfessorScoreCheckView = new ProfessorScoreCheckView(mainController);
            ProfessorScoreCheckView.Show();
        }

        private void testAddBtn_Click_1(object sender, EventArgs e)
        {
            MakeExamView makeExamView = new MakeExamView(mainController);
            mainController.moveToNextForm(makeExamView);
        }

        private void editLectureBtn_Click_1(object sender, EventArgs e)
        {
            ProfessorLectureEditView professorLectureEditView = new ProfessorLectureEditView(mainController);
            mainController.moveToNextForm(professorLectureEditView);
        }
    }
}
