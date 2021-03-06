﻿using System;
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
            this.signupPositionComboBox = new System.Windows.Forms.ComboBox();
            this.signupPositionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupStdNumLabel = new System.Windows.Forms.Label();
            this.signupUnivButton = new System.Windows.Forms.Button();
            this.signupStdNumPanel = new System.Windows.Forms.Panel();
            this.signupStdNumTextBox = new System.Windows.Forms.TextBox();
            this.signupUnivLabel = new System.Windows.Forms.Label();
            this.signupUnivPanel = new System.Windows.Forms.Panel();
            this.signupUnivTextBox = new System.Windows.Forms.TextBox();
            this.signupCancelButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.signupBirthLabel = new System.Windows.Forms.Label();
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
            this.professorRadioBtn = new System.Windows.Forms.RadioButton();
            this.studentRadioBtn = new System.Windows.Forms.RadioButton();
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
            this.signupStdNumPanel.SuspendLayout();
            this.signupUnivPanel.SuspendLayout();
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
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 612);
            this.mainPanel.TabIndex = 0;
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.White;
            this.signupPanel.Controls.Add(this.signupPositionComboBox);
            this.signupPanel.Controls.Add(this.signupPositionLabel);
            this.signupPanel.Controls.Add(this.label1);
            this.signupPanel.Controls.Add(this.signupStdNumLabel);
            this.signupPanel.Controls.Add(this.signupUnivButton);
            this.signupPanel.Controls.Add(this.signupStdNumPanel);
            this.signupPanel.Controls.Add(this.signupUnivLabel);
            this.signupPanel.Controls.Add(this.signupUnivPanel);
            this.signupPanel.Controls.Add(this.signupCancelButton);
            this.signupPanel.Controls.Add(this.signupButton);
            this.signupPanel.Controls.Add(this.signupBirthLabel);
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
            this.signupPanel.Size = new System.Drawing.Size(320, 612);
            this.signupPanel.TabIndex = 1;
            this.signupPanel.Visible = false;
            this.signupPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signupPanel_Paint);
            // 
            // signupPositionComboBox
            // 
            this.signupPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signupPositionComboBox.FormattingEnabled = true;
            this.signupPositionComboBox.Location = new System.Drawing.Point(204, 509);
            this.signupPositionComboBox.Name = "signupPositionComboBox";
            this.signupPositionComboBox.Size = new System.Drawing.Size(76, 20);
            this.signupPositionComboBox.TabIndex = 11;
            this.signupPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // signupPositionLabel
            // 
            this.signupPositionLabel.Location = new System.Drawing.Point(202, 480);
            this.signupPositionLabel.Name = "signupPositionLabel";
            this.signupPositionLabel.Size = new System.Drawing.Size(98, 21);
            this.signupPositionLabel.TabIndex = 17;
            this.signupPositionLabel.Text = "구분";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "*학생";
            // 
            // signupStdNumLabel
            // 
            this.signupStdNumLabel.Location = new System.Drawing.Point(40, 103);
            this.signupStdNumLabel.Name = "signupStdNumLabel";
            this.signupStdNumLabel.Size = new System.Drawing.Size(61, 21);
            this.signupStdNumLabel.TabIndex = 13;
            this.signupStdNumLabel.Text = "학번";
            // 
            // signupUnivButton
            // 
            this.signupUnivButton.BackColor = System.Drawing.Color.Gray;
            this.signupUnivButton.FlatAppearance.BorderSize = 0;
            this.signupUnivButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupUnivButton.ForeColor = System.Drawing.Color.White;
            this.signupUnivButton.Location = new System.Drawing.Point(199, 54);
            this.signupUnivButton.Name = "signupUnivButton";
            this.signupUnivButton.Size = new System.Drawing.Size(81, 31);
            this.signupUnivButton.TabIndex = 1;
            this.signupUnivButton.TabStop = false;
            this.signupUnivButton.Text = "검색";
            this.signupUnivButton.UseVisualStyleBackColor = false;
            this.signupUnivButton.Click += new System.EventHandler(this.signupUnivButton_Click);
            // 
            // signupStdNumPanel
            // 
            this.signupStdNumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupStdNumPanel.Controls.Add(this.signupStdNumTextBox);
            this.signupStdNumPanel.Location = new System.Drawing.Point(40, 128);
            this.signupStdNumPanel.Name = "signupStdNumPanel";
            this.signupStdNumPanel.Size = new System.Drawing.Size(240, 31);
            this.signupStdNumPanel.TabIndex = 2;
            // 
            // signupStdNumTextBox
            // 
            this.signupStdNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupStdNumTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupStdNumTextBox.Name = "signupStdNumTextBox";
            this.signupStdNumTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupStdNumTextBox.TabIndex = 0;
            // 
            // signupUnivLabel
            // 
            this.signupUnivLabel.Location = new System.Drawing.Point(40, 29);
            this.signupUnivLabel.Name = "signupUnivLabel";
            this.signupUnivLabel.Size = new System.Drawing.Size(61, 21);
            this.signupUnivLabel.TabIndex = 1;
            this.signupUnivLabel.Text = "학교";
            // 
            // signupUnivPanel
            // 
            this.signupUnivPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupUnivPanel.Controls.Add(this.signupUnivTextBox);
            this.signupUnivPanel.Location = new System.Drawing.Point(40, 54);
            this.signupUnivPanel.Name = "signupUnivPanel";
            this.signupUnivPanel.Size = new System.Drawing.Size(153, 31);
            this.signupUnivPanel.TabIndex = 0;
            // 
            // signupUnivTextBox
            // 
            this.signupUnivTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupUnivTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupUnivTextBox.Name = "signupUnivTextBox";
            this.signupUnivTextBox.Size = new System.Drawing.Size(138, 14);
            this.signupUnivTextBox.TabIndex = 0;
            // 
            // signupCancelButton
            // 
            this.signupCancelButton.BackColor = System.Drawing.Color.Silver;
            this.signupCancelButton.FlatAppearance.BorderSize = 0;
            this.signupCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupCancelButton.ForeColor = System.Drawing.Color.White;
            this.signupCancelButton.Location = new System.Drawing.Point(170, 558);
            this.signupCancelButton.Name = "signupCancelButton";
            this.signupCancelButton.Size = new System.Drawing.Size(110, 34);
            this.signupCancelButton.TabIndex = 13;
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
            this.signupButton.Location = new System.Drawing.Point(40, 558);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(110, 34);
            this.signupButton.TabIndex = 12;
            this.signupButton.TabStop = false;
            this.signupButton.Text = "회원가입";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // signupBirthLabel
            // 
            this.signupBirthLabel.Location = new System.Drawing.Point(40, 480);
            this.signupBirthLabel.Name = "signupBirthLabel";
            this.signupBirthLabel.Size = new System.Drawing.Size(98, 21);
            this.signupBirthLabel.TabIndex = 9;
            this.signupBirthLabel.Text = "생년월일";
            // 
            // signupPasswordCheckLabel
            // 
            this.signupPasswordCheckLabel.Location = new System.Drawing.Point(40, 406);
            this.signupPasswordCheckLabel.Name = "signupPasswordCheckLabel";
            this.signupPasswordCheckLabel.Size = new System.Drawing.Size(130, 21);
            this.signupPasswordCheckLabel.TabIndex = 4;
            this.signupPasswordCheckLabel.Text = "비밀번호 확인";
            // 
            // signupBirthPanel
            // 
            this.signupBirthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupBirthPanel.Controls.Add(this.signupBirthPicker);
            this.signupBirthPanel.Location = new System.Drawing.Point(40, 509);
            this.signupBirthPanel.Name = "signupBirthPanel";
            this.signupBirthPanel.Size = new System.Drawing.Size(153, 22);
            this.signupBirthPanel.TabIndex = 10;
            // 
            // signupBirthPicker
            // 
            this.signupBirthPicker.CalendarFont = new System.Drawing.Font("굴림", 9F);
            this.signupBirthPicker.CustomFormat = "";
            this.signupBirthPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.signupBirthPicker.Location = new System.Drawing.Point(0, 0);
            this.signupBirthPicker.Name = "signupBirthPicker";
            this.signupBirthPicker.Size = new System.Drawing.Size(151, 21);
            this.signupBirthPicker.TabIndex = 0;
            this.signupBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.Location = new System.Drawing.Point(40, 332);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(83, 21);
            this.signupPasswordLabel.TabIndex = 4;
            this.signupPasswordLabel.Text = "비밀번호";
            // 
            // signupPasswordCheckPanel
            // 
            this.signupPasswordCheckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPasswordCheckPanel.Controls.Add(this.signupPasswordCheckTextBox);
            this.signupPasswordCheckPanel.Location = new System.Drawing.Point(40, 431);
            this.signupPasswordCheckPanel.Name = "signupPasswordCheckPanel";
            this.signupPasswordCheckPanel.Size = new System.Drawing.Size(240, 31);
            this.signupPasswordCheckPanel.TabIndex = 6;
            // 
            // signupPasswordCheckTextBox
            // 
            this.signupPasswordCheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupPasswordCheckTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupPasswordCheckTextBox.Name = "signupPasswordCheckTextBox";
            this.signupPasswordCheckTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupPasswordCheckTextBox.TabIndex = 0;
            this.signupPasswordCheckTextBox.UseSystemPasswordChar = true;
            // 
            // signupEmailLabel
            // 
            this.signupEmailLabel.Location = new System.Drawing.Point(40, 255);
            this.signupEmailLabel.Name = "signupEmailLabel";
            this.signupEmailLabel.Size = new System.Drawing.Size(61, 21);
            this.signupEmailLabel.TabIndex = 6;
            this.signupEmailLabel.Text = "이메일";
            // 
            // signupPasswordPanel
            // 
            this.signupPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPasswordPanel.Controls.Add(this.signupPasswordTextBox);
            this.signupPasswordPanel.Location = new System.Drawing.Point(40, 357);
            this.signupPasswordPanel.Name = "signupPasswordPanel";
            this.signupPasswordPanel.Size = new System.Drawing.Size(240, 31);
            this.signupPasswordPanel.TabIndex = 5;
            // 
            // signupPasswordTextBox
            // 
            this.signupPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupPasswordTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupPasswordTextBox.Name = "signupPasswordTextBox";
            this.signupPasswordTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupPasswordTextBox.TabIndex = 0;
            this.signupPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // signupEmailPanel
            // 
            this.signupEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupEmailPanel.Controls.Add(this.signupEmailTextBox);
            this.signupEmailPanel.Location = new System.Drawing.Point(40, 280);
            this.signupEmailPanel.Name = "signupEmailPanel";
            this.signupEmailPanel.Size = new System.Drawing.Size(240, 31);
            this.signupEmailPanel.TabIndex = 4;
            // 
            // signupEmailTextBox
            // 
            this.signupEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupEmailTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupEmailTextBox.Name = "signupEmailTextBox";
            this.signupEmailTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupEmailTextBox.TabIndex = 0;
            // 
            // signupNameLabel
            // 
            this.signupNameLabel.Location = new System.Drawing.Point(40, 179);
            this.signupNameLabel.Name = "signupNameLabel";
            this.signupNameLabel.Size = new System.Drawing.Size(61, 21);
            this.signupNameLabel.TabIndex = 4;
            this.signupNameLabel.Text = "이름";
            // 
            // signupNamePanel
            // 
            this.signupNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupNamePanel.Controls.Add(this.signupNameTextBox);
            this.signupNamePanel.Location = new System.Drawing.Point(40, 204);
            this.signupNamePanel.Name = "signupNamePanel";
            this.signupNamePanel.Size = new System.Drawing.Size(240, 31);
            this.signupNamePanel.TabIndex = 3;
            // 
            // signupNameTextBox
            // 
            this.signupNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupNameTextBox.Location = new System.Drawing.Point(6, 6);
            this.signupNameTextBox.Name = "signupNameTextBox";
            this.signupNameTextBox.Size = new System.Drawing.Size(230, 14);
            this.signupNameTextBox.TabIndex = 0;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(640, 612);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.professorRadioBtn);
            this.loginPanel.Controls.Add(this.studentRadioBtn);
            this.loginPanel.Controls.Add(this.emailLabel);
            this.loginPanel.Controls.Add(this.emailPanel);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.passwordPanel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.copyrightLabel);
            this.loginPanel.Location = new System.Drawing.Point(640, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(320, 612);
            this.loginPanel.TabIndex = 1;
            // 
            // professorRadioBtn
            // 
            this.professorRadioBtn.AutoSize = true;
            this.professorRadioBtn.Location = new System.Drawing.Point(175, 301);
            this.professorRadioBtn.Name = "professorRadioBtn";
            this.professorRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.professorRadioBtn.TabIndex = 14;
            this.professorRadioBtn.TabStop = true;
            this.professorRadioBtn.Text = "교수";
            this.professorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // studentRadioBtn
            // 
            this.studentRadioBtn.AutoSize = true;
            this.studentRadioBtn.Location = new System.Drawing.Point(96, 301);
            this.studentRadioBtn.Name = "studentRadioBtn";
            this.studentRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.studentRadioBtn.TabIndex = 12;
            this.studentRadioBtn.TabStop = true;
            this.studentRadioBtn.Text = "학생";
            this.studentRadioBtn.UseVisualStyleBackColor = true;
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
            this.loginButton.Location = new System.Drawing.Point(40, 330);
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
            this.registerButton.Location = new System.Drawing.Point(40, 375);
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
            this.copyrightLabel.Location = new System.Drawing.Point(84, 584);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(150, 15);
            this.copyrightLabel.TabIndex = 0;
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
            this.signupStdNumPanel.ResumeLayout(false);
            this.signupStdNumPanel.PerformLayout();
            this.signupUnivPanel.ResumeLayout(false);
            this.signupUnivPanel.PerformLayout();
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
            this.loginPanel.PerformLayout();
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


        // TextBoxes
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private Panel signupPanel;
        private Button signupCancelButton;
        private Button signupButton;
        private Label signupBirthLabel;
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
        private Button signupUnivButton;
        private Label signupUnivLabel;
        private Panel signupUnivPanel;
        private TextBox signupUnivTextBox;
        private Label signupStdNumLabel;
        private Panel signupStdNumPanel;
        private TextBox signupStdNumTextBox;
        private Label label1;
        private Label signupPositionLabel;
        private ComboBox signupPositionComboBox;
        private RadioButton professorRadioBtn;
        private RadioButton studentRadioBtn;
    }
}