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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.examShortCutLabel = new Label();
            this.examShortCutPanel = new Panel();
            this.mainPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.examNamePanel.SuspendLayout();
            this.examPercentPanel.SuspendLayout();
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
            this.settingPanel.Controls.Add(this.saveButton);
            this.settingPanel.Controls.Add(this.cancelButton);
            this.settingPanel.Controls.Add(this.examShortCutLabel);
            this.settingPanel.Controls.Add(this.examShortCutPanel);
            this.settingPanel.Location = new System.Drawing.Point(885, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(379, 654);
            this.settingPanel.TabIndex = 1;
            // 
            // examLectureNameLabel
            // 
            this.examLectureNameLabel.Location = new System.Drawing.Point(30, 70);
            this.examLectureNameLabel.Name = "examLectureNameLabel";
            this.examLectureNameLabel.Size = new System.Drawing.Size(65, 21);
            this.examLectureNameLabel.TabIndex = 2;
            this.examLectureNameLabel.Text = "강의명:";
            // 
            // examLectureNameComboBox
            // 
            this.examLectureNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examLectureNameComboBox.Location = new System.Drawing.Point(95, 67);
            this.examLectureNameComboBox.Name = "examLectureNameComboBox";
            this.examLectureNameComboBox.Size = new System.Drawing.Size(180, 20);
            this.examLectureNameComboBox.TabIndex = 3;
            // 
            // examNameLabel
            // 
            this.examNameLabel.Location = new System.Drawing.Point(30, 120);
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
            this.examNamePanel.Location = new System.Drawing.Point(95, 117);
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
            this.examPercentLabel.Location = new System.Drawing.Point(30, 170);
            this.examPercentLabel.Name = "examPercentLabel";
            this.examPercentLabel.Size = new System.Drawing.Size(118, 21);
            this.examPercentLabel.TabIndex = 6;
            this.examPercentLabel.Text = "성적 반영 비율:";
            // 
            // examPercentLabel2
            // 
            this.examPercentLabel2.Location = new System.Drawing.Point(198, 170);
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
            this.examPercentPanel.Location = new System.Drawing.Point(148, 166);
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
            this.examPeriodLabel.Location = new System.Drawing.Point(30, 220);
            this.examPeriodLabel.Name = "examPeriodLabel";
            this.examPeriodLabel.Size = new System.Drawing.Size(118, 21);
            this.examPeriodLabel.TabIndex = 9;
            this.examPeriodLabel.Text = "시험 응시 기간";
            // 
            // startDateTimeLabel
            // 
            this.startDateTimeLabel.Location = new System.Drawing.Point(40, 255);
            this.startDateTimeLabel.Name = "startDateTimeLabel";
            this.startDateTimeLabel.Size = new System.Drawing.Size(42, 21);
            this.startDateTimeLabel.TabIndex = 10;
            this.startDateTimeLabel.Text = "시작:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(82, 252);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(195, 21);
            this.startDateTimePicker.TabIndex = 11;
            // 
            // endDateTimeLabel
            // 
            this.endDateTimeLabel.Location = new System.Drawing.Point(40, 295);
            this.endDateTimeLabel.Name = "endDateTimeLabel";
            this.endDateTimeLabel.Size = new System.Drawing.Size(42, 21);
            this.endDateTimeLabel.TabIndex = 12;
            this.endDateTimeLabel.Text = "종료:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(82, 292);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(195, 21);
            this.endDateTimePicker.TabIndex = 13;
            //
            // examShortCutLabel
            //
            this.examShortCutLabel.ForeColor = Color.Black;
            this.examShortCutLabel.Text = "문제 바로가기";
            this.examShortCutLabel.Location = new Point(30, 340);
            this.examShortCutLabel.Size = new Size(110, 20);
            //
            // examShortCutPanel
            //
            this.examShortCutPanel.BackColor = Color.White;
            this.examShortCutPanel.Size = new Size(324, 108);
            this.examShortCutPanel.Location = new Point(30, 370);
            this.examShortCutPanel.AutoScroll = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private Panel mainPanel;
        private Panel examPanel;
        private Panel settingPanel;
        private Panel examNamePanel;
        private Panel examPercentPanel;
        private Panel examShortCutPanel;

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

        // Labels
        private Label examLectureNameLabel;
        private Label examNameLabel;
        private Label examPercentLabel;
        private Label examPercentLabel2;
        private Label examPeriodLabel;
        private Label startDateTimeLabel;
        private Label endDateTimeLabel;
        private Label examShortCutLabel;

        // DateTimePicker
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;

    }
}