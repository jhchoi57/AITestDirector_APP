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
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.Model.Exams;
using program.View.Components;
using Excel = Microsoft.Office.Interop.Excel;

namespace program.View
{
    public partial class ProfessorLectureEditView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private Color selectedColor = Color.FromArgb(51, 71, 97);
        private Color notSelectedColor = Color.Gray;
        private string selectedID;

        public ProfessorLectureEditView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
        }   

        private void ProfessorLectureEditView_Load(object sender, EventArgs e)
        {
            // 콤보박스 설정
            setYearComboBox(1990, 2021);
            setSemesterComboBox();

            // 이미지
            lecturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lecturePictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/lecture.png");
            
            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            myLectureLbl.Font = customFonts.LabelFont();
            myLectureTable.Font = customFonts.TextBoxFont();

            lectureNameLbl.Font = customFonts.LabelFont();
            lectureNameTextBox.Font = customFonts.TextBoxFont();
            lectureTimeLbl.Font = customFonts.LabelFont();
            lectureTimeTextBox.Font = customFonts.TextBoxFont();
            lectureTotalStuentLbl.Font = customFonts.LabelFont();
            lectureTotalStudentTextBox.Font = customFonts.TextBoxFont();
            lectureSemesterLbl.Font = customFonts.LabelFont();
            backButton.Font = customFonts.TextBoxFont();
            confirmBtn.Font = customFonts.TextBoxFont();
            addLectureBtn.Font = customFonts.TextBoxFont();
            deleteBtn.Font = customFonts.TextBoxFont();
            editBtn.Font = customFonts.TextBoxFont();
            infoLbl.Font = customFonts.NormalFont();

            yearComboBox.Font = customFonts.TextBoxFont();
            semesterComboBox.Font = customFonts.TextBoxFont();
     
            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(topBarPanel);

            lectureTotalStudentTextBox.KeyPress += textBox_KeyPress_1;
            this.myLectureTable.ColumnCount = 5;
            this.myLectureTable.Columns[4].Name = "id";
            this.myLectureTable.Columns[4].Visible = false;
            // Sample
            setMyLectureTable();
        }

        private void setMyLectureTable()
        {
            myLectureTable.Rows.Clear();
            int cnt = mainController.Me.Lectures.Count;
            List<Lecture> lectures = mainController.Me.Lectures;

            for (int i = 0; i < cnt; i++)
            {
                myLectureTable.Rows.Add(lectures[i].Name, lectures[i].Time, lectures[i].StudentCnt.ToString(), lectures[i].Semester, lectures[i].ID);            
            }
        }

        private void myLectureExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void myLectureTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            lectureTimeTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            lectureTotalStudentTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            yearComboBox.Text = myLectureTable.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0,4);
            semesterComboBox.Text = myLectureTable.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(5);
            selectedID = myLectureTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            // 첫 글자에 화살표 없을때
            if (!myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
            {
                lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = "▶" + myLectureTable.Rows[e.RowIndex].Cells[0].Value;
            }
            // 첫 글자에 화살표 있을때
            else
            {
                lectureNameTextBox.Text = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Replace("▶","");
            }

            // 버튼 초기화
            addLectureBtn.BackColor = notSelectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = notSelectedColor;
            confirmBtn.Visible = false;

            // 

            // 읽기 전용 모드
            lectureNameTextBox.ReadOnly = true;
            lectureTimeTextBox.ReadOnly = true;
            lectureTotalStudentTextBox.ReadOnly = true;
            yearComboBox.Enabled = false;
            semesterComboBox.Enabled = false;
        }

        private void myLectureTable_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString()[0].Equals('▶'))
                myLectureTable.Rows[e.RowIndex].Cells[0].Value = myLectureTable.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(1);
        }

        private void addLectureBtn_Click(object sender, EventArgs e)
        {
            // 강의 추가 이벤트

            // 텍스트박스 초기화
            lectureNameTextBox.Text = null;
            lectureTimeTextBox.Text = null;
            lectureTotalStudentTextBox.Text = null;
            yearComboBox.Text = null;
            semesterComboBox.Text = null;

            lectureNameTextBox.ReadOnly = false;
            lectureTimeTextBox.ReadOnly = false;
            lectureTotalStudentTextBox.ReadOnly = false;
            yearComboBox.Enabled = true;
            semesterComboBox.Enabled = true;

            // 다른 버튼 회색으로 변경, 강의 추가 버튼만 진하게
            addLectureBtn.BackColor = selectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = notSelectedColor;

            // 확인 버튼
            confirmBtn.Visible = true;
            confirmBtn.Text = "추가 확인";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // 강의 수정 이벤트

            // 강의 선택 여부 확인
            if(lectureNameTextBox.ReadOnly == false)
            {
                MessageBox.Show("수정할 강의를 선택해주세요!!!");
                return;
            }

            // 읽기 전용 풀고
            // key 값은 풀면 안될듯? 일단 강의명만
            //lectureNameTextBox.ReadOnly = false;
            lectureTimeTextBox.ReadOnly = false;
            lectureTotalStudentTextBox.ReadOnly = false;
            yearComboBox.Enabled = true;
            semesterComboBox.Enabled = true;

            // 다른 버튼 회색으로 변경, 강의 수정 버튼만 진하게
            addLectureBtn.BackColor = notSelectedColor;
            deleteBtn.BackColor = notSelectedColor;
            editBtn.BackColor = selectedColor;

            // 확인 버튼
            confirmBtn.Visible = true;
            confirmBtn.Text = "수정 확인";

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 강의 삭제 이벤트

            // 표에서 강의 선택해서 전부 READONLY 일때(확실할때만) 삭제
            if(lectureNameTextBox.ReadOnly &&
            lectureTimeTextBox.ReadOnly &&
            lectureTotalStudentTextBox.ReadOnly &&
            yearComboBox.Enabled == false &&
            semesterComboBox.Enabled == false)
            {
                // 다른 버튼 회색으로 변경, 강의 삭제 버튼만 진하게
                addLectureBtn.BackColor = notSelectedColor;
                deleteBtn.BackColor = selectedColor;
                editBtn.BackColor = notSelectedColor;

                // 확인 버튼
                confirmBtn.Visible = true;
                confirmBtn.Text = "삭제 확인";
            }
            // 하나라도 READONLY가 아닐 경우
            else
            {
                MessageBox.Show("표에서 강의를 다시 선택해주세요!!!");
            }
            
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // 확인 버튼 처리
            if (lectureNameTextBox.Text == "")
            {
                MessageBox.Show("강의명을 입력해주세요!!!");
                return;
            }
            // 강의 시간 입력 확인
            if (lectureTimeTextBox.Text == "")
            {
                MessageBox.Show("강의 시간을 입력해주세요!!!");
                return;
            }
            // 수강 학생 인원 입력 확인
            if (lectureTotalStudentTextBox.Text == "")
            {
                MessageBox.Show("수강 학생 인원을 입력해주세요!!!");
                return;
            }
            // 강의년도 입력 확인
            if (yearComboBox.Text == "")
            {
                MessageBox.Show("강의년도를 선택해주세요!!!");
                return;
            }
            // 강의학기 입력 확인
            if (semesterComboBox.Text == "")
            {
                MessageBox.Show("강의학기를 선택해주세요!!!");
                return;
            }
            string name = lectureNameTextBox.Text;
            string time = lectureTimeTextBox.Text;
            string semester = yearComboBox.Text + "-" + semesterComboBox.Text;


            try
            {
                int studentCnt = int.Parse(lectureTotalStudentTextBox.Text);
                // 강의 추가 이벤트일 경우
                if (addLectureBtn.BackColor == selectedColor)
                {
                    try
                    {
                        string response = mainController.professorAddLectureRequest(name, time, studentCnt, semester);
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                        string id = (string)jObject["uuid"];
                        mainController.Me.Lectures.Add(new Lecture(id, name, mainController.Me.Name, studentCnt, semester, time));
                        setMyLectureTable();
                        addLectureBtn.BackColor = notSelectedColor;
                        confirmBtn.Visible = false;
                        MessageBox.Show("강의 추가 완료", "강의 추가");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                }

                // 강의 수정 이벤트일 경우
                else if (editBtn.BackColor == selectedColor)
                {
                    try
                    {
                        string response = mainController.professorModifyLectureRequest(selectedID, name, time, studentCnt, semester);
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                        string id = (string)jObject["uuid"];
                        int cnt = mainController.Me.Lectures.Count;
                        for (int i = 0; i < cnt; i++)
                        {
                            if (selectedID.Equals(mainController.Me.Lectures[i].ID))
                            {
                                mainController.Me.Lectures[i].modifyLecture(name, mainController.Me.Name, studentCnt, semester, time);
                            }
                        }
                        setMyLectureTable();
                        editBtn.BackColor = notSelectedColor;
                        confirmBtn.Visible = false;
                        MessageBox.Show("강의 수정 완료", "강의 수정");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                }

                // 강의 삭제 이벤트일 경우
                else if (deleteBtn.BackColor == selectedColor)
                {
                    try
                    {
                        string response = mainController.professorRemoveLectureRequest(selectedID);
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                        int cnt = mainController.Me.Lectures.Count;
                        for (int i = 0; i < cnt; i++)
                        {
                            if (selectedID.Equals(mainController.Me.Lectures[i].ID))
                            {
                                mainController.Me.Lectures.RemoveAt(i);
                                break;
                            }
                        }
                        setMyLectureTable();
                        deleteBtn.BackColor = notSelectedColor;
                        confirmBtn.Visible = false;
                        MessageBox.Show("강의 삭제 완료", "강의 삭제");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show("숫자만 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void setYearComboBox(int minYear, int maxYear)
        {
            for(int i = minYear; i<=maxYear; i++)
            {
                yearComboBox.Items.Add(i);
            }            
        }

        private void setSemesterComboBox()
        {
            semesterComboBox.Items.Add("겨울학기");
            semesterComboBox.Items.Add("1학기");
            semesterComboBox.Items.Add("여름학기");
            semesterComboBox.Items.Add("2학기");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;
            Excel.Application excelApp = null; 
            Excel.Workbook workBook = null; 
            Excel.Worksheet workSheet = null;


            // 파일 여는 다이얼로그 path 추출
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                path = OFD.FileName;
                Console.WriteLine(path);
            }
            // 예외처리
            if (path == null)
            {
                workBook.Close(true); // 워크북 닫기 
                excelApp.Quit();     // 엑셀 어플리케이션 종료 
                return;
            }

            try
            {                
                excelApp = new Excel.Application(); // 엑셀 어플리케이션 생성 
                workBook = excelApp.Workbooks.Open(path); // 워크북 열기 
                workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기 
                Excel.Range range = workSheet.UsedRange; // 사용중인 셀 범위를 가져오기 
                // 1행은 제목
                if (checkExcel(range)==false)
                {
                    MessageBox.Show("형식이 맞지 않습니다. 엑셀파일을 확인해주세요.");
                    workBook.Close(true); // 워크북 닫기 
                    excelApp.Quit();     // 엑셀 어플리케이션 종료 
                    return;
                }
                for (int row = 2; row <= range.Rows.Count; row++) // 가져온 행 만큼 반복 
                {
                    string name, time, semester;
                    int studentCnt;
                    name = (range.Cells[row, 1] as Excel.Range).Value2.ToString();
                    Console.Write(name + " ");
                    time = (range.Cells[row, 2] as Excel.Range).Value2.ToString();
                    Console.Write(time + " ");
                    studentCnt = Convert.ToInt32((range.Cells[row, 3] as Excel.Range).Value2.ToString());
                    Console.Write(studentCnt + " ");
                    semester = (range.Cells[row, 4] as Excel.Range).Value2.ToString();
                    Console.Write(semester + "\n");

                    try
                    {
                        string response = mainController.professorAddLectureRequest(name, time, studentCnt, semester);
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                        string id = (string)jObject["uuid"];
                        mainController.Me.Lectures.Add(new Lecture(id, name, mainController.Me.Name, studentCnt, semester, time));
                        setMyLectureTable();
                        //MessageBox.Show("강의 추가 완료", "강의 추가");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                    workBook.Close(true); // 워크북 닫기 
                    excelApp.Quit();     // 엑셀 어플리케이션 종료 
                }                
            } 
            catch(Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show("형식이 맞지 않습니다. 엑셀파일을 확인해주세요.");
            }            
            finally {
                AllReleaseObject(workSheet, workBook, excelApp);                
            }


        }
        private void AllReleaseObject(object workSheet, object workBook, object excelApp)
        {
            ReleaseObject(workSheet);
            ReleaseObject(workBook);
            ReleaseObject(excelApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj); // 액셀 객체 해제 obj = null; 
                } 
            } 
            catch (Exception ex) 
            { 
                obj = null; throw ex; 
            } 
            finally 
            { 
                GC.Collect(); // 가비지 수집 
            } 
        }
        private Boolean checkExcel(Excel.Range range)
        {
            if ((range.Cells[1, 1] as Excel.Range).Value2.ToString() == "강의명" &&
                    (range.Cells[1, 2] as Excel.Range).Value2.ToString() == "강의시간" &&
                    (range.Cells[1, 3] as Excel.Range).Value2.ToString() == "수강 학생 인원" &&
                    (range.Cells[1, 4] as Excel.Range).Value2.ToString() == "강의년도-학기")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
