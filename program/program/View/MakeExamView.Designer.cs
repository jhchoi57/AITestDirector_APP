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
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.examLectureNameLabel = new System.Windows.Forms.Label();
            this.examLectureNameComboBox = new System.Windows.Forms.ComboBox();
            this.examNameLabel = new System.Windows.Forms.Label();
            this.examNamePanel = new System.Windows.Forms.Panel();
            this.examNameTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.examNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.examPanel);
            this.mainPanel.Controls.Add(this.settingPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
            // 
            // examPanel
            // 
            this.examPanel.Location = new System.Drawing.Point(0, 0);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(885, 640);
            this.examPanel.TabIndex = 0;
            this.examPanel.AutoScroll = true;
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.exitButton);
            this.settingPanel.Controls.Add(this.minimizeButton);
            this.settingPanel.Controls.Add(this.examLectureNameLabel);
            this.settingPanel.Controls.Add(this.examLectureNameComboBox);
            this.settingPanel.Controls.Add(this.examNameLabel);
            this.settingPanel.Controls.Add(this.examNamePanel);
            this.settingPanel.BackColor = Color.White;
            this.settingPanel.Location = new System.Drawing.Point(885, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(379, 682);
            this.settingPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(349, 0);
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
            this.minimizeButton.Location = new System.Drawing.Point(319, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 28);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);
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
            this.examLectureNameComboBox.Location = new System.Drawing.Point(105, 67);
            this.examLectureNameComboBox.Name = "examLectureNameComboBox";
            this.examLectureNameComboBox.Size = new System.Drawing.Size(180, 20);
            this.examLectureNameComboBox.TabIndex = 3;
            this.examLectureNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.examNamePanel.BackColor = Color.White;
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

            // examPercentLabel
            this.examPercentLabel = new Label();
            this.examPercentLabel.Text = "성적 반영 비율:";
            this.examPercentLabel.Location = new Point(40, 170);
            this.examPercentLabel.Size = new System.Drawing.Size(118, 21);
            this.settingPanel.Controls.Add(this.examPercentLabel);

            // examPercentLabel2
            this.examPercentLabel2 = new Label();
            this.examPercentLabel2.Text = "%";
            this.examPercentLabel2.Location = new Point(208, 170);
            this.examPercentLabel2.Size = new Size(20, 21);
            this.settingPanel.Controls.Add(this.examPercentLabel2);

            // examPercentPanel
            this.examPercentPanel = new Panel();
            this.examPercentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examPercentPanel.Size = new System.Drawing.Size(50, 26);
            this.examPercentPanel.Location = new System.Drawing.Point(158, 166);
            this.examPercentPanel.BackColor = Color.White;
            this.settingPanel.Controls.Add(this.examPercentPanel);

            // examPercentTextBox
            this.examPercentTextBox = new TextBox();
            this.examPercentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examPercentTextBox.Location = new System.Drawing.Point(4, 3);
            this.examPercentTextBox.Size = new Size(37, 14);
            this.examPercentPanel.Controls.Add(this.examPercentTextBox);

            // examPeriodLabel
            this.examPeriodLabel = new Label();
            this.examPeriodLabel.Text = "시험 응시 기간";
            this.examPeriodLabel.Size = new Size(118, 21);
            this.examPeriodLabel.Location = new Point(40, 220);
            this.settingPanel.Controls.Add(this.examPeriodLabel);

            // startDateTimeLabel
            this.startDateTimeLabel = new Label();
            this.startDateTimeLabel.Text = "시작:";
            this.startDateTimeLabel.Location = new Point(50, 255);
            this.startDateTimeLabel.Size = new Size(42, 21);
            this.settingPanel.Controls.Add(this.startDateTimeLabel);

            // startDateTimePicker
            this.startDateTimePicker = new DateTimePicker();
            this.startDateTimePicker.Location = new Point(92, 252);
            this.startDateTimePicker.Size = new Size(195, 40);
            this.settingPanel.Controls.Add(this.startDateTimePicker);

            // endDateTimeLabel
            this.endDateTimeLabel = new Label();
            this.endDateTimeLabel.Text = "종료:";
            this.endDateTimeLabel.Location = new Point(50, 295);
            this.endDateTimeLabel.Size = new Size(42, 21);
            this.settingPanel.Controls.Add(this.endDateTimeLabel);

            // endDateTimePicker
            this.endDateTimePicker = new DateTimePicker();
            this.endDateTimePicker.Location = new Point(92, 292);
            this.endDateTimePicker.Size = new Size(195, 40);
            this.settingPanel.Controls.Add(this.endDateTimePicker);

            // examTimeLabel
            this.examTimeLabel = new Label();
            this.examTimeLabel.Text = "시험 시간:";
            this.examTimeLabel.Size = new Size(82, 21);
            this.examTimeLabel.Location = new Point(40, 342);
            this.settingPanel.Controls.Add(this.examTimeLabel);

            // examTimeLabel2
            this.examTimeLabel2 = new Label();
            this.examTimeLabel2.Text = "분";
            this.examTimeLabel2.Size = new Size(21, 21);
            this.examTimeLabel2.Location = new Point(172, 342);
            this.settingPanel.Controls.Add(this.examTimeLabel2);


            // examTimePanel
            this.examTimePanel = new Panel();
            this.examTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examTimePanel.Size = new System.Drawing.Size(50, 26);
            this.examTimePanel.Location = new System.Drawing.Point(122, 338);
            this.examTimePanel.BackColor = Color.White;
            this.settingPanel.Controls.Add(this.examTimePanel);

            // examTimeTextBox
            this.examTimeTextBox = new TextBox();
            this.examTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.examTimeTextBox.Location = new System.Drawing.Point(4, 3);
            this.examTimeTextBox.Size = new Size(37, 14);
            this.examTimePanel.Controls.Add(this.examTimeTextBox);

            // saveButton
            this.saveButton = new Button();
            this.saveButton.ForeColor = Color.White;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Location = new Point(60, 600);
            this.saveButton.Size = new Size(100, 50);
            this.saveButton.Text = "저 장";
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingPanel.Controls.Add(this.saveButton);

            // cancelButton
            this.cancelButton = new Button();
            this.cancelButton.BackColor = Color.White;
            this.cancelButton.FlatAppearance.BorderSize = 1;
            this.cancelButton.Size = new Size(100, 50);
            this.cancelButton.Location = new Point(220, 600);
            this.cancelButton.Text = "취 소";
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingPanel.Controls.Add(this.cancelButton);

            // navigationPanel
            this.navigationPanel = new Panel();
            this.navigationPanel.Size = new Size(885, 42);
            this.navigationPanel.Location = new Point(0, 640);
            this.mainPanel.Controls.Add(this.navigationPanel);
            this.navigationPanel.BackColor = Color.Transparent;
            this.navigationPanel.Parent = this.mainPanel;

            // pageLeftButton
            this.pageLeftButton = new Button();
            this.pageLeftButton.Text = "<";
            this.pageLeftButton.ForeColor = Color.Gray;
            this.pageLeftButton.Location = new Point(362, 1);
            this.pageLeftButton.Size = new Size(40, 40);
            this.pageLeftButton.FlatAppearance.BorderSize = 0;
            this.pageLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationPanel.Controls.Add(pageLeftButton);

            // pageRightButton
            this.pageRightButton = new Button();
            this.pageRightButton.Text = ">";
            this.pageRightButton.ForeColor = Color.Gray;
            this.pageRightButton.Location = new Point(482, 1);
            this.pageRightButton.Size = new Size(40, 40);
            this.pageRightButton.FlatAppearance.BorderSize = 0;
            this.pageRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationPanel.Controls.Add(pageRightButton);

            // nowPagePanel
            this.nowPagePanel = new Panel();
            this.nowPagePanel.Size = new Size(28, 26);
            this.nowPagePanel.Location = new Point(409, 8);
            this.nowPagePanel.BackColor = Color.White;
            this.navigationPanel.Controls.Add(nowPagePanel);

            // nowPageTextBox
            this.nowPageTextBox = new TextBox();
            this.nowPageTextBox.Size = new Size(18, 14);
            this.nowPageTextBox.Location = new Point(5, 4);
            this.nowPageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowPageTextBox.Text = "1";
            this.nowPageTextBox.TextAlign = HorizontalAlignment.Center;
            this.nowPagePanel.Controls.Add(this.nowPageTextBox);

            // pageSlashLabel
            this.pageSlashLabel = new Label();
            this.pageSlashLabel.Size = new Size(10, 21);
            this.pageSlashLabel.Location = new Point(437, 10);
            this.pageSlashLabel.Text = "/";
            this.navigationPanel.Controls.Add(this.pageSlashLabel);

            // wholePageLabel
            this.wholePageLabel = new Label();
            this.wholePageLabel.Size = new Size(36, 21);
            this.wholePageLabel.Location = new Point(449, 12);
            this.wholePageLabel.Text = "55";
            this.navigationPanel.Controls.Add(this.wholePageLabel);

            // addQuestionButton
            this.addQuestionButton = new Button();
            this.addQuestionButton.Size = new Size(100, 42);
            this.addQuestionButton.Location = new Point(630, 0);
            this.addQuestionButton.BackColor = Color.BlanchedAlmond;
            this.addQuestionButton.Text = "+ 문제 추가";
            this.addQuestionButton.FlatAppearance.BorderSize = 0;
            this.addQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationPanel.Controls.Add(this.addQuestionButton);

            // removeQuestionButton
            this.removeQuestionButton = new Button();
            this.removeQuestionButton.Size = new Size(100, 42);
            this.removeQuestionButton.Location = new Point(730, 0);
            this.removeQuestionButton.ForeColor = Color.White;
            this.removeQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.removeQuestionButton.Text = "- 문제 제거";
            this.removeQuestionButton.FlatAppearance.BorderSize = 0;
            this.removeQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationPanel.Controls.Add(this.removeQuestionButton);


            // mainQuestionPanel
            this.mainQuestionPanel = new Panel();
            this.mainQuestionPanel.BackColor = Color.White;
            this.mainQuestionPanel.Width = 800;
            this.mainQuestionPanel.Height = 900;
            this.mainQuestionPanel.Location = new Point(30, 30);
            this.examPanel.Controls.Add(this.mainQuestionPanel);

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
        private Panel navigationPanel;
        private Panel nowPagePanel;
        private Panel mainQuestionPanel; 
        private Panel subQuestionPanel;

        // Buttons
        private Button exitButton;
        private Button minimizeButton;
        private Button saveButton;
        private Button cancelButton;
        private Button pageLeftButton;
        private Button pageRightButton;
        private Button addQuestionButton;
        private Button removeQuestionButton;

        // ComboBoxes
        private ComboBox examLectureNameComboBox;

        // TextBoxes
        private TextBox examNameTextBox;
        private TextBox examPercentTextBox;
        private TextBox examTimeTextBox;
        private TextBox nowPageTextBox;

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
        private Label pageSlashLabel;
        private Label wholePageLabel;

        // DateTimePicker
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;

    }
}