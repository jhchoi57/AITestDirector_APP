using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program.Controller;
using program.View.Components;
using Excel = Microsoft.Office.Interop.Excel;


namespace program.View
{
    public partial class ProfessorDetailScoreView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private String lectureName;
        private String testName;
        private String testDay;
        private String totalScore;
        private String avgScore;

        public ProfessorDetailScoreView(MainController mainController)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }

        public void SetScoreData(String LN, String TN, String TD, String TS, String AS)
        {
            this.lectureName = LN;
            this.testName = TN;
            this.testDay = TD;
            this.totalScore = TS;
            this.avgScore = AS;
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

            // 평균 점수
            avgScoreText.Text = avgScore;




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
            lectureLbl.Font = customFonts.SubTitleFont();
            lectureText.Font = customFonts.SubTitleFont();

            // 시험명
            testNameLbl.Font = customFonts.SubTitleFont();
            testNameText.Font = customFonts.SubTitleFont();

            // 시험 날짜
            testDayLbl.Font = customFonts.SubTitleFont();
            testDayText.Font = customFonts.SubTitleFont();

            // 총 점수
            totalScoreLbl.Font = customFonts.SubTitleFont();
            totalScoreText.Font = customFonts.SubTitleFont();

            // 평균 점수
            avgScoreLbl.Font = customFonts.SubTitleFont();
            avgScoreText.Font = customFonts.SubTitleFont();

            // PictureBox Setting
            scorePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scorePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/score.png");


            // 테이블 Sample 값 추가

            // 강의명, 시험명, 시험 날짜, 총 점수, 평균 점수 받아야됨

            // 학생명 학생점수 채점 여부 표시
            studentScoreTable.Rows.Add("17011010", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011011", "최모씨", "56", "X");
            studentScoreTable.Rows.Add("17011012", "이모씨", "78", "O");
            studentScoreTable.Rows.Add("17011013", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011014", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011015", "최모씨", "56", "X");
            studentScoreTable.Rows.Add("17011016", "이모씨", "78", "O");
            studentScoreTable.Rows.Add("17011017", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011018", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011019", "최모씨", "56", "X");
            studentScoreTable.Rows.Add("17011010", "이모씨", "78", "O");
            studentScoreTable.Rows.Add("17011011", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011012", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011013", "최모씨", "56", "X");
            studentScoreTable.Rows.Add("17011014", "이모씨", "78", "O");
            studentScoreTable.Rows.Add("17011015", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011016", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011017", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011018", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011019", "최모씨", "56", "X");
            studentScoreTable.Rows.Add("17011010", "이모씨", "78", "O");
            studentScoreTable.Rows.Add("17011011", "김모씨", "78", "X");
            studentScoreTable.Rows.Add("17011012", "홍길동", "78", "O");
            studentScoreTable.Rows.Add("17011012", "홍길동", "78", "O");

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doubtBtn_Click(object sender, EventArgs e)
        {
            BookMarkView bookMarkView = new BookMarkView(mainController);
            mainController.moveToNextForm(bookMarkView);
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

    }
}
