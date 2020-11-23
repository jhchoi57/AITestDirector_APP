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
using program.Model.Exams;
using program.View.Components;

namespace program.View
{
    public partial class ProfessorHomeView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private string selectedID;
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

            // 이미지
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/user.png");

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
            initFont(customFonts);

            testAddBtn.Click += testAddBtn_Click_1;
            editLectureBtn.Click += editLectureBtn_Click_1;

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            this.lectureTable.Columns[5].Visible = false;

            setUserInfo();
            setUserLecture();
            setUserExam();
            mainController.getAllExamReqeust();
            selectedID = "";
        }

        private void initFont(CustomFonts customFonts)
        {
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

            testInfoLectureLbl.Font = customFonts.TitleFont();
            testInfoTestNameLbl.Font = customFonts.SubTitleFont();
            testInfoProfNameLbl.Font = customFonts.LabelFont();
            testInfoDayLbl.Font = customFonts.LabelFont();
            testInfoTimeLbl.Font = customFonts.LabelFont();
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

        private void setUserLecture()
        {
            try
            {
                string response = mainController.getProfessorAllLecturesRequest();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                int cnt = jArray.Count;
                List<Lecture> lectures = new List<Lecture>();
                for (int i = 0; i < cnt; i++)
                {
                    string id = (string)jArray[i]["uuid"];
                    string name = (string)jArray[i]["name"];
                    int studentCnt = (int)jArray[i]["student_cnt"];
                    string professor = (string)jArray[i]["professor_name"];
                    string semester = (string)jArray[i]["semester"];
                    string time = (string)jArray[i]["time"];
                    lectures.Add(new Lecture(id, name, professor, studentCnt, semester, time));
                }
                mainController.Me.Lectures = lectures;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setUserExam()
        {
            lectureTable.Rows.Clear();
            try
            {
                string response = mainController.getAllExamReqeust();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                int cnt = jArray.Count;
                for (int i = 0; i < cnt; i++)
                {
                    string id = (string)jArray[i]["uuid"];
                    string examName = (string)jArray[i]["exam_name"];
                    string startTime = (string)jArray[i]["start_at"];
                    string endTime = (string)jArray[i]["finish_at"];
                    string lectureName = (string)jArray[i]["lecture_name"];
                    string professor = (string)jArray[i]["professor_name"];
                    string date = startTime.Substring(0, 10);
                    string time = startTime.Substring(11, 5) + " - " + endTime.Substring(11, 5);

                    // 테이블 행 추가
                    // Sample
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
            if (e.RowIndex < 0) return;

            selectedID = lectureTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            { // 버튼 컬럼 위치
                MakeExamView makeExamView = new MakeExamView(mainController, selectedID);
                mainController.moveToNextForm(makeExamView);
            }
            else if(e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                try
                {
                    mainController.professorRemoveExamRequest(selectedID);
                    setUserExam();
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
            }

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

        private void editMinimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void editExitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        private void minimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void exitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        private void checkScoreBtn_Click(object sender, EventArgs e)
        {
            ProfessorScoreCheckView ProfessorScoreCheckView = new ProfessorScoreCheckView(mainController);
            mainController.moveToNextForm(ProfessorScoreCheckView);
        }

        private void testAddBtn_Click_1(object sender, EventArgs e)
        {
            if (mainController.Me.Lectures.Count == 0)
            {
                MessageBox.Show("하나 이상의 강의가 존재해야 시험을 출제하실 수 있습니다.", "시험 출제 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MakeExamView makeExamView = new MakeExamView(mainController);
            mainController.moveToNextForm(makeExamView);
        }

        private void editLectureBtn_Click_1(object sender, EventArgs e)
        {
            ProfessorLectureEditView professorLectureEditView = new ProfessorLectureEditView(mainController);
            mainController.moveToNextForm(professorLectureEditView);
        }

        private void lectureTable_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                lectureTable.Rows[e.RowIndex].Cells[0].Value = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
            }
        }

        private void testInfoCancelBtn_Click(object sender, EventArgs e)
        {
            // 시험정보 패널 가리고 마이페이지 보여줌
            testInfoPanel.Visible = false;
            myPagePanel.Visible = true;
        }

        private void testStartBtn_Click(object sender, EventArgs e)
        {
            // 현재 진행중인 시험 들어갈 수 있게 //
            MessageBox.Show(" 시험  입장 ~~");

        }
    }
}
