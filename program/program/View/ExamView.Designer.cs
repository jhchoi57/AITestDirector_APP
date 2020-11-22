using program.View.Components;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace program.View
{
    partial class ExamView
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
            this.webrtcPanel = new System.Windows.Forms.Panel();
            this.examPanel = new System.Windows.Forms.Panel();
            this.examInfoPanel = new System.Windows.Forms.Panel();
            this.endExamButton = new System.Windows.Forms.Button();
            this.examTimePanel = new System.Windows.Forms.Panel();
            this.examTimeLabel = new System.Windows.Forms.Label();
            this.examShortCutLabel = new System.Windows.Forms.Label();
            this.examShortCutPanel = new System.Windows.Forms.Panel();
            this.examLectureLabel = new System.Windows.Forms.Label();
            this.examNameLabel = new System.Windows.Forms.Label();
            this.examPercentLabel = new System.Windows.Forms.Label();
            this.openChatBoxPanel = new System.Windows.Forms.Panel();
            this.openChatBoxLabel = new System.Windows.Forms.Label();
            this.openChatAlertPanel = new System.Windows.Forms.Panel();
            this.openChatAlertLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.examInfoPanel.SuspendLayout();
            this.examTimePanel.SuspendLayout();
            this.openChatBoxPanel.SuspendLayout();
            this.openChatAlertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.webrtcPanel);
            this.mainPanel.Controls.Add(this.examPanel);
            this.mainPanel.Controls.Add(this.examInfoPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
            // 
            // webrtcPanel
            // 
            this.webrtcPanel.Location = new System.Drawing.Point(0, 0);
            this.webrtcPanel.Name = "webrtcPanel";
            this.webrtcPanel.Size = new System.Drawing.Size(885, 640);
            this.webrtcPanel.TabIndex = 0;
            // 
            // examPanel
            // 
            this.examPanel.AutoScroll = true;
            this.examPanel.Location = new System.Drawing.Point(0, 0);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(885, 640);
            this.examPanel.TabIndex = 0;
            // 
            // examInfoPanel
            // 
            this.examInfoPanel.BackColor = System.Drawing.Color.White;
            this.examInfoPanel.Controls.Add(this.endExamButton);
            this.examInfoPanel.Controls.Add(this.examTimePanel);
            this.examInfoPanel.Controls.Add(this.examShortCutLabel);
            this.examInfoPanel.Controls.Add(this.examShortCutPanel);
            this.examInfoPanel.Controls.Add(this.examLectureLabel);
            this.examInfoPanel.Controls.Add(this.examNameLabel);
            this.examInfoPanel.Controls.Add(this.examPercentLabel);
            this.examInfoPanel.Location = new System.Drawing.Point(885, 0);
            this.examInfoPanel.Name = "examInfoPanel";
            this.examInfoPanel.Size = new System.Drawing.Size(379, 682);
            this.examInfoPanel.TabIndex = 1;
            // 
            // endExamButton
            // 
            this.endExamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.endExamButton.FlatAppearance.BorderSize = 0;
            this.endExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endExamButton.ForeColor = System.Drawing.Color.White;
            this.endExamButton.Location = new System.Drawing.Point(120, 600);
            this.endExamButton.Name = "endExamButton";
            this.endExamButton.Size = new System.Drawing.Size(139, 50);
            this.endExamButton.TabIndex = 0;
            this.endExamButton.Text = "시험 종료";
            this.endExamButton.UseVisualStyleBackColor = false;
            // 
            // examTimePanel
            // 
            this.examTimePanel.BackColor = System.Drawing.Color.White;
            this.examTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examTimePanel.Controls.Add(this.examTimeLabel);
            this.examTimePanel.Location = new System.Drawing.Point(30, 30);
            this.examTimePanel.Name = "examTimePanel";
            this.examTimePanel.Size = new System.Drawing.Size(110, 50);
            this.examTimePanel.TabIndex = 1;
            // 
            // examTimeLabel
            // 
            this.examTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.examTimeLabel.Location = new System.Drawing.Point(3, 10);
            this.examTimeLabel.Name = "examTimeLabel";
            this.examTimeLabel.Size = new System.Drawing.Size(110, 30);
            this.examTimeLabel.TabIndex = 0;
            this.examTimeLabel.Text = "1:00:00";
            // 
            // examShortCutLabel
            // 
            this.examShortCutLabel.ForeColor = System.Drawing.Color.Black;
            this.examShortCutLabel.Location = new System.Drawing.Point(30, 120);
            this.examShortCutLabel.Name = "examShortCutLabel";
            this.examShortCutLabel.Size = new System.Drawing.Size(120, 20);
            this.examShortCutLabel.TabIndex = 2;
            this.examShortCutLabel.Text = "문제 바로가기";
            // 
            // examShortCutPanel
            // 
            this.examShortCutPanel.AutoScroll = true;
            this.examShortCutPanel.BackColor = System.Drawing.Color.White;
            this.examShortCutPanel.Location = new System.Drawing.Point(30, 145);
            this.examShortCutPanel.Name = "examShortCutPanel";
            this.examShortCutPanel.Size = new System.Drawing.Size(324, 108);
            this.examShortCutPanel.TabIndex = 3;
            // 
            // examLectureLabel
            // 
            this.examLectureLabel.Location = new System.Drawing.Point(30, 350);
            this.examLectureLabel.Name = "examLectureLabel";
            this.examLectureLabel.Size = new System.Drawing.Size(350, 21);
            this.examLectureLabel.TabIndex = 4;
            this.examLectureLabel.Text = "강의명:  운영체제";
            // 
            // examNameLabel
            // 
            this.examNameLabel.Location = new System.Drawing.Point(30, 390);
            this.examNameLabel.Name = "examNameLabel";
            this.examNameLabel.Size = new System.Drawing.Size(350, 21);
            this.examNameLabel.TabIndex = 5;
            this.examNameLabel.Text = "시험명:  중간고사";
            // 
            // examPercentLabel
            // 
            this.examPercentLabel.Location = new System.Drawing.Point(30, 430);
            this.examPercentLabel.Name = "examPercentLabel";
            this.examPercentLabel.Size = new System.Drawing.Size(350, 21);
            this.examPercentLabel.TabIndex = 6;
            this.examPercentLabel.Text = "성적 반영 비율:  25%";
            // 
            // openChatBoxPanel
            // 
            this.openChatBoxPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.openChatBoxPanel.Controls.Add(this.openChatBoxLabel);
            this.openChatBoxPanel.Controls.Add(this.openChatAlertPanel);
            this.openChatBoxPanel.Location = new System.Drawing.Point(30, 0);
            this.openChatBoxPanel.Name = "openChatBoxPanel";
            this.openChatBoxPanel.Size = new System.Drawing.Size(150, 30);
            this.openChatBoxPanel.TabIndex = 0;
            // 
            // openChatBoxLabel
            // 
            this.openChatBoxLabel.ForeColor = System.Drawing.Color.White;
            this.openChatBoxLabel.Location = new System.Drawing.Point(10, 8);
            this.openChatBoxLabel.Name = "openChatBoxLabel";
            this.openChatBoxLabel.Size = new System.Drawing.Size(135, 14);
            this.openChatBoxLabel.TabIndex = 0;
            this.openChatBoxLabel.Text = "채팅 문의                      +";
            // 
            // openChatAlertPanel
            // 
            this.openChatAlertPanel.BackColor = System.Drawing.Color.White;
            this.openChatAlertPanel.Controls.Add(this.openChatAlertLabel);
            this.openChatAlertPanel.Location = new System.Drawing.Point(125, 8);
            this.openChatAlertPanel.Name = "openChatAlertPanel";
            this.openChatAlertPanel.Size = new System.Drawing.Size(14, 14);
            this.openChatAlertPanel.TabIndex = 1;
            // 
            // openChatAlertLabel
            // 
            this.openChatAlertLabel.ForeColor = System.Drawing.Color.Black;
            this.openChatAlertLabel.Location = new System.Drawing.Point(1, 1);
            this.openChatAlertLabel.Name = "openChatAlertLabel";
            this.openChatAlertLabel.Size = new System.Drawing.Size(10, 10);
            this.openChatAlertLabel.TabIndex = 0;
            this.openChatAlertLabel.Text = "5";
            // 
            // ExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.mainPanel);
            this.Name = "ExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamView_FormClosing);
            this.Load += new System.EventHandler(this.ExamView_Load1);
            this.mainPanel.ResumeLayout(false);
            this.examInfoPanel.ResumeLayout(false);
            this.examTimePanel.ResumeLayout(false);
            this.openChatBoxPanel.ResumeLayout(false);
            this.openChatAlertPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private System.Windows.Forms.Panel mainPanel;
        private Panel examPanel;
        private Panel examInfoPanel;
        private Panel examTimePanel;
        private Panel examShortCutPanel;
        private Panel openChatBoxPanel;
        private Panel openChatAlertPanel;
        private Panel webrtcPanel;
        private List<ExamMainQuestionPanel> examMainQuestionPanelList;

        private ExamPageNavigationPanel examPageNavigationPanel;

        // Buttons
        private Button endExamButton;

        private ExitButton exitButton;
        private MinimizeButton minimizeButton;

        // Labels
        private Label examTimeLabel;
        private Label examShortCutLabel;
        private Label examLectureLabel;
        private Label examNameLabel;
        private Label examPercentLabel;
        private Label openChatBoxLabel;
        private Label openChatAlertLabel;
    }
}