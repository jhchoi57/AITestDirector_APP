using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
    public partial class StudentLectureEditView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private List<string> selectedID;
        private List<string> myLectureID;

        public StudentLectureEditView(MainController mainController)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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
            selectedID = new List<string>();
            myLectureID = new List<string>();
            // 테이블 행 추가
            lectureTable.ColumnCount = 6;
            lectureTable.Columns[5].Name = "id";
            lectureTable.Columns[5].Visible = false;

            myLectureTable.ColumnCount = 5;
            myLectureTable.Columns[4].Name = "id";
            myLectureTable.Columns[4].Visible = false;

            setAllLectrues();
            setMyLectures();

            // 이미지
            lecturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lecturePictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/lecture.png");

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

            professorNameLbl.Font = customFonts.LabelFont();
            lectureNameLbl.Font = customFonts.LabelFont();

            myLectureLbl.Font = customFonts.SubTitleFont();

            lectureNameTxtBox.Font = customFonts.TextBoxFont();
            professorNameTxtBox.Font = customFonts.TextBoxFont();

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);
        }

        private void setAllLectrues()
        {
            try
            {
                lectureTable.Rows.Clear();
                string response = mainController.getAllLecturesRequest();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                int cnt = jArray.Count;

                for (int i = 0; i < cnt; i++)
                {
                    JObject jObject = (JObject)jArray[i];
                    string id = (string)jObject["uuid"];
                    string name = (string)jObject["name"];
                    string professor = (string)jObject["professor_name"];
                    string semester = (string)jObject["semester"];
                    string time = (string)jObject["time"];

                    lectureTable.Rows.Add(false, name, professor, time, semester, id);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setMyLectures()
        {
            try
            { 
                myLectureTable.Rows.Clear();
                string response = mainController.getStudentAllLecturesRequest();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                int cnt = jArray.Count;
                List<Lecture> lectures = new List<Lecture>();
                for (int i = 0; i < cnt; i++)
                {
                    JObject jObject = (JObject)jArray[i];
                    string id = (string)jObject["uuid"];
                    string name = (string)jObject["name"];
                    string professor = (string)jObject["professor_name"];
                    string semester = (string)jObject["semester"];
                    string time = (string)jObject["time"];

                    lectures.Add(new Lecture(id, name, professor, 0, semester, time));
                    myLectureTable.Rows.Add(false, name, professor, time, id);
                }
                mainController.Me.Lectures = lectures;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void addMyLectures()
        {
            try
            {
                int cnt = selectedID.Count;
                for (int i = 0; i < cnt; i++)
                {
                    string response = mainController.studentEnterLectureRequest(selectedID[i]);

                }
                selectedID.Clear();
                setMyLectures();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void removeMyLectures()
        {
            try
            {
                int cnt = myLectureID.Count;
                for (int i = 0; i < cnt; i++)
                {
                    string response = mainController.studentLeaveLectureRequest(myLectureID[i]);

                }
                myLectureID.Clear();
                setMyLectures();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void lectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //MessageBox.Show(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            if(lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("False"))
                lectureTable.Rows[e.RowIndex].Cells[0].Value = true;
            else
                lectureTable.Rows[e.RowIndex].Cells[0].Value = false;
        }

        private void myLectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("False"))
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = true;
            else
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = false;
        }

        private void addLectureBtn_Click(object sender, EventArgs e)
        {
            string testMsg = "";

            for(int i = 0; i < lectureTable.Rows.Count; i++)
            {
                // 체크박스가 체크되어 있다면
                if (lectureTable.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    selectedID.Add(lectureTable.Rows[i].Cells[5].Value.ToString());
                }
            }

            int count = selectedID.Count;

            if (count == 0) MessageBox.Show("강의를 선택해주세요!");
            else
            {
                addMyLectures();
            }
            
        }

        private void deleteLectureBtn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < myLectureTable.Rows.Count; i++)
            {
                // 체크박스가 체크되어 있다면
                if (myLectureTable.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    myLectureID.Add(myLectureTable.Rows[i].Cells[4].Value.ToString());
                }
            }
            int count = myLectureID.Count;
            if (count == 0) MessageBox.Show("강의를 선택해주세요!");
            else
            {
                removeMyLectures();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (professorNameTxtBox.Text.Equals("") && lectureNameTxtBox.Text.Equals(""))
            {
                setAllLectrues();
            }
            else
            {
                try
                {
                    lectureTable.Rows.Clear();
                    string response;
                    string lecture_name = lectureNameTxtBox.Text;
                    string professor_name = professorNameTxtBox.Text;
                    if (professor.Equals(""))
                    {
                        response = mainController.findLectureByNameReqeust(lecture_name);
                    }
                    else if (lecture_name.Equals(""))
                    {
                        response = mainController.findLectureByProfessorReqeust(professor_name);
                    }
                    else
                    {
                        response = mainController.findLectureReqeust(lecture_name, professor_name);
                    }

                    JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                    int cnt = jArray.Count;

                    for (int i = 0; i < cnt; i++)
                    {
                        JObject jObject = (JObject)jArray[i];
                        string id = (string)jObject["uuid"];
                        string name = (string)jObject["name"];
                        string professor = (string)jObject["professor_name"];
                        string semester = (string)jObject["semester"];
                        string time = (string)jObject["time"];

                        lectureTable.Rows.Add(false, name, professor, time, semester, id);
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }

        private void professorNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void lectureNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }
    }
}
