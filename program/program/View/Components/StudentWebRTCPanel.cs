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
        private string student_id { get; set; }
        private string room_id;
        public string Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }
        public StudentWebRTCPanel(CustomFonts customFonts, string student_id, string student_name, string room_id)
        {
            this.student_id = student_id;
            this.room_id = room_id;

            webrtcPanel = new Panel();
            infoPanel = new Panel();
            infoLabel = new Label();

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

            infoLabel.Size = new Size(260, 20);
            infoLabel.Location = new Point(5, 5);
            infoLabel.Text = student_id + " " + student_name;
            infoLabel.Font = customFonts.TextBoxFont();
        }

        private void initwebrtc()
        {
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            if (!Cef.IsInitialized) Cef.Initialize(settings);
            browser = new ChromiumWebBrowser("https://webrtc.inchang.dev:10001/?mode=receiver&autoStart=true&userId=" + student_id + "&roomId=" + room_id);
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

        public void setFaceDoubtColor()
        {
            infoPanel.BackColor = Color.Purple;
            infoLabel.ForeColor = Color.White;
        }
        public void setGazeDoubtColor()
        {
            infoPanel.BackColor = Color.Yellow;
            infoLabel.ForeColor = Color.Black;
        }

        public void setSoundDoubtColor()
        {
            infoPanel.BackColor = Color.OrangeRed;
            infoLabel.ForeColor = Color.White;
        }

        public void setNormalColor()
        {
            infoPanel.BackColor = Color.White;
            infoLabel.ForeColor = Color.Black;
        }
    }
}
