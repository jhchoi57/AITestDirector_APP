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
            this.examPanel = new Panel();
            this.examInfoPanel = new Panel();
            this.endExamButton = new Button();
            this.examTimePanel = new Panel();
            this.examTimeLabel = new Label();
            this.examShortCutLabel = new Label();
            this.examShortCutPanel = new Panel();
            this.examLectureLabel = new Label();
            this.examNameLabel = new Label();
            this.examPercentLabel = new Label();
            this.openChatBoxPanel = new Panel();
            this.openChatBoxLabel = new Label();
            this.openChatAlertPanel = new Panel();
            this.openChatAlertLabel = new Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.examPanel);
            this.mainPanel.Controls.Add(this.examInfoPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
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
            this.examInfoPanel.Controls.Add(this.endExamButton);
            this.examInfoPanel.Controls.Add(this.examTimePanel);
            this.examInfoPanel.Controls.Add(this.examShortCutLabel);
            this.examInfoPanel.Controls.Add(this.examShortCutPanel);
            this.examInfoPanel.Controls.Add(this.examLectureLabel);
            this.examInfoPanel.Controls.Add(this.examNameLabel);
            this.examInfoPanel.Controls.Add(this.examPercentLabel);
            this.examInfoPanel.BackColor = System.Drawing.Color.White;
            this.examInfoPanel.Location = new System.Drawing.Point(885, 0);
            this.examInfoPanel.Name = "examInfoPanel";
            this.examInfoPanel.Size = new System.Drawing.Size(379, 682);
            this.examInfoPanel.TabIndex = 1;
            //
            // endExamButton
            //
            this.endExamButton.ForeColor = Color.White;
            this.endExamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.endExamButton.Text = "시험 종료";
            this.endExamButton.Size = new System.Drawing.Size(139, 50);
            this.endExamButton.Location = new System.Drawing.Point(120, 600);
            this.endExamButton.FlatAppearance.BorderSize = 0;
            this.endExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //
            // examTimePanel
            //
            this.examTimePanel.Controls.Add(this.examTimeLabel);
            this.examTimePanel.BackColor = Color.White;
            this.examTimePanel.Size = new Size(110, 50);
            this.examTimePanel.BorderStyle = BorderStyle.FixedSingle;
            this.examTimePanel.Location = new Point(30, 30);
            //
            // examTimeLabel
            //
            this.examTimeLabel.ForeColor = Color.Black;
            this.examTimeLabel.Text = "1:00:00";
            this.examTimeLabel.Location = new Point(3, 10);
            this.examTimeLabel.Size = new Size(110, 30);
            //
            // examShortCutLabel
            //
            this.examShortCutLabel.ForeColor = Color.Black;
            this.examShortCutLabel.Text = "문제 바로가기";
            this.examShortCutLabel.Location = new Point(30, 120);
            this.examShortCutLabel.Size = new Size(100, 20);
            //
            // examShortCutPanel
            //
            this.examShortCutPanel.BackColor = Color.White;
            this.examShortCutPanel.Size = new Size(324, 108);
            this.examShortCutPanel.Location = new Point(30, 145);
            this.examShortCutPanel.AutoScroll = true;
            //
            // examLectureLabel
            //
            this.examLectureLabel.Location = new System.Drawing.Point(30, 350);
            this.examLectureLabel.Size = new System.Drawing.Size(350, 21);
            this.examLectureLabel.Text = "강의명:  운영체제";
            //
            // examNameLabel
            //
            this.examNameLabel.Location = new System.Drawing.Point(30, 390);
            this.examNameLabel.Size = new System.Drawing.Size(350, 21);
            this.examNameLabel.Text = "시험명:  중간고사";
            //
            // examPercentLabel
            //
            this.examPercentLabel.Location = new System.Drawing.Point(30, 430);
            this.examPercentLabel.Size = new System.Drawing.Size(350, 21);
            this.examPercentLabel.Text = "성적 반영 비율:  25%";
            //
            // openChatBoxPanel
            //
            this.openChatBoxPanel.Controls.Add(this.openChatBoxLabel);
            this.openChatBoxPanel.Controls.Add(this.openChatAlertPanel);
            this.openChatBoxPanel.Location = new Point(30, 0);
            this.openChatBoxPanel.Size = new Size(150, 30);
            this.openChatBoxPanel.BackColor = Color.BlueViolet;
            //
            // openChatBoxLabel
            //
            this.openChatBoxLabel.Text = "채팅 문의                      +";
            this.openChatBoxLabel.Size = new Size(135, 14);
            this.openChatBoxLabel.Location = new Point(10, 8);
            this.openChatBoxLabel.ForeColor = Color.White;
            //
            // openChatAlertPanel
            //
            this.openChatAlertPanel.Controls.Add(this.openChatAlertLabel);
            this.openChatAlertPanel.Location = new Point(125, 8);
            this.openChatAlertPanel.Size = new Size(14, 14);
            this.openChatAlertPanel.BackColor = Color.White;
            this.openChatAlertPanel.BringToFront();
            //
            // openChatAlertLabel
            //
            this.openChatAlertLabel.Text = "5";
            this.openChatAlertLabel.ForeColor = Color.Black;
            this.openChatAlertLabel.Location = new Point(1, 1);
            this.openChatAlertLabel.Size = new Size(10, 10);
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
            this.Load += new System.EventHandler(this.ExamView_Load1);
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