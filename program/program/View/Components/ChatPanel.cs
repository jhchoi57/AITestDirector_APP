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
        private CustomFonts customFonts;
        private Panel headerPanel { get; set; }
        private Panel mainPanel { get; set; }
        private Panel inputPanel { get; set; }

        private Label headerLabel;
        private List<ChatContentPanel> chatContentPanelList { get; set; }

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
        public List<ChatContentPanel> ChatContentPanelList
        {
            get { return chatContentPanelList; }
            set { chatContentPanelList = value; }
        }
        public ChatPanel(CustomFonts customFonts) : base()
        {
            this.customFonts = customFonts;
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
            inputTextBox.MouseDown += inputTextBox_MouseDown_1;

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
            sendButton.Click += sendButton_Click_1;

            chatContentPanelList = new List<ChatContentPanel>();
            chatContentPanelList.Add(new ChatContentPanel(customFonts, "안녕하세요. 저는 컴퓨터공학과 4학년 이승민이라고 합니다. 다름이 아니라 기말고사 내용에 대한 질문이 있어서 문의드립니다.", 0));
            chatContentPanelList.Add(new ChatContentPanel(customFonts, "그래요. 안녕하신가요. 어떤 일로 문의 주셨나요?", 1));
            mainPanel.Controls.Add(chatContentPanelList[0]);
            mainPanel.Controls.Add(chatContentPanelList[1]);
            alignChatContentPanel(0);
        }

        public ChatPanel(CustomFonts customFonts, string studentID, string studentName) : base()
        {
            this.customFonts = customFonts;
            this.Size = new Size(328, 350);
            this.BackColor = Color.White;

            headerPanel = new Panel();
            headerPanel.Size = new Size(328, 28);
            headerPanel.BackColor = Color.BlueViolet;
            this.Controls.Add(headerPanel);

            headerLabel = new Label();
            headerLabel.Font = customFonts.NormalFont();
            headerLabel.Text = studentID + " " + studentName;
            headerLabel.Size = new Size(200, 14);
            headerLabel.Location = new Point(10, 7);
            headerLabel.ForeColor = Color.White;
            headerPanel.Controls.Add(headerLabel);

            mainPanel = new Panel();
            mainPanel.Size = new Size(326, 250);
            mainPanel.Location = new Point(1, 28);
            mainPanel.BackColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);

            inputPanel = new Panel();
            inputPanel.Size = new Size(326, 71);
            inputPanel.Location = new Point(1, 278);
            inputPanel.BackColor = Color.White;
            this.Controls.Add(inputPanel);

            inputTextBox = new TextBox();
            inputTextBox.Font = customFonts.NormalFont();
            inputTextBox.BorderStyle = BorderStyle.None;
            inputTextBox.Multiline = true;
            inputTextBox.Size = new Size(238, 51);
            inputTextBox.Location = new Point(10, 10);
            inputPanel.Controls.Add(inputTextBox);
            inputTextBox.MouseDown += inputTextBox_MouseDown_1;

            sendButton = new Button();
            sendButton.BackColor = Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            sendButton.ForeColor = Color.White;
            sendButton.Size = new Size(48, 30);
            sendButton.Location = new Point(263, 20);
            sendButton.Text = "전 송";
            sendButton.Font = customFonts.SmallFont();
            sendButton.FlatAppearance.BorderSize = 0;
            sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            inputPanel.Controls.Add(sendButton);
            sendButton.Click += sendButton_Click_1;

            chatContentPanelList = new List<ChatContentPanel>();
            chatContentPanelList.Add(new ChatContentPanel(customFonts, "안녕하세요. 저는 컴퓨터공학과 4학년 이승민이라고 합니다. 다름이 아니라 기말고사 내용에 대한 질문이 있어서 문의드립니다.", 0));
            chatContentPanelList.Add(new ChatContentPanel(customFonts, "그래요. 안녕하신가요. 어떤 일로 문의 주셨나요?", 1));
            mainPanel.Controls.Add(chatContentPanelList[0]);
            mainPanel.Controls.Add(chatContentPanelList[1]);
            alignChatContentPanel(0);
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

        private void alignChatContentPanel (int start)
        {
            int count = chatContentPanelList.Count;

            for (int i = start; i < count; i++)
            {
                int locationX = 10;
                if (chatContentPanelList[i].Type == 0)
                    locationX = mainPanel.Width - (chatContentPanelList[i].Width + 20);
                if (i == 0)
                {
                    chatContentPanelList[i].Location = new Point(locationX, 10);
                }
                else
                {
                    int locationY = chatContentPanelList[i - 1].Location.Y + chatContentPanelList[i - 1].Height + 10;
                    chatContentPanelList[i].Location = new Point(locationX, locationY);
                }
            }

            mainPanel.AutoScrollPosition = new Point(0, mainPanel.DisplayRectangle.Height);
        }

        public void addChatContentPanel (ChatContentPanel chatContentPanel)
        {
            int count = chatContentPanelList.Count;

            chatContentPanelList.Add(chatContentPanel);
            mainPanel.Controls.Add(chatContentPanel);
            alignChatContentPanel(count);
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            string str = inputTextBox.Text.Replace(" ", "");
            str = str.Replace("\r", "");
            str = str.Replace("\n", "");
            if (str != "")
            {
                addChatContentPanel(new ChatContentPanel(customFonts, inputTextBox.Text, 0));
                inputTextBox.Text = "";
            }
        }

        private void inputTextBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("마우스 오른쪽 클릭은 지원하지 않습니다.");
            }
        }

        public void changeHeaderLabelText(string studentID, string studentName)
        {
            this.headerLabel.Text = studentID + " " + studentName;
        }
    }
}
