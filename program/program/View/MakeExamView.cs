using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class MakeExamView : Form
    {
        private CustomFonts customFonts;
        private MainController mainController;
        private List<MainQuestionPanel> mainQuestionPanelList;
        private List<ShortCutButton> shortCutButtonList;
        private int questionCount;
        private string room_id;

        public MakeExamView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
            this.mainController = mainController;
            this.room_id = "";
        }

        public MakeExamView(MainController mainController, string room_id)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 화면 크기 모니터 해상도에 맞춤
            //this.WindowState = FormWindowState.Maximized;
            this.mainController = mainController;
            this.room_id = room_id;
        }

        private void MakeExamView_Load1(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();
            
            initFont();
            initLectureComboBox();

            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            this.examPageNavigationPanel = new ExamPageNavigationPanel(customFonts);
            this.examPageNavigationPanel.Location = new System.Drawing.Point(0, 612);
            this.mainPanel.Controls.Add(this.examPageNavigationPanel);
            
            this.examPageNavigationPanel.PageLeftButton.Click += pageLeftButton_Click_1;
            this.examPageNavigationPanel.PageRightButton.Click += pageRightButton_Click_1;
            this.examPageNavigationPanel.NowPageTextBox.KeyPress += nowPageTextBox_KeyPress_1;
            this.examPageNavigationPanel.NowPageTextBox.LostFocus += nowPageTextBox_LostFocus_1;
            this.examPageNavigationPanel.NowPageTextBox.TextChanged += nowPageTextBox_TextChanged_1;
            this.examPageNavigationPanel.AddPageButton.Click += addPageButton_Click_1;
            this.examPageNavigationPanel.RemovePageButton.Click += removePageButton_Click_1;

            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;

            this.saveButton.Click += saveButton_Click_1;
            this.cancelButton.Click += cancelButton_Click_1;

            this.examPercentTextBox.KeyPress += percentTextBox_KeyPress_1;

            this.mainQuestionPanelList = new List<MainQuestionPanel>();
            this.shortCutButtonList = new List<ShortCutButton>();

            questionCount = 0;
            if (room_id == "")
            {
                this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
                this.mainQuestionPanelList[0].Location = new Point(30, 30);
                this.mainQuestionPanelList[0].AddQuestionButton.Click += addSubQuestionButton_Click;
                this.examPanel.Controls.Add(this.mainQuestionPanelList[0]);
            }
            else
            {
                setSavedExam();
            }
        }

        private void setSavedExam()
        {
            try
            {
                string response = mainController.getExamRequest(room_id);
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                string lectureID = (string)jObject["lecture"];
                string startTime = (string)jObject["start_at"];
                string endTime = (string)jObject["finish_at"];
                string examName = (string)jObject["exam_name"];
                int percent = (int)jObject["score_rate"];
                string qJson = (string)jObject["questions_json"];
                JArray questions = JArray.Parse(qJson);

                //Console.WriteLine(questions);
                setExamSettingPanel(lectureID, examName, percent.ToString(), startTime, endTime);

                response = mainController.professorGetAllAnswer(room_id);
                JArray answers = (JArray)JsonConvert.DeserializeObject(response);
                //Console.WriteLine(answers);

                setSavedQuestions(questions, answers);
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void setExamSettingPanel(string lectureID, string examName, string percent, string startTime, string endTime)
        {
            int cnt = mainController.Me.Lectures.Count;

            for(int i = 0; i < cnt; i++)
            {
                if(mainController.Me.Lectures[i].ID.Equals(lectureID))
                {
                    examLectureNameComboBox.SelectedIndex = i;
                    break;
                }
            }

            examNameTextBox.Text = examName;
            examPercentTextBox.Text = percent;
            setTimePicker(startDateTimePicker, startTime);
            setTimePicker(endDateTimePicker, endTime);

        }

        private void setTimePicker(DateTimePicker picker, string time)
        {
            int year = int.Parse(time.Substring(0, 4));
            int month = int.Parse(time.Substring(5, 2));
            int day = int.Parse(time.Substring(8, 2));
            int hour = int.Parse(time.Substring(11, 2));
            int minute = int.Parse(time.Substring(14, 2));
            int sec = int.Parse(time.Substring(17, 2));

            picker.Value = new DateTime(year, month, day, hour, minute, sec);
        }

        private void setSavedQuestions(JArray questions, JArray answers)
        {
            int index = 0;
            int cnt = questions.Count;
            
            for (int i = 0; i < cnt; i++)
            {
                string mainQuestion = (string)questions[i]["question"];
                this.examPageNavigationPanel.AddPageButton.PerformClick();
                mainQuestionPanelList[i].MainQuestionLabel.Text = mainQuestion;
                mainQuestionPanelList[i].MainQuestionTextBox.Text = mainQuestion;
                mainQuestionPanelList[i].MainQuestionLabel.Visible = true;
                mainQuestionPanelList[i].MainQuestionTextBox.Visible = false;
                JArray subQuestions = (JArray)questions[i]["subQuestions"];
                int subCnt = (int)subQuestions.Count;
                for (int j = 0; j < subCnt; j++)
                {
                    int type = (int)subQuestions[j]["type"];
                    int score = (int)answers[index]["score"];
                    string answer = (string)answers[index]["answer"];
                    string subQuestion = (string)subQuestions[j]["question"];
                    mainQuestionPanelList[i].QuestionKind.QuestionKindComboBox.SelectedIndex = type;
                    mainQuestionPanelList[i].AddQuestionButton.PerformClick();
                    SubQuestionPanel subQuestionPanel = mainQuestionPanelList[i].SubQuestionPanelsList[j];
                    subQuestionPanel.QuestionLabel.Text = subQuestion;
                    subQuestionPanel.QuestionTextBox.Text = subQuestion;
                    subQuestionPanel.QuestionLabel.Visible = true;
                    subQuestionPanel.QuestionTextBox.Visible = false;
                    subQuestionPanel.ExamScorePanel.ScoreTextBox.Text = score.ToString();
                    if (type == 0)
                    {
                        OXPanel oxPanel = (OXPanel)subQuestionPanel;
                        if (answer == "1")
                        {
                            oxPanel.OButton.PerformClick();
                        }
                        else
                        {
                            oxPanel.XButton.PerformClick();
                        }
                        oxPanel.setLayout();
                    }
                    else if (type == 1)
                    {
                        ShortAnswerQuestionPanel shortAnswerQuestionPanel = (ShortAnswerQuestionPanel)subQuestionPanel;
                        shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text = answer;
                        shortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.Text = answer;
                        if (!answer.Equals(""))
                        {
                            shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Visible = true;
                            shortAnswerQuestionPanel.AnswerPanel.AnswerTextBox.Visible = false;
                        }
                        shortAnswerQuestionPanel.setLayout();
                    }
                    else if (type == 2)
                    {
                        EssayQuestionPanel essayQuestionPanel = (EssayQuestionPanel)subQuestionPanel;
                        int maxLength = (int)subQuestions[j]["maxLength"];
                        essayQuestionPanel.AnswerPanel.AnswerTextBox.MaxLength = maxLength;
                        essayQuestionPanel.AnswerPanel.MaxLengthTextBox.Text = maxLength.ToString();
                        essayQuestionPanel.AnswerPanel.AnswerLabel.Text = answer;
                        essayQuestionPanel.AnswerPanel.AnswerTextBox.Text = answer;
                        if (!answer.Equals(""))
                        {
                            essayQuestionPanel.AnswerPanel.AnswerLabel.Visible = true;
                            essayQuestionPanel.AnswerPanel.AnswerTextBox.Visible = false;
                        }
                        essayQuestionPanel.setLayout();
                    }
                    else
                    {
                        MultipleChoiceQuestionPanel multipleChoiceQuestionPanel = (MultipleChoiceQuestionPanel)subQuestionPanel;
                        JArray examples = (JArray)subQuestions[j]["examples"];
                        int len = examples.Count;

                        for (int t = 0; t < len; t++)
                        {
                            string example = (string)examples[t]["example"];
                            multipleChoiceQuestionPanel.AddButton.PerformClick();
                            multipleChoiceQuestionPanel.ChoicePaneList[t].ExampleLabel.Text = example;
                            multipleChoiceQuestionPanel.ChoicePaneList[t].ExampleTextBox.Text = example;
                            multipleChoiceQuestionPanel.ChoicePaneList[t].ExampleLabel.Visible = true;
                            multipleChoiceQuestionPanel.ChoicePaneList[t].ExampleTextBox.Visible = false;
                        }
                        multipleChoiceQuestionPanel.ChoicePaneList[int.Parse(answer)].ExampleRadioButton.PerformClick();
                        multipleChoiceQuestionPanel.setLayout();
                    }
                    index++;
                }
            }
        }

        private void initFont()
        {
            this.examNameLabel.Font = customFonts.LabelFont();
            this.examNameTextBox.Font = customFonts.TextBoxFont();
            this.examLectureNameLabel.Font = customFonts.LabelFont();
            this.examLectureNameComboBox.Font = customFonts.LabelFont();
            this.examPercentLabel.Font = customFonts.LabelFont();
            this.examPercentLabel2.Font = customFonts.LabelFont();
            this.examPercentTextBox.Font = customFonts.TextBoxFont();
            this.examPeriodLabel.Font = customFonts.LabelFont();
            this.startDateTimePicker.Font = customFonts.TextBoxFont();
            this.endDateTimePicker.Font = customFonts.TextBoxFont();
            this.startDateTimeLabel.Font = customFonts.TextBoxFont();
            this.endDateTimeLabel.Font = customFonts.TextBoxFont();
            this.saveButton.Font = customFonts.LabelFont();
            this.cancelButton.Font = customFonts.LabelFont();
            this.examShortCutLabel.Font = customFonts.LabelFont();
        }

        private void initLectureComboBox()
        {
            int cnt = mainController.Me.Lectures.Count;
            string[] lectureItems = new string[cnt];

            for (int i = 0; i < cnt; i++)
            {
                lectureItems[i] = mainController.Me.Lectures[i].Name;
            }

            this.examLectureNameComboBox.Items.AddRange(lectureItems);
            this.examLectureNameComboBox.SelectedIndex = 0;
        }

        // 메인 문제 페이지 추가 버튼
        private void addPageButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;
            this.examPanel.VerticalScroll.Value = 0;
            this.examPanel.PerformLayout();
            this.mainQuestionPanelList.Add(new MainQuestionPanel(customFonts));
            this.mainQuestionPanelList[count].Location = new Point(30, 30);
            this.mainQuestionPanelList[count].AddQuestionButton.Click += addSubQuestionButton_Click;
            this.examPanel.Controls.Add(this.mainQuestionPanelList[count]);
            this.examPageNavigationPanel.WholePageLabel.Text = (count + 1).ToString();
            this.examPageNavigationPanel.NowPageTextBox.Text = (count + 1).ToString();
        }

        // 현재 메인 문제 페이지 삭제 버튼
        private void removePageButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;

            if (count == 1)
            {
                MessageBox.Show("문제 페이지는 하나 이상 존재해야합니다.", "문제 페이지");
                return;
            }

            if (MessageBox.Show("문제 페이지를 정말 삭제하시겠습니까?", "문제 페이지 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
                this.examPanel.Controls.Remove(mainQuestionPanelList[page]);
                mainQuestionPanelList.Remove(mainQuestionPanelList[page]);

                examPageNavigationPanel.NowPageTextBox.Text = "1";
                examPageNavigationPanel.WholePageLabel.Text = (count - 1).ToString();
            }
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
            if (this.examPageNavigationPanel.NowPageTextBox.Text == "" || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > mainQuestionPanelList.Count || int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= 0)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = "1";
            }
        }

        private void nowPageTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int page = 0;
            int count = mainQuestionPanelList.Count;

            if (this.examPageNavigationPanel.NowPageTextBox.Text == "")
                return;

            if(!this.examPageNavigationPanel.NowPageTextBox.Equals("") && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) <= mainQuestionPanelList.Count && int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) > 0)
            {
                page = int.Parse(this.examPageNavigationPanel.NowPageTextBox.Text) - 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (page != i)
                {
                    mainQuestionPanelList[i].Visible = false;
                }
            }
            mainQuestionPanelList[page].Visible = true;
        }

        private void pageLeftButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;

            if (page > 0 )
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = page.ToString();
            }
        }

        private void pageRightButton_Click_1(object sender, EventArgs e)
        {
            int page = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            int count = mainQuestionPanelList.Count;

            if (page < count - 1)
            {
                this.examPageNavigationPanel.NowPageTextBox.Text = (page + 2).ToString();
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count;
            JArray jProblemArray = new JArray();
            JArray jAnswerArray = new JArray();
            int num = 0;

            for (int i = 0; i < count; i++)
            {
                List<SubQuestionPanel> subQuestionPanelList = mainQuestionPanelList[i].SubQuestionPanelsList;
                int cnt = subQuestionPanelList.Count;
                JObject mainJObject = new JObject();
                JArray subArray = new JArray();
                if (mainQuestionPanelList[i].MainQuestionLabel.Text == "")
                {
                    MessageBox.Show((i + 1).ToString() + "번 페이지의 문제 유형을 적어주세요.", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    examPageNavigationPanel.NowPageTextBox.Text = (i + 1).ToString();
                    return;
                }
                mainJObject.Add("question", mainQuestionPanelList[i].MainQuestionLabel.Text);
                for (int j = 0; j < cnt; j++)
                {
                    int type = subQuestionPanelList[j].Type;
                    JObject jObject = new JObject();
                    jObject.Add("type", type);
                    jObject.Add("num", num + 1);
                    jObject.Add("score", int.Parse(subQuestionPanelList[j].ExamScorePanel.ScoreTextBox.Text));
                    JObject answerJObject = new JObject();
                    answerJObject.Add("num", num + 1);
                    answerJObject.Add("score", int.Parse(subQuestionPanelList[j].ExamScorePanel.ScoreTextBox.Text));
                    
                    if (subQuestionPanelList[j].QuestionLabel.Text == "")
                    {
                        MessageBox.Show("문제를 작성해주세요. (" + (num + 1).ToString() + "번 문제)", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        shortCutButtonList[num].PerformClick();
                        return;
                    }

                    jObject.Add("question", subQuestionPanelList[j].QuestionLabel.Text);
                    if (type == 0)
                    {
                        OXPanel oxPanel = (OXPanel)subQuestionPanelList[j];
                        answerJObject.Add("answer", oxPanel.Answer);
                        answerJObject.Add("type", "Choice");
                    }
                    else if (type == 1)
                    {
                        ShortAnswerQuestionPanel shortAnswerQuestionPanel = (ShortAnswerQuestionPanel)subQuestionPanelList[j];
                        answerJObject.Add("answer", shortAnswerQuestionPanel.AnswerPanel.AnswerLabel.Text);
                        answerJObject.Add("type", "Text");
                    }
                    else if (type == 2)
                    {
                        EssayQuestionPanel essayQuestionPanel = (EssayQuestionPanel)subQuestionPanelList[j];
                        answerJObject.Add("answer", essayQuestionPanel.AnswerPanel.AnswerLabel.Text);
                        answerJObject.Add("type", "Essay");
                        jObject.Add("maxLength", int.Parse(essayQuestionPanel.AnswerPanel.MaxLengthTextBox.Text));
                    }
                    else
                    {
                        MultipleChoiceQuestionPanel multipleChoiceQuestionPanel = (MultipleChoiceQuestionPanel)subQuestionPanelList[j];
                        List<MultipleChoicePanel> multipleChoicePanelList = multipleChoiceQuestionPanel.ChoicePaneList;
                        int len = multipleChoicePanelList.Count;
                        if (len == 0)
                        {
                            MessageBox.Show("객관식 문제는 보기가 반드시 필요합니다. (" + (num + 1).ToString() + "번 문제)", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            shortCutButtonList[num].PerformClick();
                            return;
                        }
                        else if (multipleChoiceQuestionPanel.Answer == -1)
                        {
                            MessageBox.Show("객관식 문제의 정답은 반드시 필요합니다. (" + (num + 1).ToString() + "번 문제)", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            shortCutButtonList[num].PerformClick();
                            return;
                        }
                        JArray examples = new JArray();
                        for (int t = 0; t < len; t++)
                        {
                            JObject example = new JObject();
                            example.Add("example", multipleChoicePanelList[t].ExampleLabel.Text);
                            examples.Add(example);
                        }
                        jObject.Add("examples", examples);
                        answerJObject.Add("answer", multipleChoiceQuestionPanel.Answer);
                        answerJObject.Add("type", "Choice");
                    }
                    subArray.Add(jObject);
                    jAnswerArray.Add(answerJObject);
                    num++;
                }
                mainJObject.Add("subQuestions", subArray);
                if (cnt > 0)
                {
                    jProblemArray.Add(mainJObject);
                }
            }
            if (num == 0)
            {
                MessageBox.Show("하나 이상의 문제를 출제하셔야 합니다.", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Console.WriteLine(jProblemArray);
            //Console.WriteLine(jAnswerArray);
            makeExam(jProblemArray, jAnswerArray);
        }

        private void addSubQuestionButton_Click(object sender, EventArgs e)
        {
            int locationX, locationY;
            int nowPageIndex;
            ShortCutButton shortCutButton = new ShortCutButton(customFonts, questionCount + 1);
            locationY = (questionCount / 4) * 27;
            locationX = (questionCount % 4) * 77;
            this.examShortCutPanel.Controls.Add(shortCutButton);
            this.shortCutButtonList.Add(shortCutButton);
            shortCutButton.Location = new Point(locationX, locationY);
            nowPageIndex = int.Parse(examPageNavigationPanel.NowPageTextBox.Text) - 1;
            shortCutButton.MainQuestionNo = nowPageIndex;
            shortCutButton.SubQuestionNo = mainQuestionPanelList[nowPageIndex].SubQuestionPanelsList.Count - 1;
            mainQuestionPanelList[nowPageIndex].SubQuestionPanelsList[shortCutButton.SubQuestionNo].DeleteButton.Click += removeSubQuestionButton_Click;
            shortCutButton.Click += shortCutButton_Click_1;
            questionCount++;
        }

        private void removeSubQuestionButton_Click(object sender, EventArgs e)
        {
            int count = mainQuestionPanelList.Count, i;
            int locationY;
            int locationX;
            int index = 0;

            for (i = 0; i < count; i++)
            {
                int subCount = mainQuestionPanelList[i].SubQuestionPanelsList.Count;

                for (int j = 0; j < subCount; j++)
                {
                    ShortCutButton shortCutButton = this.shortCutButtonList[index];
                    locationY = (index / 4) * 27;
                    locationX = (index % 4) * 77;
                    shortCutButton.Location = new Point(locationX, locationY);
                    shortCutButton.MainQuestionNo = i;
                    shortCutButton.SubQuestionNo = j;
                    index++;
                }
            }

            for (i = index; i < questionCount; i++)
            {
                this.examShortCutPanel.Controls.Remove(this.shortCutButtonList[i]);
                this.shortCutButtonList.RemoveAt(i);
            }
            questionCount = index;
        }

        private void shortCutButton_Click_1(object sender, EventArgs e)
        {
            ShortCutButton shortCutButton = (ShortCutButton)sender;
            int i = shortCutButton.MainQuestionNo;
            int j = shortCutButton.SubQuestionNo;
            int locationY;

            locationY = mainQuestionPanelList[i].SubQuestionPanelsList[j].Location.Y;
            //Console.WriteLine("Click" + i.ToString() + "," + j.ToString() + ", " + locationY.ToString());
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
        private void percentTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void makeExam(JArray problems, JArray answers)
        {
            int index = examLectureNameComboBox.SelectedIndex;
            string name = examNameTextBox.Text;
            string percent = examPercentTextBox.Text;
            string startTime = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = endDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            int totalScore = getTotalScore();

            if (name == "")
            {
                MessageBox.Show("시험명은 반드시 필요합니다.\nex) 중간고사, 기말고사, 퀴즈1 등", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (percent == "")
            {
                MessageBox.Show("시험 반영 비율은 반드시 필요합니다.\nex) 10, 15, 30 등", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (startTime.CompareTo(endTime) >= 0)
            {
                MessageBox.Show("시험 종료 시간은 반드시 시험 시작 시간보다 늦어야합니다.", "출제 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (room_id == "")
                {
                    string response = mainController.professorAddExamRequest(mainController.Me.Lectures[index].ID, startTime, endTime, name, int.Parse(percent), problems, answers);
                    mainController.moveToPreviousForm();
                }
                else
                {
                    string response = mainController.professorRemoveAllAnswer(room_id);
                    JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                    string code = (string)jObject["CODE"];
                    if (code.Equals("OK"))
                    {
                        response = mainController.professorModifyExamRequest(room_id, mainController.Me.Lectures[index].ID, startTime, endTime, name, int.Parse(percent), problems, answers);
                        mainController.moveToPreviousForm();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private int getTotalScore()
        {
            int cnt = mainQuestionPanelList.Count;
            int totalScore = 0;

            for (int i = 0; i < cnt; i++)
            {
                totalScore += int.Parse(mainQuestionPanelList[i].TotalScorePanel.ScoreTextBox.Text);
            }
            return totalScore;
        }
    }
}
