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
using Excel = Microsoft.Office.Interop.Excel;


namespace program.View
{
    public partial class ProfessorDetailScoreView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private string lectureName;
        private string testName;
        private string testDay;
        private string totalScore;
        private string percent;
        private string room_id;

        public ProfessorDetailScoreView(MainController mainController, string room_id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
            this.room_id = room_id;
        }

        public void SetScoreData(string LN, string TN, string TD, string TS, string PC)
        {
            this.lectureName = LN;
            this.testName = TN;
            this.testDay = TD;
            this.totalScore = TS;
            this.percent = PC;
        }

        private void ProfessorDetailScoreView_Load(object sender, EventArgs e)
        {


            // ProfessorScoreCheckView에서 강의, 시험 정보 받아서 텍스트 바꿔줘야 함

            // example

            // 강의명
            lectureText.Text = lectureName;

            // 시험명
            testNameText.Text = testName;

            // 시험 날짜
            testDayText.Text = testDay;

            // 총 점수
            totalScoreText.Text = totalScore;

            // 반영 비율
            percentLabelText.Text = percent;




            // Font setting
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            studentScoreTable.Font = customFonts.NormalFont();
            scoreCheckLabel.Font = customFonts.TitleFont();

            // 강의명
            lectureText.Font = customFonts.LectureTitleFont();

            // 시험명
            testNameText.Font = customFonts.SubTitleFont();

            // 시험 날짜
            testDayText.Font = customFonts.SubTitleFont();

            // 총 점수
            totalScoreLbl.Font = customFonts.SubTitleFont();
            totalScoreText.Font = customFonts.SubTitleFont();

            // 평균 점수
            avgScoreLbl.Font = customFonts.SubTitleFont();
            avgScoreText.Font = customFonts.SubTitleFont();

            // 반영 비율
            percentLabel.Font = customFonts.SubTitleFont();
            percentLabelText.Font = customFonts.SubTitleFont();

            // PictureBox Setting
            scorePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scorePictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/score.png");

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            loadAllStudentExamResult();
        }

        private void loadAllStudentExamResult()
        {
            try
            {
                string response = mainController.professorGetAllStudentExamResult(room_id);
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                Console.WriteLine(jObject);
                JArray student_result = (JArray)jObject["results"];

                setStudentScore(student_result);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setStudentScore(JArray student_result)
        {
            studentScoreTable.Rows.Clear();
            int count = student_result.Count;
            int sum = 0;
            double avg = 0.0;

            for (int i = 0; i < count; i++)
            {
                string id = (string)student_result[i]["user_id"];
                string name = (string)student_result[i]["user_name"];
                int score = (int)student_result[i]["score"];
                string is_checked = (Boolean)student_result[i]["is_graded"] ? "○" : "✕";

                sum += score;
                studentScoreTable.Rows.Add(id, name, score.ToString(), is_checked);
            }

            avg = (double)sum / count;
            avgScoreText.Text = avg.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doubtBtn_Click(object sender, EventArgs e)
        {
        }

        private void excelDownBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            bool IsExport = false;

            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //DataGridView에 불러온 Data가 아무것도 없을 경우
            if (studentScoreTable.Rows.Count == 0)
            {
                MessageBox.Show("데이터가 없습니다.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                worksheet = workbook.ActiveSheet;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int col = 0; col < studentScoreTable.Columns.Count; col++)
                {
                    if (cellRowIndex == 1)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = studentScoreTable.Columns[col].HeaderText;
                    }
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;

                for (int row = 0; row < studentScoreTable.Rows.Count - 1; row++)
                {
                    for (int col = 0; col < studentScoreTable.Columns.Count; col++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = studentScoreTable.Rows[row].Cells[col].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveFileDialog = GetExcelSave();

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("저장되었습니다.");
                    IsExport = true;
                }

                //Export 성공 했으면 객체들 해제
                if (IsExport)
                {
                    workbook.Close();
                    excel.Quit();
                    workbook = null;
                    excel = null;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private SaveFileDialog GetExcelSave()
        {
            //Getting the location and file name of the excel to save from user.
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.CheckPathExists = true;
            saveDialog.AddExtension = true;
            saveDialog.ValidateNames = true;
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            saveDialog.DefaultExt = ".xlsx";
            saveDialog.Filter = "Microsoft Excel Workbook (*.xls)|*.xlsx";
            saveDialog.FileName = "학생별 성적 확인".ToString();

            return saveDialog;
        }

        private void studentScoreTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                string student_id = studentScoreTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                string student_name = studentScoreTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                BookMarkView bookMarkView = new BookMarkView(mainController, student_id, room_id, student_name);
                mainController.moveToNextForm(bookMarkView);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
