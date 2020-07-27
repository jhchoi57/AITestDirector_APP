using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace program.View
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Panels
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();

            // Font setting
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            Font labelFont = new Font(privateFont.Families[1], 14f);
            Font textBoxFont = new Font(privateFont.Families[1], 12f);
            Font copyrightFont = new Font(privateFont.Families[2], 8f);

            // Labels
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();

            // TextBoxs
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();

            // Buttons
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += LoginView_Load;

            // Main panel setting
            this.mainPanel.Location = new Point(0, 0);
            this.mainPanel.Size = new Size(960, 640);
            this.Controls.Add(this.mainPanel);

            // Image panel setting
            this.imagePanel.Location = new Point(0, 0);
            this.imagePanel.BackColor = Color.Yellow;
            this.imagePanel.Size = new Size(640, 640);
            this.mainPanel.Controls.Add(this.imagePanel);

            // Image panel backgroundimage setting
            string backgroundImageRoute = "../../src/Assets/Images/Login.jpg";
            System.IO.FileInfo backgroundImage = new System.IO.FileInfo(backgroundImageRoute);
            if (backgroundImage.Exists)
            {
                this.imagePanel.BackgroundImage = Bitmap.FromFile(backgroundImageRoute);
                this.imagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("LoginView 배경 이미지가 존재하지 않습니다.");
            }

            // Login panel setting
            this.loginPanel.Location = new Point(640, 0);
            this.loginPanel.BackColor = Color.White;
            this.loginPanel.Size = new Size(320, 640);
            this.mainPanel.Controls.Add(this.loginPanel);

            // Exit butotn setting
            this.exitButton.Location = new Point(290, 0);
            this.exitButton.Size = new Size(30, 28);
            this.exitButton.Text = "✕";
            this.exitButton.Font = labelFont;
            this.exitButton.TabStop = false;
            this.exitButton.FlatStyle = FlatStyle.Flat;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPanel.Controls.Add(this.exitButton);
            this.exitButton.Click += this.ExitButton_Click;

            // Minimize butotn setting
            this.minimizeButton.Location = new Point(260, 0);
            this.minimizeButton.Size = new Size(30, 28);
            this.minimizeButton.Text = "_";
            this.minimizeButton.Font = labelFont;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.FlatStyle = FlatStyle.Flat;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPanel.Controls.Add(this.minimizeButton);
            this.minimizeButton.Click += this.MinimizeButton_Click;

            // Email label setting
            this.emailLabel.Text = "이메일";
            this.emailLabel.Font = labelFont;
            this.emailLabel.Size = new Size(61, 21);
            this.emailLabel.Location = new Point(40, 160);
            this.loginPanel.Controls.Add(this.emailLabel);

            // Email panel setting
            this.emailPanel.Size = new Size(240, 31);
            this.emailPanel.Location = new Point(40, 188);
            this.emailPanel.BorderStyle = BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.emailPanel);

            // Email TextBox setting
            this.emailTextBox.Size = new Size(230, 25);
            this.emailTextBox.Location = new Point(6, 5);
            this.emailTextBox.AutoSize = false;
            this.emailTextBox.Font = textBoxFont;
            this.emailTextBox.BorderStyle = BorderStyle.None;
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailTextBox.Enter += this.EmailTextBox_Enter;
            this.emailTextBox.Leave += this.EmailTextBox_Leave;

            // Password label setting
            this.passwordLabel.Text = "비밀번호";
            this.passwordLabel.Font = labelFont;
            this.passwordLabel.Size = new Size(78, 21);
            this.passwordLabel.Location = new Point(40, 230);
            this.loginPanel.Controls.Add(this.passwordLabel);

            // Password panel setting
            this.passwordPanel.Size = new Size(240, 31);
            this.passwordPanel.Location = new Point(40, 258);
            this.passwordPanel.BorderStyle = BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.passwordPanel);

            // Password TextBox setting
            this.passwordTextBox.Size = new Size(230, 25);
            this.passwordTextBox.Location = new Point(6, 5);
            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Font = textBoxFont;
            this.passwordTextBox.BorderStyle = BorderStyle.None;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordTextBox.Enter += this.PasswordTextBox_Enter;
            this.passwordTextBox.Leave += this.PasswordTextBox_Leave;

            // Login Button setting
            this.loginButton.Size = new Size(240, 40);
            this.loginButton.BackColor = Color.FromArgb(158, 33, 59);
            this.loginButton.Location = new Point(40, 315);
            this.loginButton.Font = labelFont;
            this.loginButton.Text = "로그인";
            this.loginButton.ForeColor = Color.White;
            this.loginButton.TabStop = false;
            this.loginButton.FlatStyle = FlatStyle.Flat;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginButton.Click += LoginButton_Click;

            // Copyright Label setting
            this.copyrightLabel.Text = "ⓒ CROFO  from Sejong Univ.";
            this.copyrightLabel.Size = new Size(150, 15);
            this.copyrightLabel.Location = new Point(85, 610);
            this.copyrightLabel.Font = copyrightFont;
            this.loginPanel.Controls.Add(copyrightLabel);
            
        }
        // Email TextBox placeholder
        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if(emailTextBox.Text == "example@sejong.ac.kr")
            {
                emailTextBox.Text = "";
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if(emailTextBox.Text == "")
            {
                emailTextBox.Text = "example@sejong.ac.kr";
            }
        }

        // Password TextBox placeholder
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if(passwordTextBox.Text == "**********")
            {
                passwordTextBox.Text = "";
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if(passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "**********";
            }
        }

        // Exit Button Click 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button Click
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Login Button Click
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (email == "example@sejong.ac.kr" || password == "**********")
            {
                MessageBox.Show("아이디와 비밀번호를 정확히 입력하세요.");
            }
            MessageBox.Show(email + password);

            // 서버와 연동 
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            emailTextBox.Text = "example@sejong.ac.kr";
            passwordTextBox.Text = "**********";
            loginButton.Focus();
        }

        #endregion

        // Panels 
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel passwordPanel;

        // Labels
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label copyrightLabel;

        // TextBoxs
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;

        // Buttons
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button loginButton;
    }
}