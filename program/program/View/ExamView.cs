using CefSharp;
using CefSharp.WinForms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class ExamView : Form
    {
        private CustomFonts customFonts;
        private ChromiumWebBrowser browser;
        private ExamController examController;

        private System.Windows.Forms.Timer timer;
        private DateTime startDate;
        private DateTime examDate;
        private List<ShortCutButton> shortCutButtonList;
        private ChatPanel chatPanel;

        private List<Boolean> isScoredList;

        private MainController mainController;
        private Queue<string> messageQueue;
        private Queue<string> noticeQueue;
        private Queue<string> banQueue;

        private string room_id;
        private string student_id;
        private Boolean isStudent;
        private int webrtcConnectCount;
        private Boolean isBaned;

        private ProcessController processController;

        private static Queue<string> keyboard = new Queue<string>();

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public ExamView(MainController mainController, string room_id, string student_id, Boolean isStudent)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainController = mainController;
            this.room_id = room_id;
            this.student_id = student_id;
            this.isStudent = isStudent;
            messageQueue = new Queue<string>();
            noticeQueue = new Queue<string>();
            banQueue = new Queue<string>();
            isBaned = false;

            if (isStudent)
            {
                // 프로그램 화면 크기 모니터 해상도에 맞춤
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ExamView_Load1(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();

            shortCutButtonList = new List<ShortCutButton>();

            this.examLectureLabel.Font = customFonts.LabelFont();
            this.examNameLabel.Font = customFonts.LabelFont();
            this.examPercentLabel.Font = customFonts.LabelFont();

            this.exitButton = new ExitButton(customFonts);
            this.examInfoPanel.Controls.Add(this.exitButton);
            this.exitButton.Location = new System.Drawing.Point(349, 0);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);

            this.minimizeButton = new MinimizeButton(customFonts);
            this.examInfoPanel.Controls.Add(this.minimizeButton);
            this.minimizeButton.Location = new System.Drawing.Point(319, 0);
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(0, 640);
            this.mainPanel.Controls.Add(this.examPageNavigationPanel);
            this.examPageNavigationPanel.AddPageButton.Visible = false;
            this.examPageNavigationPanel.RemovePageButton.Visible = false;

            this.endExamButton.Font = customFonts.LabelFont();
            this.examTimeLabel.Font = customFonts.TimeLabelFont();
            this.examShortCutLabel.Font = customFonts.TextBoxFont();

            this.examMainQuestionPanelList = new List<ExamMainQuestionPanel>();

            this.examPageNavigationPanel.PageLeftButton.Click += pageLeftButton_Click_1;
            this.examPageNavigationPanel.PageRightButton.Click += pageRightButton_Click_1;
            this.examPageNavigationPanel.NowPageTextBox.KeyPress += nowPageTextBox_KeyPress_1;
            this.examPageNavigationPanel.NowPageTextBox.LostFocus += nowPageTextBox_LostFocus_1;
            this.examPageNavigationPanel.NowPageTextBox.TextChanged += nowPageTextBox_TextChanged_1;

            this.noticePanel = new NoticePanel(customFonts);
            this.noticePanel.Location = new Point(100, 150);
            this.noticePanel.Visible = false;
            this.Controls.Add(this.noticePanel);

            this.examPageNavigationPanel.Controls.Add(this.openChatBoxPanel);

            if (isStudent)
            {
                this.examPanel.BringToFront();
                this.chatPanel = new ChatPanel(customFonts);
                this.chatPanel.Location = new Point(30, 240);
                this.mainPanel.Controls.Add(this.chatPanel);
                this.chatPanel.BringToFront();
                this.chatPanel.Visible = false;
                this.chatPanel.MinimizeBtn.Click += chatPanelMinimizeButton_Click_1;
                this.chatPanel.SendButton.Click += chatPanelSendButton_Click_1;

                this.openChatBoxPanel.Click += openChatBoxPanel_Click_1;
                this.openChatBoxLabel.Click += openChatBoxPanel_Click_1;

                this.openChatBoxLabel.Font = customFonts.NormalFont();
                this.openChatAlertLabel.Font = customFonts.SmallFont();

                this.BackColor = Color.DarkGray;
                // 프로그램 중앙에 메인패널 위치
                this.mainPanel.BackColor = Color.WhiteSmoke;
                this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);

                exitButton.Visible = false;
                minimizeButton.Visible = false;

                // 프로세스 제어
                this.processController = new ProcessController(mainController, room_id);
                processController.CheckProcess();
                processController.KillProcess();

                // 키보드 후킹
                SetHook();

                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += timer_Tick_1;
                timer.Start();

                webrtcConnectCount = 0;
                initwebrtc();
                connectWebsocket();
            }

            isScoredList = new List<Boolean>();

            loadExam();
            initShortCutButton();

            if (!isStudent)
            {
                this.examPanel.BringToFront();
                this.examTimePanel.Visible = false;
                this.openChatBoxPanel.Visible = false;
                this.endExamButton.Text = "채점 종료";
                loadStudentAllAnswers();
            }

            this.endExamButton.Click += endExamButton_Click_1;

        }

        private void loadStudentAllAnswers()
        {
            try
            {
                string response = mainController.professorGetStudentAllAnswer(room_id, student_id);
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                Console.WriteLine(jArray);
                setAnswers(jArray);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setAnswers(JArray jArray)
        {
            int count = jArray.Count;

            for(int i = 0; i < count; i++)
            {
                int num = (int)jArray[i]["question_num"];
                int score = (int)jArray[i]["score"];
                string value = (string)jArray[i]["value"];
                Boolean isScored = (Boolean)jArray[i]["is_scored"];

                isScoredList[num - 1] = isScored;
                ExamSubQuestionPanel subQuestionPanel = examMainQuestionPanelList[shortCutButtonList[num - 1].MainQuestionNo].SubQuestionPanelsList[shortCutButtonList[num - 1].SubQuestionNo];
                subQuestionPanel.StudentScorePanel.ScoreTextBox.Text = score.ToString();
                int type = subQuestionPanel.Type;
                if (type == 0)
                {
                    ExamOXPanel oxPanel = (ExamOXPanel)subQuestionPanel;
                    oxPanel.checkAnswer(value);
                }
                else if (type == 1)
                {
                    ExamShortAnswerQuestionPanel shortAnswerQuestionPanel = (ExamShortAnswerQuestionPanel)subQuestionPanel;
                    shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text = value;
                    shortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.Text = value;
                    if (!value.Equals(""))
                    {
                        shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Visible = true;
                        shortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.Visible = false;
                    }
                }
                else if (type == 2)
                {
                    ExamEssayQuestionPanel essayQuestionPanel = (ExamEssayQuestionPanel)subQuestionPanel;
                    essayQuestionPanel.AnswerPanel.AnswerLabel.Text = value;
                    essayQuestionPanel.AnswerPanel.AnswerTextBox.Text = value;
                    if (!value.Equals(""))
                    {
                        essayQuestionPanel.AnswerPanel.AnswerLabel.Visible = true;
                        essayQuestionPanel.AnswerPanel.AnswerTextBox.Visible = false;
                    }
                }
                else
                {
                    ExamMultipleChoiceQuestionPanel multipleChoiceQuestionPanel = (ExamMultipleChoiceQuestionPanel)subQuestionPanel;
                    multipleChoiceQuestionPanel.checkAnswer(value);
                }
            }
        }

        private void initwebrtc()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            if(!Cef.IsInitialized) Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("https://webrtc.inchang.dev:10001/?mode=sender&autoStart=true&userId=" + mainController.Me.ID + "&roomId=" + this.room_id);
            browser.Dock = DockStyle.Fill;
            this.webrtcPanel.Controls.Add(browser);
        }

        private void connectWebsocket()
        {
            (new Thread(new ThreadStart(() =>
                {
                    examController = new ExamController(messageQueue, noticeQueue, banQueue, room_id, mainController.Me.Token);
                    Boolean conn = examController.connect();
                    
                    if (!conn)
                    {
                        if (browser != null)
                        {
                            browser.Dispose();
                            browser = null;
                        }
                        UnHook();
                        MessageBox.Show("네트워크 연결상태를 확인해주세요.", "네트워크 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        endExamButton.PerformClick();
                    }
                }))).Start();
        }

        private void disconnectWebsocket()
        {
            examController.disconnect();
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
                string startTime = (string)jObject["start_at"];
                string endTime = (string)jObject["finish_at"];
                string questions = (string)jObject["questions_json"];
                JArray questionArray = JArray.Parse(questions);
                examLectureLabel.Text = "강의명:  " + lectureName;
                examNameLabel.Text = "시험명:  " + examName;
                examPercentLabel.Text = "성적 반영 비율:  " + percent + "%";
                Console.WriteLine(questionArray);
                startDate = setTime(startTime);
                examDate = setTime(endTime);
                loadQuestions(questionArray);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
        private DateTime setTime(string time)
        {
            int year = int.Parse(time.Substring(0, 4));
            int month = int.Parse(time.Substring(5, 2));
            int day = int.Parse(time.Substring(8, 2));
            int hour = int.Parse(time.Substring(11, 2));
            int minute = int.Parse(time.Substring(14, 2));
            int sec = int.Parse(time.Substring(17, 2));

            return new DateTime(year, month, day, hour, minute, sec);
        }

        private void loadQuestions(JArray questions)
        {
            int cnt = questions.Count;
            int index = 1;

            for (int i = 0; i < cnt; i++)
            {
                JObject question = (JObject)questions[i];
                JArray subQuestions = (JArray)question["subQuestions"];
                int subCnt = subQuestions.Count;
                string mainQuestion = (string)question["question"];
                ExamMainQuestionPanel examMainQuestionPanel;
                List<ExamSubQuestionPanel> examSubQuestionPanelList = new List<ExamSubQuestionPanel>();
                for (int j = 0; j < subCnt; j++)
                {
                    int type = (int)subQuestions[j]["type"];
                    int score = (int)subQuestions[j]["score"];
                    string subQuestion = (string)subQuestions[j]["question"];
                    if (type == 0)
                    {
                        ExamOXPanel examOXPanel = new ExamOXPanel(customFonts, (index++).ToString() + ". " + subQuestion, score);
                        examSubQuestionPanelList.Add(examOXPanel);
                        if (!isStudent)
                        {
                            examOXPanel.OButton.Click -= examOXPanel.oButton_Click_1;
                            examOXPanel.XButton.Click -= examOXPanel.xButton_Click_1;
                        }
                    }
                    else if (type == 1)
                    {
                        ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = new ExamShortAnswerQuestionPanel(customFonts, (index++).ToString() + ". " + subQuestion, score);
                        examSubQuestionPanelList.Add(examShortAnswerQuestionPanel);
                        if (!isStudent)
                        {
                            examShortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.ReadOnly = true;
                        }
                        
                    }
                    else if (type == 2)
                    {
                        int maxLength = (int)subQuestions[j]["maxLength"];
                        ExamEssayQuestionPanel examEssayQuestionPanel = new ExamEssayQuestionPanel(customFonts, (index++).ToString() + ". " + subQuestion, score, maxLength);
                        examSubQuestionPanelList.Add(examEssayQuestionPanel);
                        if (!isStudent)
                        {
                            examEssayQuestionPanel.AnswerPanel.AnswerTextBox.ReadOnly = true;
                        }
                    }
                    else
                    {
                        JArray examples = (JArray)subQuestions[j]["examples"];
                        int exampleCnt = examples.Count;
                        string[] example = new string[exampleCnt];
                        for (int t = 0; t < exampleCnt; t++)
                        {
                            example[t] = (string)examples[t]["example"];
                        }
                        ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = new ExamMultipleChoiceQuestionPanel(customFonts, (index++).ToString() + ". " + subQuestion, score, example, isStudent);
                        examSubQuestionPanelList.Add(examMultipleChoiceQuestionPanel);
                    }
                }
                examMainQuestionPanel = new ExamMainQuestionPanel(customFonts, mainQuestion, examSubQuestionPanelList);
                examMainQuestionPanelList.Add(examMainQuestionPanel);
                this.examMainQuestionPanelList[i].Location = new Point(30, 30);
                this.examPanel.Controls.Add(this.examMainQuestionPanelList[i]);
                if (i != 0)
                {
                    examMainQuestionPanelList[i].Visible = false;
                }
            }

            this.examPageNavigationPanel.WholePageLabel.Text = cnt.ToString();
            this.examPageNavigationPanel.NowPageTextBox.Text = "1";
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

        private void nowPageTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void nowPageTextBox_LostFocus_1(object sender, EventArgs e)
        {
            if (this.examPageNavigationPanel.NowPageTextBox.Text == "" || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > examMainQuestionPanelList.Count || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = "1";
            }
        }

        private void nowPageTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int page = 0;
            int count = examMainQuestionPanelList.Count;

            if (this.examPageNavigationPanel.NowPageTextBox.Text == "")
                return;

            if (!this.examPageNavigationPanel.NowPageTextBox.Equals("") && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= examMainQuestionPanelList.Count && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > 0)
            {
                page = int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) - 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (page != i)
                {
                    examMainQuestionPanelList[i].Visible = false;
                }
            }
            examMainQuestionPanelList[page].Visible = true;
        }

        private void pageLeftButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;

            if (page > 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = page.ToString();
            }
        }

        private void pageRightButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            int count = examMainQuestionPanelList.Count;

            if (page < count - 1)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = (page + 2).ToString();
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {

            try
            {
                DateTime date = DateTime.Now;

                if (noticeQueue.Count > 0 && !noticePanel.Visible)
                {
                    noticePanel.showNotice(noticeQueue.Dequeue());
                }

                if (chatPanel.Visible)
                {
                    writeAllMessages();
                }
                else
                {
                    if (messageQueue.Count > 0)
                    {
                        openChatAlertPanel.Visible = true;
                        openChatAlertPanel.BringToFront();
                        openChatAlertLabel.Text = messageQueue.Count.ToString();
                    }
                    else
                    {
                        openChatAlertPanel.Visible = false;
                        openChatAlertPanel.BringToFront();
                    }
                }

                if (banQueue.Count > 0)
                {
                    changeBanStatus();
                }

                if (keyboard.Count > 0)
                {
                    keyboardLog();
                }

                double diffTotalSeconds = (examDate - date).TotalSeconds;
                if (diffTotalSeconds <= 0)
                {
                    timer.Stop();
                    timer.Dispose();
                    if (browser != null)
                    {
                        browser.Dispose();
                        browser = null;
                    }
                    UnHook();
                    examController.disconnect();
                    MessageBox.Show("시험이 종료됐습니다.", "시험 종료", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mainController.moveToPreviousForm();
                }
                setTimeLabel(diffTotalSeconds);

                (new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        if (isBaned)
                        {
                            webrtcPanel.BringToFront();
                            return;
                        }
                        DateTime now = DateTime.Now;
                        double diffSeconds = (startDate - now).TotalSeconds;

                        JavascriptResponse jr = browser.EvaluateScriptAsync(string.Format("(function() {{return getState();}})()")).Result;

                        Boolean jrResult = (Boolean)jr.Result;
                        if (jrResult)
                        {
                            if (webrtcConnectCount > 10 && diffSeconds <= 0)
                            {
                                webrtcPanel.SendToBack();
                            }
                            else
                            {
                                webrtcConnectCount++;
                            }
                        }
                        else
                        {
                            webrtcConnectCount = 0;
                            webrtcPanel.BringToFront();
                        }
                        
                        if (examController.isConnected())
                        {
                            examController.healthCheck();
                        }
                    }
                    catch (Exception error)
                    {
                        webrtcConnectCount = 0;
                        Console.WriteLine(error);
                    }
                }))).Start();
            }
            catch(Exception error)
            {
                //webrtcPanel.BringToFront();
                Console.WriteLine(error);
            }
        }

        private void keyboardLog()
        {
            (new Thread(new ThreadStart(() =>
            {
                try
                {
                    mainController.examLog("Keyboard", keyboard.Dequeue(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), room_id);
                }
                catch (Exception error)
                {
                    webrtcConnectCount = 0;
                    Console.WriteLine(error);
                }
            }))).Start();
        }

        private void changeBanStatus()
        {
            int count = banQueue.Count;

            for (int i = 0; i < count; i++)
            {
                string status = banQueue.Dequeue();

                if (status.Equals("ban"))
                {
                    isBaned = true;
                }
                else
                {
                    isBaned = false;
                }
            }
        }

        private void writeAllMessages()
        {
            while (messageQueue.Count > 0)
            {
                chatPanel.addChatContentPanel(new ChatContentPanel(customFonts, messageQueue.Dequeue(), 1));
            }
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

        private void initShortCutButton()
        {
            int index = 0, count = examMainQuestionPanelList.Count, i;
            int locationY;
            int locationX;

            for (i = 0; i < count; i++)
            {
                int subCount = examMainQuestionPanelList[i].SubQuestionPanelsList.Count;

                for (int j = 0; j < subCount; j++)
                {
                    ShortCutButton shortCutButton = new ShortCutButton(customFonts, index + 1);
                    locationY = (index / 4) * 27;
                    locationX = (index % 4) * 77;
                    this.examShortCutPanel.Controls.Add(shortCutButton);
                    this.shortCutButtonList.Add(shortCutButton);
                    shortCutButton.Location = new Point(locationX, locationY);
                    shortCutButton.MainQuestionNo = i;
                    shortCutButton.SubQuestionNo = j;
                    shortCutButton.Click += shortCutButton_Click_1;
                    index++;

                    if (!isStudent)
                    {
                        isScoredList.Add(false);
                        examMainQuestionPanelList[i].SubQuestionPanelsList[j].ExamScorePanel.ScoreTextBox.BackColor = Color.White;
                        examMainQuestionPanelList[i].SubQuestionPanelsList[j].StudentScorePanel.Visible = true;
                        examMainQuestionPanelList[i].SubQuestionPanelsList[j].StudentScorePanel.ScoreTextBox.LostFocus += ScoreTextBox_LostFocus;
                    }
                    if (isStudent)
                    {
                        ExamSubQuestionPanel examSubQuestionPanel = examMainQuestionPanelList[i].SubQuestionPanelsList[j];

                        switch (examSubQuestionPanel.Type)
                        {
                            case 0:
                                ExamOXPanel examOXPanel = (ExamOXPanel)examSubQuestionPanel;
                                examOXPanel.OButton.Click += ox_enter_answer;
                                examOXPanel.XButton.Click += ox_enter_answer;
                                break;
                            case 1:
                                ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = (ExamShortAnswerQuestionPanel)examSubQuestionPanel;
                                examShortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += short_enter_answer;
                                break;
                            case 2:
                                ExamEssayQuestionPanel examEssayQuestionPanel = (ExamEssayQuestionPanel)examSubQuestionPanel;
                                examEssayQuestionPanel.AnswerPanel.AnswerTextBox.LostFocus += essay_enter_answer;
                                break;
                            case 3:
                                ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = (ExamMultipleChoiceQuestionPanel)examSubQuestionPanel;
                                add_event_at_radiobutton(examMultipleChoiceQuestionPanel.ChoicePaneList);
                                break;
                            default: break;
                        }
                    }
                }
            }
        }

        private void ScoreTextBox_LostFocus(object sender, EventArgs e)
        {
            try
            {
                TextBox scoreTextBox = (TextBox)sender;
                string str = scoreTextBox.Text.Replace(" ", "");
                str = str.Replace("\r", "");
                str = str.Replace("\n", "");
                if (str != "")
                {
                    ScorePanel scorePanel = (ScorePanel)scoreTextBox.Parent;
                    ExamSubQuestionPanel examSubQuestionPanel = (ExamSubQuestionPanel)scorePanel.Parent;
                    int index = Find_shortCutButton_index(examSubQuestionPanel);
                    int problem_score = int.Parse(examSubQuestionPanel.ExamScorePanel.ScoreTextBox.Text);
                    int score = int.Parse(scoreTextBox.Text);
                    if (score > problem_score)
                    {
                        MessageBox.Show("문제의 최고 점수보다 높게 점수를 부여할 수 없습니다.", "점수 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        examSubQuestionPanel.StudentScorePanel.ScoreTextBox.Text = "0";
                        return;
                    }
                    setScore(index, false);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setScore(int index, Boolean isEnd)
        {
            ExamSubQuestionPanel examSubQuestionPanel = examMainQuestionPanelList[shortCutButtonList[index].MainQuestionNo].SubQuestionPanelsList[shortCutButtonList[index].SubQuestionNo];
            int score = int.Parse(examSubQuestionPanel.StudentScorePanel.ScoreTextBox.Text);
            
            string value = "";
            switch (examSubQuestionPanel.Type)
            {
                case 0:
                    ExamOXPanel examOXPanel = (ExamOXPanel)examSubQuestionPanel;
                    value = examOXPanel.Answer.ToString();
                    break;
                case 1:
                    ExamShortAnswerQuestionPanel examShortAnswerQuestionPanel = (ExamShortAnswerQuestionPanel)examSubQuestionPanel;
                    value = examShortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text;
                    break;
                case 2:
                    ExamEssayQuestionPanel examEssayQuestionPanel = (ExamEssayQuestionPanel)examSubQuestionPanel;
                    value = examEssayQuestionPanel.AnswerPanel.AnswerLabel.Text;
                    break;
                case 3:
                    ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = (ExamMultipleChoiceQuestionPanel)examSubQuestionPanel;
                    value = examMultipleChoiceQuestionPanel.Answer.ToString();
                    break;
                default: break;
            }

            isScoredList[index] = true;

            if (isEnd)
            {
                try 
                {
                    mainController.professorChangeScore(value, room_id, index + 1, student_id, score);
                }
                catch(Exception error) 
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                (new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        mainController.professorChangeScore(value, room_id, index + 1, student_id, score);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                }))).Start();
            }
        }

        private void setAllScore()
        {
            int count = isScoredList.Count;
            for (int i = 0; i < count; i++)
            {
                if (!isScoredList[i])
                {
                    setScore(i, true);
                }
            }

        }

        private void add_event_at_radiobutton(List<ExamMultipleChoicePanel> choicePanelList)
        {
            int count = choicePanelList.Count;

            for (int i = 0; i < count; i++)
            {
                choicePanelList[i].ExampleRadioButton.Click += multiple_enter_answer;
            }
        }

        private void shortCutButton_Click_1(object sender, EventArgs e)
        {
            ShortCutButton shortCutButton = (ShortCutButton)sender;
            int i = shortCutButton.MainQuestionNo;
            int j = shortCutButton.SubQuestionNo;
            int locationY;

            locationY = examMainQuestionPanelList[i].SubQuestionPanelsList[j].Location.Y;

            this.examPageNavigationPanel.NowPageTextBox.Text = (i + 1).ToString();

            try
            {
                this.examPanel.VerticalScroll.Value = locationY;
                this.examPanel.PerformLayout();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void ox_enter_answer(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ExamSubQuestionPanel examOXPanel = (ExamSubQuestionPanel)button.Parent;
            ExamOXPanel oxPanel = (ExamOXPanel)examOXPanel;
            int index = Find_shortCutButton_index(examOXPanel);

            string answer = oxPanel.Answer.ToString();
            submitAnswer(answer, index + 1);
            shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private void short_enter_answer(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ShortAnswerPanel shortAnswerPanel = (ShortAnswerPanel)textBox.Parent;
            ExamSubQuestionPanel examShortAnswerQuestionPanel = (ExamSubQuestionPanel)shortAnswerPanel.Parent;
            ExamShortAnswerQuestionPanel shortAnswerQuestionPanel = (ExamShortAnswerQuestionPanel)examShortAnswerQuestionPanel;
            int index = Find_shortCutButton_index(examShortAnswerQuestionPanel);

            if (textBox.Visible == true)
                shortCutButtonList[index].BackColor = Color.White;
            else
            {
                submitAnswer(shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text, index + 1);
                shortCutButtonList[index].BackColor = Color.GreenYellow;
            }
        }

        private void essay_enter_answer(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            EssayAnswerPanel essayAnswerPanel = (EssayAnswerPanel)textBox.Parent;
            ExamSubQuestionPanel examEssayQuestionPanel = (ExamSubQuestionPanel)essayAnswerPanel.Parent;
            ExamEssayQuestionPanel essayQuestionPanel = (ExamEssayQuestionPanel)examEssayQuestionPanel;
            int index = Find_shortCutButton_index(examEssayQuestionPanel);

            if (textBox.Visible == true)
                shortCutButtonList[index].BackColor = Color.White;
            else
            {
                submitAnswer(essayQuestionPanel.AnswerPanel.AnswerLabel.Text, index + 1);
                shortCutButtonList[index].BackColor = Color.GreenYellow;
            }
        }

        private void multiple_enter_answer(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            ExamMultipleChoicePanel multipleChoicePanel = (ExamMultipleChoicePanel)radioButton.Parent;
            ExamSubQuestionPanel multipleChoiceQuestionPanel = (ExamSubQuestionPanel)multipleChoicePanel.Parent;
            ExamMultipleChoiceQuestionPanel examMultipleChoiceQuestionPanel = (ExamMultipleChoiceQuestionPanel)multipleChoiceQuestionPanel;
            int index = Find_shortCutButton_index(multipleChoiceQuestionPanel);

            submitAnswer(examMultipleChoiceQuestionPanel.Answer.ToString(), index + 1);
            shortCutButtonList[index].BackColor = Color.GreenYellow;
        }

        private int Find_shortCutButton_index(ExamSubQuestionPanel examSubQuestionPanel)
        {
            int index = 0;
            int count = examMainQuestionPanelList.Count;

            for (int i = 0; i < count; i++)
            {
                int subCount = examMainQuestionPanelList[i].SubQuestionPanelsList.Count;
                for (int j = 0; j < subCount; j++)
                {
                    if (examMainQuestionPanelList[i].SubQuestionPanelsList[j] == examSubQuestionPanel)
                    {
                        return index;
                    }

                    index++;
                }
            }

            return -1;
        }
        private void openChatBoxPanel_Click_1(object sender, EventArgs e)
        {
            openChatAlertPanel.Visible = false;
            openChatBoxPanel.Visible = false;
            writeAllMessages();
            chatPanel.Visible = true;
            chatPanel.BringToFront();
        }

        private void chatPanelMinimizeButton_Click_1(object sender, EventArgs e)
        {
            openChatBoxPanel.Visible = true;
            chatPanel.Visible = false;
        }

        private void endExamButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isStudent)
                { 
                    if (MessageBox.Show("시험을 종료하시겠습니까?", "시험 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        timer.Stop();
                        examController.disconnect();
                        UnHook();
                        if (browser != null)
                        {
                            browser.Dispose();
                            browser = null;
                        }
                        mainController.moveToPreviousForm();
                    }
                }
                else
                {
                    setAllScore();
                    mainController.moveToPreviousForm();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void submitAnswer(string answer, int num)
        {
            if (!isStudent) return;
            (new Thread(new ThreadStart(() =>
            {
                try
                {
                    string response = mainController.studentAddAnswer(room_id, answer, num);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }))).Start();
        }

        public void SetHook()
        {
            KillCtrlAltDelete();
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            EnableCtrlAltDel();
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            // 이상하게 왼쪽 ALT 키 wParam이 다르게 찍혀서 후킹이 안됨.
            // WM_KEYDOWN 이 256이고 떼는게 257인거 같은데
            // 다른 키들은 누르면 256 잘 뜨는데 왼쪽 ALT 키 누르면 260이 뜸 뭐지?
            // 일단 왼쪽 ALT키 값은 164


            int vkCode = Marshal.ReadInt32(lParam);
            //Console.WriteLine(vkCode);

            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)260)
            {
                IntPtr intPtr = (IntPtr)0;
                string key = "";
                // CTRL
                if (vkCode == 162 || vkCode == 25)
                {
                    Console.WriteLine("컨트롤키");
                    key = "Ctrl";
                    intPtr = (IntPtr)1;
                }

                // SHIFT
                else if (vkCode == 160 || vkCode == 161) Console.WriteLine("시프트키");

                // TAB
                else if (vkCode == 9)
                {
                    Console.WriteLine("탭키");
                    key = "Tab";
                    intPtr = (IntPtr)1;
                }

                // 왼쪽 ALT
                else if (vkCode == 164)
                {
                    Console.WriteLine("알트키");
                    key = "Alt";
                    intPtr = (IntPtr)1;
                }

                // 우측 ALT, 한/영
                else if (vkCode == 21)
                {
                    Console.WriteLine("한/영키");
                }

                // Windows
                else if (vkCode == 91)
                {
                    Console.WriteLine("Windows키");
                    key = "Window";
                    intPtr = (IntPtr)1;
                }

                // print screen
                else if (vkCode == 44)
                {
                    Console.WriteLine("프린트스크린키");
                    key = "PrtSc";
                    intPtr = (IntPtr)1;
                }

                // 메뉴키
                else if (vkCode == 93)
                {
                    Console.WriteLine("메뉴키");
                    MessageBox.Show("사용할 수 없습니다");
                    key = "Window";
                    intPtr = (IntPtr)1;
                }

                if (intPtr == (IntPtr)1)
                {
                    keyboard.Enqueue(key);
                    return intPtr;
                }

                // 32 스페이스바
                if (vkCode == 32) Console.WriteLine("스페이스키");

                // 8 백스페이스
                else if (vkCode == 8) Console.WriteLine("백스페이스키");

                // 27 esc
                else if (vkCode == 27) Console.WriteLine("ESC키");

                // 115 f4
                else if (vkCode == 115) Console.WriteLine("F4키");

                // 13 엔터
                else if (vkCode == 13) Console.WriteLine("Enter키");

                // 37 좌화살표
                else if (vkCode == 37) Console.WriteLine("좌화살표키");

                // 38 위화살표
                else if (vkCode == 38) Console.WriteLine("위화살표키");

                // 39 우화살표
                else if (vkCode == 39) Console.WriteLine("우화살표키");

                // 40 아래화살표
                else if (vkCode == 40) Console.WriteLine("아래화살표키");

                // 46 del키
                else if (vkCode == 46) Console.WriteLine("Delete키");

                // 45 insert키
                else if (vkCode == 45) Console.WriteLine("Insert키");

                // 36 home키
                else if (vkCode == 36) Console.WriteLine("Home키");

                // 35 end키
                else if (vkCode == 35) Console.WriteLine("End키");

                return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        private void ExamView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isStudent)
            {
                UnHook();
                processController.StopTimer();
                disconnectWebsocket();
            }
        }

        //Ctrl + Alt + Delete 막기
        public static void KillCtrlAltDelete()
        {
            RegistryKey regkey;
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                //regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
            }
        }

        public static void EnableCtrlAltDel()
        {
            try
            {
                string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
                RegistryKey rk = Registry.CurrentUser;
                RegistryKey sk1 = rk.OpenSubKey(subKey);

                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                // MessageBox.Show(ex.ToString());
            }
        }

        private void chatPanelSendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str = chatPanel.InputTextBox.Text.Replace(" ", "");
                str = str.Replace("\r", "");
                str = str.Replace("\n", "");
                if (str != "")
                {
                    examController.studentSendMessage(chatPanel.InputTextBox.Text);
                    chatPanel.addChatContentPanel(new ChatContentPanel(customFonts, chatPanel.InputTextBox.Text, 0));
                    chatPanel.InputTextBox.Text = "";
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
