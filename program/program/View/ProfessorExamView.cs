using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.Model;
using program.Model.Exams;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class ProfessorExamView : Form
    {
        private List<Student> studentList;
        private Queue<Student> enterQueue;
        private Queue<Student> exitQueue;
        private Queue<Chat> chatQueue;
        private Queue<Doubt> doubtQueue;
        private ExamController examController;
        private string room_id;
        private System.Windows.Forms.Timer timer;
        private DateTime examDate;
        private CustomFonts customFonts;
        private ChatPanel noticePanel;
        private List<ChatPanel> chatPanelList;
        private ChatPanel nowChatPanel;
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private List<StudentWebRTCPanel> studentScreenList;

        public ProfessorExamView(MainController mainController, string room_id)
        {
            InitializeComponent();
            this.mainController = mainController;

            this.room_id = room_id;
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ProfessorExamView_Load(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();

            studentScreenList = new List<StudentWebRTCPanel>();

            this.examTimeLabel.Font = customFonts.TimeLabelFont(); 
            this.examLectureLabel.Font = customFonts.LabelFont();
            this.examNameLabel.Font = customFonts.LabelFont();
            this.examPercentLabel.Font = customFonts.LabelFont();

            loadExam();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick_1;
            timer.Start();

            this.noticePanel = new ChatPanel(customFonts, "공지사항 전송", "");
            this.noticePanel.Location = new Point(18, 242);
            this.noticePanel.BringToFront();
            this.noticePanel.SendButton.Click += noticeSendButton_Click_1;
            this.studentListPanel.Controls.Add(this.noticePanel);

            this.chatPanelList = new List<ChatPanel>();
            this.nowChatPanel = noticePanel;

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(8, 488);
            this.Controls.Add(this.examPageNavigationPanel);
            this.examPageNavigationPanel.AddPageButton.Visible = false;
            this.examPageNavigationPanel.RemovePageButton.Visible = false;

            setCheatTypePanels();

            chatQueue = new Queue<Chat>();
            studentList = new List<Student>();
            enterQueue = new Queue<Student>();
            exitQueue = new Queue<Student>();
            doubtQueue = new Queue<Doubt>();

            connectWebsocket();

            exitBtn.Click += exitBtn_Click_1;
            sendNoticeBtn.Click += sendNoticeBtn_Click_1;
        }

        private void setCheatTypePanels()
        {
            CheatTypePanel cheatTypePanel = new CheatTypePanel(customFonts, Color.Black, "대리 시험");
            cheatTypePanel.Location = new Point(300, 17);
            this.examInfoPanel.Controls.Add(cheatTypePanel);
            cheatTypePanel = new CheatTypePanel(customFonts, Color.HotPink, "자리 비움");
            cheatTypePanel.Location = new Point(300, 55);
            this.examInfoPanel.Controls.Add(cheatTypePanel);
            cheatTypePanel = new CheatTypePanel(customFonts, Color.Purple, "다수 인원");
            cheatTypePanel.Location = new Point(300, 93);
            this.examInfoPanel.Controls.Add(cheatTypePanel);
            cheatTypePanel = new CheatTypePanel(customFonts, Color.Yellow, "눈동자 추적");
            cheatTypePanel.Location = new Point(460, 17);
            this.examInfoPanel.Controls.Add(cheatTypePanel);
            cheatTypePanel = new CheatTypePanel(customFonts, Color.OrangeRed, "사람 음성");
            cheatTypePanel.Location = new Point(460, 55);
            this.examInfoPanel.Controls.Add(cheatTypePanel);
        }

        private void connectWebsocket()
        {
            (new Thread(new ThreadStart(() =>
            {
                examController = new ExamController(chatQueue, doubtQueue, enterQueue, exitQueue, room_id, mainController.Me.Token);
                Boolean conn = examController.connect();
                 
                if (!conn)
                {
                    MessageBox.Show("네트워크 연결상태를 확인해주세요.", "네트워크 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exitBtn.PerformClick();
                    return;
                }
                examController.getAllExamUser();
            }))).Start();
        }

        private void loadExam()
        {
            try
            {
                string response = mainController.getExamRequest(room_id);
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                string lectureName = (string)jObject["lecture_name"];
                string examName = (string)jObject["exam_name"];
                int percent = (int)jObject["score_rate"];
                string endTime = (string)jObject["finish_at"];
                examLectureLabel.Text = "강의명:  " + lectureName;
                examNameLabel.Text = "시험명:  " + examName;
                examPercentLabel.Text = "성적 반영 비율:  " + percent + "%";
                setTime(endTime);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
        private void setTime(string time)
        {
            int year = int.Parse(time.Substring(0, 4));
            int month = int.Parse(time.Substring(5, 2));
            int day = int.Parse(time.Substring(8, 2));
            int hour = int.Parse(time.Substring(11, 2));
            int minute = int.Parse(time.Substring(14, 2));
            int sec = int.Parse(time.Substring(17, 2));

            examDate = new DateTime(year, month, day, hour, minute, sec);
            double diffTotalSeconds = (examDate - DateTime.Now).TotalSeconds;
            setTimeLabel(diffTotalSeconds);
        }
        private void setTimeLabel(double diffTotalSeconds)
        {
            int hour = (int)diffTotalSeconds / 3600;
            int minute = (int)diffTotalSeconds % 3600 / 60;
            int second = (int)diffTotalSeconds % 60;

            string hourString = hour.ToString();
            string minuteString;
            string secondString;

            if (minute < 10)
                minuteString = "0" + minute.ToString();
            else
                minuteString = minute.ToString();
            if (second < 10)
                secondString = "0" + second.ToString();
            else
                secondString = second.ToString();

            this.examTimeLabel.Text = hourString + ":" + minuteString + ":" + secondString;
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {

            try
            {
                DateTime date = DateTime.Now; 
                
                makeAllWebRTCNormal();

                if (enterQueue.Count > 0)
                {
                    studentEnter();
                }

                if (exitQueue.Count > 0)
                {
                    studentExit();
                }

                if (chatQueue.Count > 0)
                {
                    writeAllMessages();
                }
                
                if (doubtQueue.Count > 0)
                {
                    checkDoubtStudent();
                }
                double diffTotalSeconds = (examDate - date).TotalSeconds;
                if (diffTotalSeconds <= 0)
                {
                    timer.Stop();
                    disconnectAllWebRTC();
                    MessageBox.Show("시험이 종료됐습니다.", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mainController.moveToPreviousForm();
                }
                setTimeLabel(diffTotalSeconds);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void checkDoubtStudent()
        {
            int count = doubtQueue.Count;

            for (int i = 0; i < count; i++)
            {
                Doubt doubt = doubtQueue.Dequeue();
                int webRTCIndex = findWebRTCIndex(doubt.Student_id);
                StudentWebRTCPanel studentWebRTCPanel = studentScreenList[webRTCIndex];
                if (doubt.Type.Equals("Audio"))
                {
                    studentScreenList[webRTCIndex].setSoundDoubtColor();
                }
                else if (doubt.Type.Equals("Gaze"))
                {
                    studentScreenList[webRTCIndex].setGazeDoubtColor();
                }
                else if (doubt.Type.Equals("No_Face"))
                {
                    studentScreenList[webRTCIndex].setNoPersonDoubtColor();
                }
                else if (doubt.Type.Equals("SIMILAR"))
                {
                    studentScreenList[webRTCIndex].setDifferentPersonColor();
                }
                else
                {
                    studentScreenList[webRTCIndex].setFaceDoubtColor();
                }
                studentScreenList.RemoveAt(webRTCIndex);
                studentScreenList.Insert(0, studentWebRTCPanel);
            }

            sortWebRTCScreens();
        }

        private void makeAllWebRTCNormal()
        {
            int count = studentScreenList.Count;
            for(int i = 0; i < count; i++)
            {
                if (studentScreenList[i].TimeCount <= 0)
                {
                    continue;
                }
                else if (studentScreenList[i].TimeCount > 3)
                {
                    studentScreenList[i].setNormalColor();
                }
                else
                {
                    studentScreenList[i].TimeCount++;
                }
            }
        }

        private void sortWebRTCScreens()
        {
            int count = studentScreenList.Count;
            if (count > 6)
            {
                count = 6;
            }

            for (int i = 0; i < count; i++)
            {
                studentScreenList[i].Location = new Point((i % 3) * 300, (i / 3) * 230);
            }
        }

        private void disconnectAllWebRTC()
        {
            int count = studentScreenList.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                this.webViewPanel.Controls.Remove(studentScreenList[i]);
                studentScreenList[i].disconnectBrowser();
                studentScreenList.RemoveAt(i);
            }
        }

        private void writeAllMessages()
        {
            int count = chatQueue.Count;

            for (int i = 0; i < count; i++)
            {
                try
                {
                    Chat chat = chatQueue.Dequeue();
                    int chatPanelIndex = findChatPanelIndex(chat.StudentID);
                    int rowIndex = findTableRowIndex(chat.StudentID);

                    chatPanelList[chatPanelIndex].addChatContentPanel(new ChatContentPanel(customFonts, chat.Message, 1));
                    if (nowChatPanel != chatPanelList[chatPanelIndex])
                    {
                        if (studentTable.Rows[rowIndex].Cells[2].Value.ToString().Equals("") || studentTable.Rows[rowIndex].Cells[2].Value == null)
                        {
                            studentTable.Rows[rowIndex].Cells[2].Value = "1";
                        }
                        else
                        {
                            studentTable.Rows[rowIndex].Cells[2].Value = (int.Parse(studentTable.Rows[rowIndex].Cells[2].Value.ToString()) + 1).ToString();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }

        private void studentEnter()
        {
            int count = enterQueue.Count;
            for (int i = 0; i < count; i++)
            {
                Student student = enterQueue.Dequeue();
                studentTable.Rows.Add(student.ID, student.Name, "");
                studentList.Add(student);
                chatPanelList.Add(new ChatPanel(customFonts, student.ID, student.Name));
                chatPanelList[chatPanelList.Count - 1].Location = new Point(18, 242);
                chatPanelList[chatPanelList.Count - 1].Visible = false;
                this.studentListPanel.Controls.Add(this.chatPanelList[chatPanelList.Count - 1]);
                chatPanelList[chatPanelList.Count - 1].SendButton.Click += sendButton_Click_1;
                StudentWebRTCPanel studentWebRTCPanel = new StudentWebRTCPanel(customFonts, student.ID, student.Name, room_id);
                int cnt = studentScreenList.Count;
                studentWebRTCPanel.StatusButton.Click += statusButton_Click_1;
                if (cnt < 6)
                {
                    studentWebRTCPanel.Location = new Point((cnt % 3) * 300, (cnt / 3) * 230);
                }
                else
                {
                    studentWebRTCPanel.Visible = false;
                }
                studentScreenList.Add(studentWebRTCPanel);
                this.webViewPanel.Controls.Add(studentWebRTCPanel);
            }
        }

        private void statusButton_Click_1(object sender, EventArgs e)
        {
            Button statusButton = (Button)sender;
            Panel infoPanel = (Panel)statusButton.Parent;
            StudentWebRTCPanel studentWebRTCPanel = (StudentWebRTCPanel)infoPanel.Parent;

            studentWebRTCPanel.IsBaned = !studentWebRTCPanel.IsBaned;
            studentWebRTCPanel.setButtonText();

            (new Thread(new ThreadStart(() =>
            {
                if (studentWebRTCPanel.IsBaned)
                {
                    examController.professorBanStudent(studentWebRTCPanel.Student_id);
                }
                else
                {
                    examController.professorUnBanStudent(studentWebRTCPanel.Student_id);
                }
            }))).Start();
        }

        private void studentExit()
        {
            int count = exitQueue.Count;

            for (int i = 0; i < count; i++)
            {
                Student student = exitQueue.Dequeue();
                int rowIndex = findTableRowIndex(student.ID);
                if (rowIndex != -1)
                {
                    studentTable.Rows.RemoveAt(rowIndex);
                }
                studentList.Remove(student);

                int chatPanelIndex = findChatPanelIndex(student.ID);

                if (chatPanelIndex == -1) continue;
                this.Controls.Remove(chatPanelList[chatPanelIndex]);
                chatPanelList.RemoveAt(chatPanelIndex);

                int webRTCIndex = findWebRTCIndex(student.ID);
                webViewPanel.Controls.Remove(studentScreenList[webRTCIndex]);
                studentScreenList.RemoveAt(webRTCIndex);
            }
            sortWebRTCScreens();
        }

        private int findWebRTCIndex(string studentID)
        {
            int index = -1;
            int count = studentScreenList.Count;

            for (int i = 0; i < count; i++)
            {
                if (studentScreenList[i].Student_id.Equals(studentID))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private int findTableRowIndex(string studentID)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in studentTable.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(studentID))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            return rowIndex;
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                Panel inputPanel = (Panel)button.Parent;
                ChatPanel selectedChatPanel = (ChatPanel)inputPanel.Parent;

                string str = selectedChatPanel.InputTextBox.Text.Replace(" ", "");
                str = str.Replace("\r", "");
                str = str.Replace("\n", "");
                if (str != "")
                {
                    examController.professorSendMessage(selectedChatPanel.StudentNumber, selectedChatPanel.InputTextBox.Text);
                    selectedChatPanel.addChatContentPanel(new ChatContentPanel(customFonts, selectedChatPanel.InputTextBox.Text, 0));
                    selectedChatPanel.InputTextBox.Text = "";
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        private void noticeSendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str = noticePanel.InputTextBox.Text.Replace(" ", "");
                str = str.Replace("\r", "");
                str = str.Replace("\n", "");
                if (str != "")
                {
                    examController.professorNotice(noticePanel.InputTextBox.Text);
                    noticePanel.addChatContentPanel(new ChatContentPanel(customFonts, noticePanel.InputTextBox.Text, 0));
                    noticePanel.InputTextBox.Text = "";
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }

        }

        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string studentID = studentTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            int chatPanelIndex = findChatPanelIndex(studentID);
            if (chatPanelIndex == -1) return;
            studentTable.Rows[e.RowIndex].Cells[2].Value = "";
            chatPanelList[chatPanelIndex].BringToFront();
            chatPanelList[chatPanelIndex].Visible = true;
            nowChatPanel.Visible = false;
            nowChatPanel = chatPanelList[chatPanelIndex];
        }

        private int findChatPanelIndex(string studentID)
        {
            int cnt = chatPanelList.Count;
            for (int j = cnt - 1; j >= 0; j--)
            {
                if (chatPanelList[j].StudentNumber.Equals(studentID))
                {
                    return j;
                }
            }
            return -1;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                examController.disconnect();
                disconnectAllWebRTC();
                mainController.moveToPreviousForm();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void sendNoticeBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                nowChatPanel.Visible = false;
                noticePanel.Visible = true;
                nowChatPanel = noticePanel;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
