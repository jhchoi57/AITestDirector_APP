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
using CefSharp;
using CefSharp.WinForms;
using LibVLCSharp.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Controller;
using program.View.Components;

namespace program.View
{
    public partial class BookMarkView : Form
    {
        private string student_name;
        private string student_id;
        private string room_id;
        private MainController mainController;
        private TopBarPanel topBarPanel;
        private Boolean status;
        private DateTime startTime;
        private LibVLCSharp.Shared.LibVLC libVLC;
        private LibVLCSharp.WinForms.VideoView videoView;

        public BookMarkView(MainController mainController, string student_id, string room_id, string student_name)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
            this.student_id = student_id;
            this.room_id = room_id;
            this.student_name = student_name;
        }

        private void VideoView_Load(object sender, EventArgs e)
        {
            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            status = false;

            bookMarkLbl.Font = customFonts.SubTitleFont();
            exitBtn.Font = customFonts.TextBoxFont();
            bookMarkTable.Font = customFonts.NormalFont();


            // 이미지
            bookMarkPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bookMarkPictureBox.Image = System.Drawing.Image.FromFile("./src/Assets/Images/face.png");

            // 상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            // 테이블 Sample
            /*
            bookMarkTable.Rows.Add("가나다", "2020-11-29 15:55:56", "음성?");
            bookMarkTable.Rows.Add("가나다", "2020-11-29 15:58:56", "화면에 다른 사람?");
            bookMarkTable.Rows.Add("가나다", "2020-11-29 15:59:56", "시선 이탈?");
            string time = "2020-11-29 15-54-18";
            startTime = setTime(time);
            
            //initBookmarkVideo();

            try
            {
                Core.Initialize();
                libVLC = new LibVLCSharp.Shared.LibVLC();
                videoView = new LibVLCSharp.WinForms.VideoView();
                videoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libVLC);
                videoView.MediaPlayer.Play(new Media(libVLC, "http://localhost:8080/2020-11-29_15-54-18_28b1d3f4-ec2c-4787-a187-a2e4a91bc630.mp4", FromType.FromLocation));
                bookMarkPanel.Controls.Add(videoView);
                videoView.BringToFront();
                videoView.Dock = DockStyle.Fill;
                status = true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            */

            bookMarkTable.ScrollBars = ScrollBars.Vertical;
            
            loadStudentBookMark();
            loadStudentExamVideo();
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

        private void loadStudentExamVideo()
        {
            try
            {
                string response = mainController.professorGetStudentExamVideo(room_id, student_id);
                JArray jArray = (JArray)JsonConvert.DeserializeObject(response);
                Console.WriteLine(jArray);

                int count = jArray.Count;

                if (count > 0)
                {
                    string url = (string)jArray[0]["url"];
                    string started_at = (string)jArray[0]["started_at"];

                    startTime = setTime(started_at);

                    Core.Initialize();
                    libVLC = new LibVLCSharp.Shared.LibVLC();
                    videoView = new LibVLCSharp.WinForms.VideoView();
                    videoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libVLC);
                    videoView.MediaPlayer.Play(new Media(libVLC, url, FromType.FromLocation));
                    videoView.MediaPlayer.EndReached += MediaPlayer_EndReached;
                    bookMarkPanel.Controls.Add(videoView);
                    videoView.BringToFront();
                    videoView.Dock = DockStyle.Fill;
                    status = true;
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private void MediaPlayer_EndReached(object sender, EventArgs e)
        {
            status = false;  
        }

        private void loadStudentBookMark()
        {
            (new Thread(new ThreadStart(() =>
            {
                try
                {
                    string response = mainController.professorGetStudentExamBookmark(room_id, student_id);
                    JArray jArray = (JArray)JsonConvert.DeserializeObject(response);

                    int count = jArray.Count;

                    for (int i = 0; i < count; i++)
                    {
                        string doubt = (string)jArray[i]["source"];
                        string detected_at = (string)jArray[i]["detected_at"];

                        bookMarkTable.Rows.Add(student_id, student_name, detected_at, doubt);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }))).Start();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (videoView != null)
            {
                videoView.MediaPlayer.Dispose();
                videoView.Dispose();
            }
            mainController.moveToPreviousForm();
        }

        private void bookMarkTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                string time = bookMarkTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                DateTime doubtTime = setTime(time);
                Console.WriteLine(doubtTime + ", " + startTime);
                long diffTotalMilliSeconds = (long)(doubtTime - startTime).TotalMilliseconds;
                if (diffTotalMilliSeconds - 1000 < 0)
                {
                    diffTotalMilliSeconds = 0;
                }
                else
                {
                    diffTotalMilliSeconds -= 1000;
                }
                Console.WriteLine(diffTotalMilliSeconds);

                videoView.MediaPlayer.Time = diffTotalMilliSeconds;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
