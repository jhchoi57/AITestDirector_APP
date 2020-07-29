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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.signupCancelButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.signupPositionLabel = new System.Windows.Forms.Label();
            this.signupEmailAuthLabel = new System.Windows.Forms.Label();
            this.signupPositionPanel = new System.Windows.Forms.Panel();
            this.signupBirthLabel = new System.Windows.Forms.Label();
            this.signupEmailAuthPanel = new System.Windows.Forms.Panel();
            this.signupEmailAuthTextBox = new System.Windows.Forms.TextBox();
            this.signupPasswordCheckLabel = new System.Windows.Forms.Label();
            this.signupBirthPanel = new System.Windows.Forms.Panel();
            this.signupBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.signupPasswordLabel = new System.Windows.Forms.Label();
            this.signupPasswordCheckPanel = new System.Windows.Forms.Panel();
            this.signupPasswordCheckTextBox = new System.Windows.Forms.TextBox();
            this.signupEmailLabel = new System.Windows.Forms.Label();
            this.signupPasswordPanel = new System.Windows.Forms.Panel();
            this.signupPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signupEmailPanel = new System.Windows.Forms.Panel();
            this.signupEmailTextBox = new System.Windows.Forms.TextBox();
            this.signupNameLabel = new System.Windows.Forms.Label();
            this.signupNamePanel = new System.Windows.Forms.Panel();
            this.signupNameTextBox = new System.Windows.Forms.TextBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.signupEmailAuthPanel.SuspendLayout();
            this.signupBirthPanel.SuspendLayout();
            this.signupPasswordCheckPanel.SuspendLayout();
            this.signupPasswordPanel.SuspendLayout();
            this.signupEmailPanel.SuspendLayout();
            this.signupNamePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.emailPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.signupPanel);
            this.mainPanel.Controls.Add(this.imagePanel);
            this.mainPanel.Controls.Add(this.loginPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 640);
            this.mainPanel.TabIndex = 0;
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.White;
            this.signupPanel.Controls.Add(this.signupCancelButton);
            this.signupPanel.Controls.Add(this.signupButton);
            this.signupPanel.Controls.Add(this.signupPositionLabel);
            this.signupPanel.Controls.Add(this.signupEmailAuthLabel);
            this.signupPanel.Controls.Add(this.signupPositionPanel);
            this.signupPanel.Controls.Add(this.signupBirthLabel);
            this.signupPanel.Controls.Add(this.signupEmailAuthPanel);
            this.signupPanel.Controls.Add(this.signupPasswordCheckLabel);
            this.signupPanel.Controls.Add(this.signupBirthPanel);
            this.signupPanel.Controls.Add(this.signupPasswordLabel);
            this.signupPanel.Controls.Add(this.signupPasswordCheckPanel);
            this.signupPanel.Controls.Add(this.signupEmailLabel);
            this.signupPanel.Controls.Add(this.signupPasswordPanel);
            this.signupPanel.Controls.Add(this.signupEmailPanel);
            this.signupPanel.Controls.Add(this.signupNameLabel);
            this.signupPanel.Controls.Add(this.signupNamePanel);
            this.signupPanel.Location = new System.Drawing.Point(640, 0);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(320, 640);
            this.signupPanel.TabIndex = 1;
            this.signupPanel.Visible = false;
            // 
            // signupCancelButton
            // 
            this.signupCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.signupCancelButton.FlatAppearance.BorderSize = 0;
            this.signupCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupCancelButton.ForeColor = System.Drawing.Color.White;
            this.signupCancelButton.Location = new System.Drawing.Point(170, 547);
            this.signupCancelButton.Name = "signupCancelButton";
            this.signupCancelButton.Size = new System.Drawing.Size(110, 34);
            this.signupCancelButton.TabIndex = 9;
            this.signupCancelButton.TabStop = false;
            this.signupCancelButton.Text = "취소";
            this.signupCancelButton.UseVisualStyleBackColor = false;
            this.signupCancelButton.Click += new System.EventHandler(this.signupCancelButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(40, 547);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(110, 34);
            this.signupButton.TabIndex = 8;
            this.signupButton.TabStop = false;
            this.signupButton.Text = "회원가입";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signupPositionLabel
            // 
            this.signupPositionLabel.Location = new System.Drawing.Point(40, 460);
            this.signupPositionLabel.Name = "signupPositionLabel";
            this.signupPositionLabel.Size = new System.Drawing.Size(61, 21);
            this.signupPositionLabel.TabIndex = 4;
            this.signupPositionLabel.Text = "소속";
            // 
            // signupEmailAuthLabel
            // 
            this.signupEmailAuthLabel.Location = new System.Drawing.Point(40, 390);
            this.signupEmailAuthLabel.Name = "signupEmailAuthLabel";
            this.signupEmailAuthLabel.Size = new System.Drawing.Size(110, 21);
            this.signupEmailAuthLabel.TabIndex = 4;
            this.signupEmailAuthLabel.Text = "이메일 인증";
            // 
            // signupPositionPanel
            // 
            this.signupPositionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPositionPanel.Location = new System.Drawing.Point(40, 485);
            this.signupPositionPanel.Name = "signupPositionPanel";
            this.signupPositionPanel.Size = new System.Drawing.Size(240, 31);
            this.signupPositionPanel.TabIndex = 5;
            // 
            // signupBirthLabel
            // 
            this.signupBirthLabel.Location = new System.Drawing.Point(40, 320);
            this.signupBirthLabel.Name = "signupBirthLabel";
            this.signupBirthLabel.Size = new System.Drawing.Size(98, 21);
            this.signupBirthLabel.TabIndex = 4;
            this.signupBirthLabel.Text = "생년월일";
            // 
            // signupEmailAuthPanel
            // 
            this.signupEmailAuthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupEmailAuthPanel.Controls.Add(this.signupEmailAuthTextBox);
            this.signupEmailAuthPanel.Location = new System.Drawing.Point(40, 415);
            this.signupEmailAuthPanel.Name = "signupEmailAuthPanel";
            this.signupEmailAuthPanel.Size = new System.Drawing.Size(240, 31);
            this.signupEmailAuthPanel.TabIndex = 5;
            // 
            // signupEmailAuthTextBox
            // 
            this.signupEmailAuthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupEmailAuthTextBox.Location = new System.Drawing.Point(6, 7);
            this.signupEmailAuthTextBox.Name = "signupEmailAuthTextBox";
            this.signupEmailAuthTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupEmailAuthTextBox.TabIndex = 0;
            // 
            // signupPasswordCheckLabel
            // 
            this.signupPasswordCheckLabel.Location = new System.Drawing.Point(40, 250);
            this.signupPasswordCheckLabel.Name = "signupPasswordCheckLabel";
            this.signupPasswordCheckLabel.Size = new System.Drawing.Size(130, 21);
            this.signupPasswordCheckLabel.TabIndex = 4;
            this.signupPasswordCheckLabel.Text = "비밀번호 확인";
            // 
            // signupBirthPanel
            // 
            this.signupBirthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupBirthPanel.Controls.Add(this.signupBirthPicker);
            this.signupBirthPanel.Location = new System.Drawing.Point(40, 345);
            this.signupBirthPanel.Name = "signupBirthPanel";
            this.signupBirthPanel.Size = new System.Drawing.Size(240, 31);
            this.signupBirthPanel.TabIndex = 5;
            // 
            // signupBirthPicker
            // 
            this.signupBirthPicker.CalendarFont = new System.Drawing.Font("굴림", 9F);
            this.signupBirthPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupBirthPicker.Location = new System.Drawing.Point(0, 0);
            this.signupBirthPicker.Name = "signupBirthPicker";
            this.signupBirthPicker.Size = new System.Drawing.Size(238, 21);
            this.signupBirthPicker.TabIndex = 0;
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.Location = new System.Drawing.Point(40, 180);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(83, 21);
            this.signupPasswordLabel.TabIndex = 4;
            this.signupPasswordLabel.Text = "비밀번호";
            // 
            // signupPasswordCheckPanel
            // 
            this.signupPasswordCheckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPasswordCheckPanel.Controls.Add(this.signupPasswordCheckTextBox);
            this.signupPasswordCheckPanel.Location = new System.Drawing.Point(40, 275);
            this.signupPasswordCheckPanel.Name = "signupPasswordCheckPanel";
            this.signupPasswordCheckPanel.Size = new System.Drawing.Size(240, 31);
            this.signupPasswordCheckPanel.TabIndex = 5;
            // 
            // signupPasswordCheckTextBox
            // 
            this.signupPasswordCheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupPasswordCheckTextBox.Location = new System.Drawing.Point(6, 7);
            this.signupPasswordCheckTextBox.Name = "signupPasswordCheckTextBox";
            this.signupPasswordCheckTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupPasswordCheckTextBox.TabIndex = 0;
            // 
            // signupEmailLabel
            // 
            this.signupEmailLabel.Location = new System.Drawing.Point(40, 110);
            this.signupEmailLabel.Name = "signupEmailLabel";
            this.signupEmailLabel.Size = new System.Drawing.Size(61, 21);
            this.signupEmailLabel.TabIndex = 6;
            this.signupEmailLabel.Text = "이메일";
            // 
            // signupPasswordPanel
            // 
            this.signupPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPasswordPanel.Controls.Add(this.signupPasswordTextBox);
            this.signupPasswordPanel.Location = new System.Drawing.Point(40, 205);
            this.signupPasswordPanel.Name = "signupPasswordPanel";
            this.signupPasswordPanel.Size = new System.Drawing.Size(240, 31);
            this.signupPasswordPanel.TabIndex = 5;
            // 
            // signupPasswordTextBox
            // 
            this.signupPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupPasswordTextBox.Location = new System.Drawing.Point(6, 7);
            this.signupPasswordTextBox.Name = "signupPasswordTextBox";
            this.signupPasswordTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupPasswordTextBox.TabIndex = 0;
            // 
            // signupEmailPanel
            // 
            this.signupEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupEmailPanel.Controls.Add(this.signupEmailTextBox);
            this.signupEmailPanel.Location = new System.Drawing.Point(40, 135);
            this.signupEmailPanel.Name = "signupEmailPanel";
            this.signupEmailPanel.Size = new System.Drawing.Size(240, 31);
            this.signupEmailPanel.TabIndex = 7;
            // 
            // signupEmailTextBox
            // 
            this.signupEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupEmailTextBox.Location = new System.Drawing.Point(6, 7);
            this.signupEmailTextBox.Name = "signupEmailTextBox";
            this.signupEmailTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupEmailTextBox.TabIndex = 0;
            // 
            // signupNameLabel
            // 
            this.signupNameLabel.Location = new System.Drawing.Point(40, 40);
            this.signupNameLabel.Name = "signupNameLabel";
            this.signupNameLabel.Size = new System.Drawing.Size(61, 21);
            this.signupNameLabel.TabIndex = 4;
            this.signupNameLabel.Text = "이름";
            // 
            // signupNamePanel
            // 
            this.signupNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupNamePanel.Controls.Add(this.signupNameTextBox);
            this.signupNamePanel.Location = new System.Drawing.Point(40, 65);
            this.signupNamePanel.Name = "signupNamePanel";
            this.signupNamePanel.Size = new System.Drawing.Size(240, 31);
            this.signupNamePanel.TabIndex = 5;
            // 
            // signupNameTextBox
            // 
            this.signupNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupNameTextBox.Location = new System.Drawing.Point(6, 7);
            this.signupNameTextBox.Name = "signupNameTextBox";
            this.signupNameTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupNameTextBox.TabIndex = 0;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Yellow;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(640, 640);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.exitButton);
            this.loginPanel.Controls.Add(this.minimizeButton);
            this.loginPanel.Controls.Add(this.emailLabel);
            this.loginPanel.Controls.Add(this.emailPanel);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.passwordPanel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.copyrightLabel);
            this.loginPanel.Location = new System.Drawing.Point(640, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(320, 640);
            this.loginPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(290, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "✕";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(260, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 28);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(40, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(61, 21);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "이메일";
            // 
            // emailPanel
            // 
            this.emailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailPanel.Location = new System.Drawing.Point(40, 188);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(240, 31);
            this.emailPanel.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(6, 7);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(230, 14);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter_1);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave_1);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(40, 230);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 21);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "비밀번호";
            // 
            // passwordPanel
            // 
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Location = new System.Drawing.Point(40, 258);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(240, 31);
            this.passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Location = new System.Drawing.Point(6, 7);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(230, 14);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter_1);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave_1);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(40, 305);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(240, 34);
            this.loginButton.TabIndex = 6;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(40, 350);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(240, 34);
            this.registerButton.TabIndex = 7;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "회원가입";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Location = new System.Drawing.Point(85, 610);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(150, 15);
            this.copyrightLabel.TabIndex = 8;
            this.copyrightLabel.Text = "ⓒ CROFO  from Sejong Univ.";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.mainPanel);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load_1);
            this.mainPanel.ResumeLayout(false);
            this.signupPanel.ResumeLayout(false);
            this.signupEmailAuthPanel.ResumeLayout(false);
            this.signupEmailAuthPanel.PerformLayout();
            this.signupBirthPanel.ResumeLayout(false);
            this.signupPasswordCheckPanel.ResumeLayout(false);
            this.signupPasswordCheckPanel.PerformLayout();
            this.signupPasswordPanel.ResumeLayout(false);
            this.signupPasswordPanel.PerformLayout();
            this.signupEmailPanel.ResumeLayout(false);
            this.signupEmailPanel.PerformLayout();
            this.signupNamePanel.ResumeLayout(false);
            this.signupNamePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button registerButton;
        private Panel signupPanel;
        private Button signupCancelButton;
        private Button signupButton;
        private Label signupPositionLabel;
        private Label signupEmailAuthLabel;
        private Panel signupPositionPanel;
        private Label signupBirthLabel;
        private Panel signupEmailAuthPanel;
        private TextBox signupEmailAuthTextBox;
        private Label signupPasswordCheckLabel;
        private Panel signupBirthPanel;
        private DateTimePicker signupBirthPicker;
        private Label signupPasswordLabel;
        private Panel signupPasswordCheckPanel;
        private TextBox signupPasswordCheckTextBox;
        private Label signupEmailLabel;
        private Panel signupPasswordPanel;
        private TextBox signupPasswordTextBox;
        private Panel signupEmailPanel;
        private TextBox signupEmailTextBox;
        private Label signupNameLabel;
        private Panel signupNamePanel;
        private TextBox signupNameTextBox;
    }
}