using program.View.Components;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace program.View
{
    partial class MakeExamView
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
            this.examPanel = new System.Windows.Forms.Panel();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.examLectureNameLabel = new System.Windows.Forms.Label();
            this.examLectureNameComboBox = new System.Windows.Forms.ComboBox();
            this.examNameLabel = new System.Windows.Forms.Label();
            this.examNamePanel = new System.Windows.Forms.Panel();
            this.examNameTextBox = new System.Windows.Forms.TextBox();
            this.examPercentLabel = new System.Windows.Forms.Label();
            this.examPercentLabel2 = new System.Windows.Forms.Label();
            this.examPercentPanel = new System.Windows.Forms.Panel();
            this.examPercentTextBox = new System.Windows.Forms.TextBox();
            this.examPeriodLabel = new System.Windows.Forms.Label();
            this.startDateTimeLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimeLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.examTimeLabel = new System.Windows.Forms.Label();
            this.examTimeLabel2 = new System.Windows.Forms.Label();
            this.examTimePanel = new System.Windows.Forms.Panel();
            this.examTimeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.examNamePanel.SuspendLayout();
            this.examPercentPanel.SuspendLayout();
            this.examTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.examPanel);
            this.mainPanel.Controls.Add(this.settingPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 654);
            this.mainPanel.TabIndex = 0;
            // 
            // examPanel
            // 
            this.examPanel.AutoScroll = true;
            this.examPanel.Location = new System.Drawing.Point(0, 0);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(885, 612);
            this.examPanel.TabIndex = 0;
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.Color.White;
            this.settingPanel.Controls.Add(this.examLectureNameLabel);
            this.settingPanel.Controls.Add(this.examLectureNameComboBox);
            this.settingPanel.Controls.Add(this.examNameLabel);
            this.settingPanel.Controls.Add(this.examNamePanel);
            this.settingPanel.Controls.Add(this.examPercentLabel);
            this.settingPanel.Controls.Add(this.examPercentLabel2);
            this.settingPanel.Controls.Add(this.examPercentPanel);
            this.settingPanel.Controls.Add(this.examPeriodLabel);
            this.settingPanel.Controls.Add(this.startDateTimeLabel);
            this.settingPanel.Controls.Add(this.startDateTimePicker);
            this.settingPanel.Controls.Add(this.endDateTimeLabel);
            this.settingPanel.Controls.Add(this.endDateTimePicker);
            this.settingPanel.Controls.Add(this.examTimeLabel);
            this.settingPanel.Controls.Add(this.examTimeLabel2);
            this.settingPanel.Controls.Add(this.examTimePanel);
            this.settingPanel.Controls.Add(this.saveButton);
            this.settingPanel.Controls.Add(this.cancelButton);
            this.settingPanel.Location = new System.Drawing.Point(885, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(379, 654);
            this.settingPanel.TabIndex = 1;
            // 
            // examLectureNameLabel
            // 
            this.examLectureNameLabel.Location = new System.Drawing.Point(40, 70);
            this.examLectureNameLabel.Name = "examLectureNameLabel";
            this.examLectureNameLabel.Size = new System.Drawing.Size(65, 21);
            this.examLectureNameLabel.TabIndex = 2;
            this.examLectureNameLabel.Text = "강의명:";
            // 
            // examLectureNameComboBox
            // 
            this.examLectureNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examLectureNameComboBox.Location = new System.Drawing.Point(105, 67);
            this.examLectureNameComboBox.Name = "examLectureNameComboBox";
            this.examLectureNameComboBox.Size = new System.Drawing.Size(180, 20);
            this.examLectureNameComboBox.TabIndex = 3;
            // 
            // examNameLabel
            // 
            this.examNameLabel.Location = new System.Drawing.Point(40, 120);
            this.examNameLabel.Name = "examNameLabel";
            this.examNameLabel.Size = new System.Drawing.Size(65, 21);
            this.examNameLabel.TabIndex = 4;
            this.examNameLabel.Text = "시험명:";
            // 
            // examNamePanel
            // 
            this.examNamePanel.BackColor = System.Drawing.Color.White;
            this.examNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examNamePanel.Controls.Add(this.examNameTextBox);
            this.examNamePanel.Location = new System.Drawing.Point(105, 117);
            this.examNamePanel.Name = "examNamePanel";
            this.examNamePanel.Size = new System.Drawing.Size(120, 26);
            this.examNamePanel.TabIndex = 5;
            // 
            // examNameTextBox
            // 
            this.examNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examNameTextBox.Location = new System.Drawing.Point(4, 3);
            this.examNameTextBox.Name = "examNameTextBox";
            this.examNameTextBox.Size = new System.Drawing.Size(107, 14);
            this.examNameTextBox.TabIndex = 0;
            // 
            // examPercentLabel
            // 
            this.examPercentLabel.Location = new System.Drawing.Point(40, 170);
            this.examPercentLabel.Name = "examPercentLabel";
            this.examPercentLabel.Size = new System.Drawing.Size(118, 21);
            this.examPercentLabel.TabIndex = 6;
            this.examPercentLabel.Text = "성적 반영 비율:";
            // 
            // examPercentLabel2
            // 
            this.examPercentLabel2.Location = new System.Drawing.Point(208, 170);
            this.examPercentLabel2.Name = "examPercentLabel2";
            this.examPercentLabel2.Size = new System.Drawing.Size(20, 21);
            this.examPercentLabel2.TabIndex = 7;
            this.examPercentLabel2.Text = "%";
            // 
            // examPercentPanel
            // 
            this.examPercentPanel.BackColor = System.Drawing.Color.White;
            this.examPercentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examPercentPanel.Controls.Add(this.examPercentTextBox);
            this.examPercentPanel.Location = new System.Drawing.Point(158, 166);
            this.examPercentPanel.Name = "examPercentPanel";
            this.examPercentPanel.Size = new System.Drawing.Size(50, 26);
            this.examPercentPanel.TabIndex = 8;
            // 
            // examPercentTextBox
            // 
            this.examPercentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examPercentTextBox.Location = new System.Drawing.Point(4, 3);
            this.examPercentTextBox.Name = "examPercentTextBox";
            this.examPercentTextBox.Size = new System.Drawing.Size(37, 14);
            this.examPercentTextBox.TabIndex = 0;
            // 
            // examPeriodLabel
            // 
            this.examPeriodLabel.Location = new System.Drawing.Point(40, 220);
            this.examPeriodLabel.Name = "examPeriodLabel";
            this.examPeriodLabel.Size = new System.Drawing.Size(118, 21);
            this.examPeriodLabel.TabIndex = 9;
            this.examPeriodLabel.Text = "시험 응시 기간";
            // 
            // startDateTimeLabel
            // 
            this.startDateTimeLabel.Location = new System.Drawing.Point(50, 255);
            this.startDateTimeLabel.Name = "startDateTimeLabel";
            this.startDateTimeLabel.Size = new System.Drawing.Size(42, 21);
            this.startDateTimeLabel.TabIndex = 10;
            this.startDateTimeLabel.Text = "시작:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(92, 252);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(195, 21);
            this.startDateTimePicker.TabIndex = 11;
            // 
            // endDateTimeLabel
            // 
            this.endDateTimeLabel.Location = new System.Drawing.Point(50, 295);
            this.endDateTimeLabel.Name = "endDateTimeLabel";
            this.endDateTimeLabel.Size = new System.Drawing.Size(42, 21);
            this.endDateTimeLabel.TabIndex = 12;
            this.endDateTimeLabel.Text = "종료:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(92, 292);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(195, 21);
            this.endDateTimePicker.TabIndex = 13;
            // 
            // examTimeLabel
            // 
            this.examTimeLabel.Location = new System.Drawing.Point(40, 342);
            this.examTimeLabel.Name = "examTimeLabel";
            this.examTimeLabel.Size = new System.Drawing.Size(82, 21);
            this.examTimeLabel.TabIndex = 14;
            this.examTimeLabel.Text = "시험 시간:";
            // 
            // examTimeLabel2
            // 
            this.examTimeLabel2.Location = new System.Drawing.Point(172, 342);
            this.examTimeLabel2.Name = "examTimeLabel2";
            this.examTimeLabel2.Size = new System.Drawing.Size(21, 21);
            this.examTimeLabel2.TabIndex = 15;
            this.examTimeLabel2.Text = "분";
            // 
            // examTimePanel
            // 
            this.examTimePanel.BackColor = System.Drawing.Color.White;
            this.examTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examTimePanel.Controls.Add(this.examTimeTextBox);
            this.examTimePanel.Location = new System.Drawing.Point(122, 338);
            this.examTimePanel.Name = "examTimePanel";
            this.examTimePanel.Size = new System.Drawing.Size(50, 26);
            this.examTimePanel.TabIndex = 16;
            // 
            // examTimeTextBox
            // 
            this.examTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examTimeTextBox.Location = new System.Drawing.Point(4, 3);
            this.examTimeTextBox.Name = "examTimeTextBox";
            this.examTimeTextBox.Size = new System.Drawing.Size(37, 14);
            this.examTimeTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(60, 572);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 50);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "저 장";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(220, 572);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "취 소";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // MakeExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.mainPanel);
            this.Name = "MakeExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeExamView";
            this.Load += new System.EventHandler(this.MakeExamView_Load1);
            this.mainPanel.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.examNamePanel.ResumeLayout(false);
            this.examNamePanel.PerformLayout();
            this.examPercentPanel.ResumeLayout(false);
            this.examPercentPanel.PerformLayout();
            this.examTimePanel.ResumeLayout(false);
            this.examTimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private Panel mainPanel;
        private Panel examPanel;
        private Panel settingPanel;
        private Panel examNamePanel;
        private Panel examPercentPanel;
        private Panel examTimePanel;
        private List<MainQuestionPanel> mainQuestionPanelList;

        private ExamPageNavigationPanel examPageNavigationPanel;

        private TopBarPanel topBarPanel;

        // Buttons
        private Button saveButton;
        private Button cancelButton;

        // ComboBoxes
        private ComboBox examLectureNameComboBox;

        // TextBoxes
        private TextBox examNameTextBox;
        private TextBox examPercentTextBox;
        private TextBox examTimeTextBox;

        // Labels
        private Label examLectureNameLabel;
        private Label examNameLabel;
        private Label examPercentLabel;
        private Label examPercentLabel2;
        private Label examPeriodLabel;
        private Label startDateTimeLabel;
        private Label endDateTimeLabel;
        private Label examTimeLabel;
        private Label examTimeLabel2;

        // DateTimePicker
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;

    }
}