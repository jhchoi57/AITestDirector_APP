using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ChatPanel : Panel
    {
        private Panel headerPanel { get; set; }
        private Panel mainPanel { get; set; }
        private Panel inputPanel { get; set; }

        private Label headerLabel;

        private TextBox inputTextBox { get; set; }
        private Button sendButton { get; set; }
        private MinimizeButton minimizeBtn { get; set; }
        public Panel HeaderPanel
        {
            get { return headerPanel; }
            set { headerPanel = value; }
        }
        public Panel MainPanel
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }
        public Panel InputPanel
        {
            get { return inputPanel; }
            set { inputPanel = value; }
        }
        public TextBox InputTextBox
        {
            get { return inputTextBox; }
            set { inputTextBox = value; }
        }
        public Button SendButton
        {
            get { return sendButton; }
            set { sendButton = value; }
        }
        public MinimizeButton MinimizeBtn
        {
            get { return minimizeBtn; }
            set { minimizeBtn = value; }
        }
        public ChatPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(300, 400);
            this.BackColor = Color.White;

            headerPanel = new Panel();
            headerPanel.Size = new Size(300, 28);
            headerPanel.BackColor = Color.BlueViolet;
            this.Controls.Add(headerPanel);

            headerLabel = new Label();
            headerLabel.Font = customFonts.NormalFont();
            headerLabel.Text = "채팅 문의";
            headerLabel.Size = new Size(100, 14);
            headerLabel.Location = new Point(10, 7);
            headerLabel.ForeColor = Color.White;
            headerPanel.Controls.Add(headerLabel);

            minimizeBtn = new MinimizeButton(customFonts);
            minimizeBtn.Location = new Point(270, 0);
            minimizeBtn.ForeColor = Color.White;
            headerPanel.Controls.Add(minimizeBtn);

            mainPanel = new Panel();
            mainPanel.Size = new Size(298, 300);
            mainPanel.Location = new Point(1, 28);
            mainPanel.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);

            inputPanel = new Panel();
            inputPanel.Size = new Size(298, 71);
            inputPanel.Location = new Point(1, 328);
            inputPanel.BackColor = Color.White;
            this.Controls.Add(inputPanel);

            inputTextBox = new TextBox();
            inputTextBox.Font = customFonts.NormalFont();
            inputTextBox.BorderStyle = BorderStyle.None;
            inputTextBox.Multiline = true;
            inputTextBox.Size = new Size(210, 51);
            inputTextBox.Location = new Point(10, 10);
            inputPanel.Controls.Add(inputTextBox);

            sendButton = new Button();
            sendButton.BackColor = Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            sendButton.ForeColor = Color.White;
            sendButton.Size = new Size(48, 30);
            sendButton.Location = new Point(235, 20);
            sendButton.Text = "전 송";
            sendButton.Font = customFonts.SmallFont();
            sendButton.FlatAppearance.BorderSize = 0;
            sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            inputPanel.Controls.Add(sendButton);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color borderColor = Color.BlueViolet;
            int borderWidth = 1;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }
    }
}
