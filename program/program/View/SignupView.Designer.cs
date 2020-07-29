using System;

namespace program.View
{
    partial class SignupView
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
            this.signupImagePanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.signupEmailAuthPanel.SuspendLayout();
            this.signupBirthPanel.SuspendLayout();
            this.signupPasswordCheckPanel.SuspendLayout();
            this.signupPasswordPanel.SuspendLayout();
            this.signupEmailPanel.SuspendLayout();
            this.signupNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.signupPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.signupPanel.TabIndex = 0;
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
            this.signupCancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.signupEmailAuthLabel.Size = new System.Drawing.Size(69, 21);
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
            this.signupBirthLabel.Size = new System.Drawing.Size(61, 21);
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
            this.signupPasswordCheckLabel.Size = new System.Drawing.Size(83, 21);
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
            this.signupBirthPicker.Location = new System.Drawing.Point(19, 3);
            this.signupBirthPicker.Name = "signupBirthPicker";
            this.signupBirthPicker.Size = new System.Drawing.Size(204, 21);
            this.signupBirthPicker.TabIndex = 0;
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.Location = new System.Drawing.Point(40, 180);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(61, 21);
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
            // signupImagePanel
            // 
            this.signupImagePanel.BackColor = System.Drawing.Color.Yellow;
            this.signupImagePanel.Location = new System.Drawing.Point(0, 0);
            this.signupImagePanel.Name = "signupImagePanel";
            this.signupImagePanel.Size = new System.Drawing.Size(640, 640);
            this.signupImagePanel.TabIndex = 1;
            // 
            // SignupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.signupImagePanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "SignupView";
            this.Text = "SignupView";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel signupImagePanel;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Label signupPositionLabel;
        private System.Windows.Forms.Label signupEmailAuthLabel;
        private System.Windows.Forms.Panel signupPositionPanel;
        private System.Windows.Forms.Label signupBirthLabel;
        private System.Windows.Forms.Panel signupEmailAuthPanel;
        private System.Windows.Forms.TextBox signupEmailAuthTextBox;
        private System.Windows.Forms.Label signupPasswordCheckLabel;
        private System.Windows.Forms.Panel signupBirthPanel;
        private System.Windows.Forms.Label signupPasswordLabel;
        private System.Windows.Forms.Panel signupPasswordCheckPanel;
        private System.Windows.Forms.TextBox signupPasswordCheckTextBox;
        private System.Windows.Forms.Label signupEmailLabel;
        private System.Windows.Forms.Panel signupPasswordPanel;
        private System.Windows.Forms.TextBox signupPasswordTextBox;
        private System.Windows.Forms.Panel signupEmailPanel;
        private System.Windows.Forms.TextBox signupEmailTextBox;
        private System.Windows.Forms.Label signupNameLabel;
        private System.Windows.Forms.Panel signupNamePanel;
        private System.Windows.Forms.TextBox signupNameTextBox;
        private System.Windows.Forms.DateTimePicker signupBirthPicker;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button signupCancelButton;
    }
}