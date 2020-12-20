using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class StudentWebRTCPanel : Panel
    {
        private ChromiumWebBrowser browser;
        private Panel webrtcPanel;
        private Panel infoPanel;
        private Label infoLabel;
        private Button statusButton { get; set; }
        private Boolean isBaned { get; set; }
        private int timeCount { get; set; }
        private string student_id { get; set; }
        private string room_id;
        public string Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }
        public int TimeCount
        {
            get { return timeCount; }
            set { timeCount = value; }
        }
        public Boolean IsBaned
        {
            get { return isBaned; }
            set { isBaned = value; }
        }
        public Button StatusButton
        {
            get { return statusButton; }
            set { statusButton = value; }
        }
        public StudentWebRTCPanel(CustomFonts customFonts, string student_id, string student_name, string room_id)
        {
            this.timeCount = 0;
            this.student_id = student_id;
            this.room_id = room_id;

            webrtcPanel = new Panel();
            infoPanel = new Panel();
            infoLabel = new Label();
            statusButton = new Button();

            this.Size = new Size(300, 230);
            this.Controls.Add(webrtcPanel);
            this.Controls.Add(infoPanel);

            webrtcPanel.Size = new Size(296, 198);
            webrtcPanel.Location = new Point(2, 2);

            initwebrtc();

            infoPanel.Size = new Size(296, 28);
            infoPanel.Location = new Point(2, 200);
            infoPanel.BackColor = Color.White;
            infoPanel.Controls.Add(infoLabel);
            infoPanel.Controls.Add(statusButton);

            infoLabel.Size = new Size(230, 20);
            infoLabel.Location = new Point(5, 5);
            infoLabel.Text = student_id + " " + student_name;
            infoLabel.Font = customFonts.TextBoxFont();

            statusButton.Size = new Size(40, 22);
            statusButton.Location = new Point(248, 3);
            statusButton.Font = customFonts.SmallFont();
            statusButton.Text = "제 한";
            statusButton.ForeColor = Color.White;
            statusButton.BackColor = Color.DarkGray;
            statusButton.FlatAppearance.BorderSize = 0;
            statusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            isBaned = false;
        }

        private void initwebrtc()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            if (!Cef.IsInitialized) Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("https://test.inchang.dev:10001/?mode=receiver&autoStart=true&userId=" + student_id + "&roomId=" + room_id);
            browser.Dock = DockStyle.Fill;
            this.webrtcPanel.Controls.Add(browser);
        }

        public void disconnectBrowser()
        {
            if (browser != null)
            {
                browser.Dispose();
                browser = null;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        public void setButtonText()
        {
            if (isBaned)
            {
                statusButton.Text = "참 여";
            }
            else
            {
                statusButton.Text = "제 한";
            }
        }

        public void setDifferentPersonColor()
        {
            infoPanel.BackColor = Color.Black;
            infoLabel.ForeColor = Color.White;
            this.timeCount = 1;
        }

        public void setNoPersonDoubtColor()
        {
            infoPanel.BackColor = Color.HotPink;
            infoLabel.ForeColor = Color.White;
            this.timeCount = 1;
        }

        public void setFaceDoubtColor()
        {
            infoPanel.BackColor = Color.Purple;
            infoLabel.ForeColor = Color.White;
            this.timeCount = 1;
        }
        public void setGazeDoubtColor()
        {
            infoPanel.BackColor = Color.Yellow;
            infoLabel.ForeColor = Color.Black;
            this.timeCount = 1;
        }

        public void setSoundDoubtColor()
        {
            infoPanel.BackColor = Color.OrangeRed;
            infoLabel.ForeColor = Color.White;
            this.timeCount = 1;
        }

        public void setNormalColor()
        {
            infoPanel.BackColor = Color.White;
            infoLabel.ForeColor = Color.Black;
            this.timeCount = 0;
        }
    }
}
