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
    public partial class ProfessorScoreCheckView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;

        public ProfessorScoreCheckView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }

        private void ProfessorScoreCheckView_Load(object sender, EventArgs e)
        {
            
            // Font setting
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            lectureTable.Font = customFonts.NormalFont();
            scoreCheckLabel.Font = customFonts.TitleFont();

            // PictureBox Setting
            scorePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scorePictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/score.png");

            loadAllExamResults();

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);
        }

        private void loadAllExamResults()
        {
            try
            {
                string response = mainController.professorGetAllExamResult();
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                setLectureTable(jArray);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setLectureTable(JArray jArray)
        {
            int count = jArray.Count;
            lectureTable.Rows.Clear();
            for (int i = 0; i < count; i++)
            {
                string lecture_name = (string)jArray[i]["name"];
                JArray jExamArray = (JArray)jArray[i]["rooms"];
                int cnt = jExamArray.Count;
                for (int j = 0; j < cnt; j++)
                {
                    string room_id = (string)jExamArray[j]["uuid"];
                    string startTime = (string)jExamArray[j]["start_at"];
                    string endTime = (string)jExamArray[j]["finish_at"];
                    string exam_name = (string)jExamArray[j]["exam_name"];
                    int percent = (int)jExamArray[j]["score_rate"];
                    int total_score = (int)jExamArray[j]["all_score"];

                    string time = startTime.Substring(6, 4) + "/" + startTime.Substring(0, 5) + " " + startTime.Substring(11, 5) + " ~ " + endTime.Substring(11, 5);

                    lectureTable.Rows.Add(lecture_name, exam_name, time, total_score, percent.ToString() + "%", "", room_id);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lectureTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string lectureName, testName , testDay, totalScore, avgScore, room_id;

            // 강의명
            lectureName = lectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();

            // 시험명
            testName = lectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();

            // 시험 날짜
            testDay = lectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();

            // 총 점수
            totalScore = lectureTable.Rows[e.RowIndex].Cells[3].Value.ToString();

            // 평균 점수
            avgScore = lectureTable.Rows[e.RowIndex].Cells[4].Value.ToString();

            room_id = lectureTable.Rows[e.RowIndex].Cells[6].Value.ToString();

            MessageBox.Show("강의명 : " + lectureName + "\n" +
                "시험명 : " + testName + "\n" +
                "시험 날짜 " + testDay + "\n" +
                "총 점수 : " + totalScore + "\n" +
                "반영 비율 : " + avgScore + "\n" +
                "room_id : " + room_id + "\n"
                );

            ProfessorDetailScoreView professorDetailScoreView = new ProfessorDetailScoreView(mainController, room_id);
            professorDetailScoreView.SetScoreData(lectureName, testName, testDay, totalScore, avgScore);
            mainController.moveToNextForm(professorDetailScoreView);
        }
    }
}
