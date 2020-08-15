using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace program.View
{
    partial class StudentHomeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cameraPanel = new System.Windows.Forms.Panel();
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.cameraCancelBtn = new System.Windows.Forms.Button();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.testInfoPanel = new System.Windows.Forms.Panel();
            this.testInfoCancelBtn = new System.Windows.Forms.Button();
            this.testInfoTestNameLbl = new System.Windows.Forms.Label();
            this.testInfoTimeLbl = new System.Windows.Forms.Label();
            this.testInfoDayLbl = new System.Windows.Forms.Label();
            this.testInfoProfNameLbl = new System.Windows.Forms.Label();
            this.testInfoLectureLbl = new System.Windows.Forms.Label();
            this.testStartBtn = new System.Windows.Forms.Button();
            this.testInfoExitBtn = new System.Windows.Forms.Button();
            this.testInfoMinimizeBtn = new System.Windows.Forms.Button();
            this.testPanel = new System.Windows.Forms.Panel();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.lectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkScoreBtn = new System.Windows.Forms.Button();
            this.editLectureBtn = new System.Windows.Forms.Button();
            this.myPagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.stuNumLabel = new System.Windows.Forms.Label();
            this.univLabel = new System.Windows.Forms.Label();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editExitButton = new System.Windows.Forms.Button();
            this.editMinimizeButton = new System.Windows.Forms.Button();
            this.editStdNumLabel = new System.Windows.Forms.Label();
            this.editStdNumPanel = new System.Windows.Forms.Panel();
            this.editStdNumTextBox = new System.Windows.Forms.TextBox();
            this.editUnivLabel = new System.Windows.Forms.Label();
            this.editUnivPanel = new System.Windows.Forms.Panel();
            this.editUnivTextBox = new System.Windows.Forms.TextBox();
            this.editCancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.editBirthLabel = new System.Windows.Forms.Label();
            this.editPasswordCheckLabel = new System.Windows.Forms.Label();
            this.editBirthPanel = new System.Windows.Forms.Panel();
            this.editBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.editPasswordLabel = new System.Windows.Forms.Label();
            this.editPasswordCheckPanel = new System.Windows.Forms.Panel();
            this.editPasswordCheckTextBox = new System.Windows.Forms.TextBox();
            this.editEmailLabel = new System.Windows.Forms.Label();
            this.editPasswordPanel = new System.Windows.Forms.Panel();
            this.editPasswordTextBox = new System.Windows.Forms.TextBox();
            this.editEmailPanel = new System.Windows.Forms.Panel();
            this.editEmailTextBox = new System.Windows.Forms.TextBox();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editNamePanel = new System.Windows.Forms.Panel();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.cameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            this.testInfoPanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.myPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.editPanel.SuspendLayout();
            this.editStdNumPanel.SuspendLayout();
            this.editUnivPanel.SuspendLayout();
            this.editBirthPanel.SuspendLayout();
            this.editPasswordCheckPanel.SuspendLayout();
            this.editPasswordPanel.SuspendLayout();
            this.editEmailPanel.SuspendLayout();
            this.editNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(349, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "✕";
            this.exitButton.Click += new System.EventHandler(this.signupExitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(319, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 28);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.signupMinimizeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.cameraPanel);
            this.mainPanel.Controls.Add(this.testInfoPanel);
            this.mainPanel.Controls.Add(this.testPanel);
            this.mainPanel.Controls.Add(this.myPagePanel);
            this.mainPanel.Controls.Add(this.editPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
            // 
            // cameraPanel
            // 
            this.cameraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.cameraPanel.Controls.Add(this.cameraPictureBox);
            this.cameraPanel.Controls.Add(this.cameraCancelBtn);
            this.cameraPanel.Controls.Add(this.cameraLabel);
            this.cameraPanel.Location = new System.Drawing.Point(461, 219);
            this.cameraPanel.Name = "cameraPanel";
            this.cameraPanel.Size = new System.Drawing.Size(366, 219);
            this.cameraPanel.TabIndex = 18;
            this.cameraPanel.Visible = false;
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.Location = new System.Drawing.Point(29, 32);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(92, 94);
            this.cameraPictureBox.TabIndex = 19;
            this.cameraPictureBox.TabStop = false;
            // 
            // cameraCancelBtn
            // 
            this.cameraCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.cameraCancelBtn.FlatAppearance.BorderSize = 0;
            this.cameraCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cameraCancelBtn.Location = new System.Drawing.Point(110, 158);
            this.cameraCancelBtn.Name = "cameraCancelBtn";
            this.cameraCancelBtn.Size = new System.Drawing.Size(143, 34);
            this.cameraCancelBtn.TabIndex = 18;
            this.cameraCancelBtn.TabStop = false;
            this.cameraCancelBtn.Text = "취소";
            this.cameraCancelBtn.UseVisualStyleBackColor = false;
            this.cameraCancelBtn.Click += new System.EventHandler(this.cameraCancelBtn_Click);
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.ForeColor = System.Drawing.Color.White;
            this.cameraLabel.Location = new System.Drawing.Point(160, 64);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(93, 12);
            this.cameraLabel.TabIndex = 0;
            this.cameraLabel.Text = "카메라 연동 중..";
            // 
            // testInfoPanel
            // 
            this.testInfoPanel.BackColor = System.Drawing.Color.Indigo;
            this.testInfoPanel.Controls.Add(this.testInfoCancelBtn);
            this.testInfoPanel.Controls.Add(this.testInfoTestNameLbl);
            this.testInfoPanel.Controls.Add(this.testInfoTimeLbl);
            this.testInfoPanel.Controls.Add(this.testInfoDayLbl);
            this.testInfoPanel.Controls.Add(this.testInfoProfNameLbl);
            this.testInfoPanel.Controls.Add(this.testInfoLectureLbl);
            this.testInfoPanel.Controls.Add(this.testStartBtn);
            this.testInfoPanel.Controls.Add(this.testInfoExitBtn);
            this.testInfoPanel.Controls.Add(this.testInfoMinimizeBtn);
            this.testInfoPanel.Location = new System.Drawing.Point(885, 0);
            this.testInfoPanel.Name = "testInfoPanel";
            this.testInfoPanel.Size = new System.Drawing.Size(379, 682);
            this.testInfoPanel.TabIndex = 19;
            this.testInfoPanel.Visible = false;
            // 
            // testInfoCancelBtn
            // 
            this.testInfoCancelBtn.BackColor = System.Drawing.Color.DimGray;
            this.testInfoCancelBtn.FlatAppearance.BorderSize = 0;
            this.testInfoCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testInfoCancelBtn.ForeColor = System.Drawing.Color.White;
            this.testInfoCancelBtn.Location = new System.Drawing.Point(202, 615);
            this.testInfoCancelBtn.Name = "testInfoCancelBtn";
            this.testInfoCancelBtn.Size = new System.Drawing.Size(143, 34);
            this.testInfoCancelBtn.TabIndex = 17;
            this.testInfoCancelBtn.TabStop = false;
            this.testInfoCancelBtn.Text = "취소";
            this.testInfoCancelBtn.UseVisualStyleBackColor = false;
            this.testInfoCancelBtn.Click += new System.EventHandler(this.testInfoCancelBtn_Click);
            // 
            // testInfoTestNameLbl
            // 
            this.testInfoTestNameLbl.ForeColor = System.Drawing.Color.White;
            this.testInfoTestNameLbl.Location = new System.Drawing.Point(68, 135);
            this.testInfoTestNameLbl.Name = "testInfoTestNameLbl";
            this.testInfoTestNameLbl.Size = new System.Drawing.Size(221, 48);
            this.testInfoTestNameLbl.TabIndex = 16;
            this.testInfoTestNameLbl.Text = "[시험 제목]";
            // 
            // testInfoTimeLbl
            // 
            this.testInfoTimeLbl.ForeColor = System.Drawing.Color.White;
            this.testInfoTimeLbl.Location = new System.Drawing.Point(70, 299);
            this.testInfoTimeLbl.Name = "testInfoTimeLbl";
            this.testInfoTimeLbl.Size = new System.Drawing.Size(208, 21);
            this.testInfoTimeLbl.TabIndex = 15;
            this.testInfoTimeLbl.Text = "[시간]";
            // 
            // testInfoDayLbl
            // 
            this.testInfoDayLbl.ForeColor = System.Drawing.Color.White;
            this.testInfoDayLbl.Location = new System.Drawing.Point(70, 256);
            this.testInfoDayLbl.Name = "testInfoDayLbl";
            this.testInfoDayLbl.Size = new System.Drawing.Size(208, 21);
            this.testInfoDayLbl.TabIndex = 14;
            this.testInfoDayLbl.Text = "[날짜]";
            // 
            // testInfoProfNameLbl
            // 
            this.testInfoProfNameLbl.ForeColor = System.Drawing.Color.White;
            this.testInfoProfNameLbl.Location = new System.Drawing.Point(70, 207);
            this.testInfoProfNameLbl.Name = "testInfoProfNameLbl";
            this.testInfoProfNameLbl.Size = new System.Drawing.Size(208, 21);
            this.testInfoProfNameLbl.TabIndex = 13;
            this.testInfoProfNameLbl.Text = "[교수명]";
            // 
            // testInfoLectureLbl
            // 
            this.testInfoLectureLbl.ForeColor = System.Drawing.Color.White;
            this.testInfoLectureLbl.Location = new System.Drawing.Point(45, 61);
            this.testInfoLectureLbl.Name = "testInfoLectureLbl";
            this.testInfoLectureLbl.Size = new System.Drawing.Size(290, 55);
            this.testInfoLectureLbl.TabIndex = 12;
            this.testInfoLectureLbl.Text = "[강의명]";
            // 
            // testStartBtn
            // 
            this.testStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.testStartBtn.FlatAppearance.BorderSize = 0;
            this.testStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testStartBtn.ForeColor = System.Drawing.Color.White;
            this.testStartBtn.Location = new System.Drawing.Point(47, 615);
            this.testStartBtn.Name = "testStartBtn";
            this.testStartBtn.Size = new System.Drawing.Size(143, 34);
            this.testStartBtn.TabIndex = 11;
            this.testStartBtn.TabStop = false;
            this.testStartBtn.Text = "응시하기";
            this.testStartBtn.UseVisualStyleBackColor = false;
            this.testStartBtn.Click += new System.EventHandler(this.testStartBtn_Click);
            // 
            // testInfoExitBtn
            // 
            this.testInfoExitBtn.FlatAppearance.BorderSize = 0;
            this.testInfoExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testInfoExitBtn.ForeColor = System.Drawing.Color.White;
            this.testInfoExitBtn.Location = new System.Drawing.Point(349, 0);
            this.testInfoExitBtn.Name = "testInfoExitBtn";
            this.testInfoExitBtn.Size = new System.Drawing.Size(30, 28);
            this.testInfoExitBtn.TabIndex = 0;
            this.testInfoExitBtn.TabStop = false;
            this.testInfoExitBtn.Text = "✕";
            this.testInfoExitBtn.Click += new System.EventHandler(this.testInfoExitBtn_Click);
            // 
            // testInfoMinimizeBtn
            // 
            this.testInfoMinimizeBtn.FlatAppearance.BorderSize = 0;
            this.testInfoMinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testInfoMinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.testInfoMinimizeBtn.Location = new System.Drawing.Point(319, 0);
            this.testInfoMinimizeBtn.Name = "testInfoMinimizeBtn";
            this.testInfoMinimizeBtn.Size = new System.Drawing.Size(30, 28);
            this.testInfoMinimizeBtn.TabIndex = 1;
            this.testInfoMinimizeBtn.TabStop = false;
            this.testInfoMinimizeBtn.Text = "_";
            this.testInfoMinimizeBtn.Click += new System.EventHandler(this.testInfoMinimizeBtn_Click);
            // 
            // testPanel
            // 
            this.testPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.testPanel.Controls.Add(this.lectureTable);
            this.testPanel.Controls.Add(this.checkScoreBtn);
            this.testPanel.Controls.Add(this.editLectureBtn);
            this.testPanel.Location = new System.Drawing.Point(0, 0);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(885, 682);
            this.testPanel.TabIndex = 0;
            // 
            // lectureTable
            // 
            this.lectureTable.AllowUserToAddRows = false;
            this.lectureTable.AllowUserToDeleteRows = false;
            this.lectureTable.AllowUserToResizeColumns = false;
            this.lectureTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.lectureTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lectureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.lectureTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lectureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureName,
            this.professor,
            this.testDay,
            this.testTime,
            this.testName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(12, 69);
            this.lectureTable.MultiSelect = false;
            this.lectureTable.Name = "lectureTable";
            this.lectureTable.ReadOnly = true;
            this.lectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.lectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lectureTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.lectureTable.RowTemplate.Height = 23;
            this.lectureTable.Size = new System.Drawing.Size(862, 601);
            this.lectureTable.TabIndex = 11;
            this.lectureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellClick);
            this.lectureTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellContentClick);
            this.lectureTable.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellLeave);
            // 
            // lectureName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.lectureName.DefaultCellStyle = dataGridViewCellStyle3;
            this.lectureName.FillWeight = 17F;
            this.lectureName.HeaderText = "강의명";
            this.lectureName.Name = "lectureName";
            this.lectureName.ReadOnly = true;
            this.lectureName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // professor
            // 
            this.professor.FillWeight = 5F;
            this.professor.HeaderText = "담당 교수";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            this.professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // testDay
            // 
            this.testDay.FillWeight = 7F;
            this.testDay.HeaderText = "날짜";
            this.testDay.Name = "testDay";
            this.testDay.ReadOnly = true;
            this.testDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // testTime
            // 
            this.testTime.FillWeight = 7F;
            this.testTime.HeaderText = "시간";
            this.testTime.Name = "testTime";
            this.testTime.ReadOnly = true;
            this.testTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // testName
            // 
            this.testName.FillWeight = 15F;
            this.testName.HeaderText = "시험 제목";
            this.testName.Name = "testName";
            this.testName.ReadOnly = true;
            this.testName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // checkScoreBtn
            // 
            this.checkScoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.checkScoreBtn.FlatAppearance.BorderSize = 0;
            this.checkScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkScoreBtn.ForeColor = System.Drawing.Color.White;
            this.checkScoreBtn.Location = new System.Drawing.Point(764, 12);
            this.checkScoreBtn.Name = "checkScoreBtn";
            this.checkScoreBtn.Size = new System.Drawing.Size(110, 34);
            this.checkScoreBtn.TabIndex = 10;
            this.checkScoreBtn.TabStop = false;
            this.checkScoreBtn.Text = "성적 확인";
            this.checkScoreBtn.UseVisualStyleBackColor = false;
            // 
            // editLectureBtn
            // 
            this.editLectureBtn.BackColor = System.Drawing.Color.Gray;
            this.editLectureBtn.FlatAppearance.BorderSize = 0;
            this.editLectureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLectureBtn.ForeColor = System.Drawing.Color.White;
            this.editLectureBtn.Location = new System.Drawing.Point(643, 12);
            this.editLectureBtn.Name = "editLectureBtn";
            this.editLectureBtn.Size = new System.Drawing.Size(110, 34);
            this.editLectureBtn.TabIndex = 9;
            this.editLectureBtn.TabStop = false;
            this.editLectureBtn.Text = "강의 편집";
            this.editLectureBtn.UseVisualStyleBackColor = false;
            this.editLectureBtn.Click += new System.EventHandler(this.editLectureBtn_Click);
            // 
            // myPagePanel
            // 
            this.myPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.myPagePanel.Controls.Add(this.pictureBox);
            this.myPagePanel.Controls.Add(this.emailLabel);
            this.myPagePanel.Controls.Add(this.nameLabel);
            this.myPagePanel.Controls.Add(this.stuNumLabel);
            this.myPagePanel.Controls.Add(this.univLabel);
            this.myPagePanel.Controls.Add(this.editInfoBtn);
            this.myPagePanel.Controls.Add(this.exitButton);
            this.myPagePanel.Controls.Add(this.minimizeButton);
            this.myPagePanel.Location = new System.Drawing.Point(885, 0);
            this.myPagePanel.Name = "myPagePanel";
            this.myPagePanel.Size = new System.Drawing.Size(379, 682);
            this.myPagePanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(23, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(105, 112);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // emailLabel
            // 
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(161, 207);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(208, 21);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "[이메일]";
            // 
            // nameLabel
            // 
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(161, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(208, 21);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "[이름]";
            // 
            // stuNumLabel
            // 
            this.stuNumLabel.ForeColor = System.Drawing.Color.White;
            this.stuNumLabel.Location = new System.Drawing.Point(161, 116);
            this.stuNumLabel.Name = "stuNumLabel";
            this.stuNumLabel.Size = new System.Drawing.Size(208, 21);
            this.stuNumLabel.TabIndex = 13;
            this.stuNumLabel.Text = "[학번]";
            // 
            // univLabel
            // 
            this.univLabel.ForeColor = System.Drawing.Color.White;
            this.univLabel.Location = new System.Drawing.Point(161, 69);
            this.univLabel.Name = "univLabel";
            this.univLabel.Size = new System.Drawing.Size(208, 21);
            this.univLabel.TabIndex = 12;
            this.univLabel.Text = "[학교]";
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.editInfoBtn.FlatAppearance.BorderSize = 0;
            this.editInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editInfoBtn.ForeColor = System.Drawing.Color.White;
            this.editInfoBtn.Location = new System.Drawing.Point(259, 638);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(110, 34);
            this.editInfoBtn.TabIndex = 11;
            this.editInfoBtn.TabStop = false;
            this.editInfoBtn.Text = "정보 수정";
            this.editInfoBtn.UseVisualStyleBackColor = false;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editPanel.Controls.Add(this.editExitButton);
            this.editPanel.Controls.Add(this.editMinimizeButton);
            this.editPanel.Controls.Add(this.editStdNumLabel);
            this.editPanel.Controls.Add(this.editStdNumPanel);
            this.editPanel.Controls.Add(this.editUnivLabel);
            this.editPanel.Controls.Add(this.editUnivPanel);
            this.editPanel.Controls.Add(this.editCancelButton);
            this.editPanel.Controls.Add(this.editButton);
            this.editPanel.Controls.Add(this.editBirthLabel);
            this.editPanel.Controls.Add(this.editPasswordCheckLabel);
            this.editPanel.Controls.Add(this.editBirthPanel);
            this.editPanel.Controls.Add(this.editPasswordLabel);
            this.editPanel.Controls.Add(this.editPasswordCheckPanel);
            this.editPanel.Controls.Add(this.editEmailLabel);
            this.editPanel.Controls.Add(this.editPasswordPanel);
            this.editPanel.Controls.Add(this.editEmailPanel);
            this.editPanel.Controls.Add(this.editNameLabel);
            this.editPanel.Controls.Add(this.editNamePanel);
            this.editPanel.Location = new System.Drawing.Point(885, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(379, 682);
            this.editPanel.TabIndex = 12;
            this.editPanel.Visible = false;
            // 
            // editExitButton
            // 
            this.editExitButton.FlatAppearance.BorderSize = 0;
            this.editExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editExitButton.ForeColor = System.Drawing.Color.White;
            this.editExitButton.Location = new System.Drawing.Point(349, 0);
            this.editExitButton.Name = "editExitButton";
            this.editExitButton.Size = new System.Drawing.Size(30, 28);
            this.editExitButton.TabIndex = 0;
            this.editExitButton.TabStop = false;
            this.editExitButton.Text = "✕";
            this.editExitButton.Click += new System.EventHandler(this.editExitButton_Click);
            // 
            // editMinimizeButton
            // 
            this.editMinimizeButton.FlatAppearance.BorderSize = 0;
            this.editMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.editMinimizeButton.Location = new System.Drawing.Point(319, 0);
            this.editMinimizeButton.Name = "editMinimizeButton";
            this.editMinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.editMinimizeButton.TabIndex = 1;
            this.editMinimizeButton.TabStop = false;
            this.editMinimizeButton.Text = "_";
            this.editMinimizeButton.Click += new System.EventHandler(this.editMinimizeButton_Click);
            // 
            // editStdNumLabel
            // 
            this.editStdNumLabel.ForeColor = System.Drawing.Color.White;
            this.editStdNumLabel.Location = new System.Drawing.Point(72, 135);
            this.editStdNumLabel.Name = "editStdNumLabel";
            this.editStdNumLabel.Size = new System.Drawing.Size(61, 21);
            this.editStdNumLabel.TabIndex = 13;
            this.editStdNumLabel.Text = "학번";
            // 
            // editStdNumPanel
            // 
            this.editStdNumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editStdNumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editStdNumPanel.Controls.Add(this.editStdNumTextBox);
            this.editStdNumPanel.Location = new System.Drawing.Point(72, 160);
            this.editStdNumPanel.Name = "editStdNumPanel";
            this.editStdNumPanel.Size = new System.Drawing.Size(240, 31);
            this.editStdNumPanel.TabIndex = 14;
            // 
            // editStdNumTextBox
            // 
            this.editStdNumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editStdNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editStdNumTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editStdNumTextBox.ForeColor = System.Drawing.Color.White;
            this.editStdNumTextBox.Location = new System.Drawing.Point(6, 4);
            this.editStdNumTextBox.Name = "editStdNumTextBox";
            this.editStdNumTextBox.ReadOnly = true;
            this.editStdNumTextBox.Size = new System.Drawing.Size(230, 19);
            this.editStdNumTextBox.TabIndex = 0;
            // 
            // editUnivLabel
            // 
            this.editUnivLabel.ForeColor = System.Drawing.Color.White;
            this.editUnivLabel.Location = new System.Drawing.Point(72, 68);
            this.editUnivLabel.Name = "editUnivLabel";
            this.editUnivLabel.Size = new System.Drawing.Size(61, 21);
            this.editUnivLabel.TabIndex = 10;
            this.editUnivLabel.Text = "학교";
            // 
            // editUnivPanel
            // 
            this.editUnivPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editUnivPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editUnivPanel.Controls.Add(this.editUnivTextBox);
            this.editUnivPanel.Location = new System.Drawing.Point(72, 93);
            this.editUnivPanel.Name = "editUnivPanel";
            this.editUnivPanel.Size = new System.Drawing.Size(240, 31);
            this.editUnivPanel.TabIndex = 11;
            // 
            // editUnivTextBox
            // 
            this.editUnivTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editUnivTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editUnivTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editUnivTextBox.ForeColor = System.Drawing.Color.White;
            this.editUnivTextBox.Location = new System.Drawing.Point(6, 4);
            this.editUnivTextBox.Name = "editUnivTextBox";
            this.editUnivTextBox.ReadOnly = true;
            this.editUnivTextBox.Size = new System.Drawing.Size(229, 19);
            this.editUnivTextBox.TabIndex = 0;
            // 
            // editCancelButton
            // 
            this.editCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.editCancelButton.FlatAppearance.BorderSize = 0;
            this.editCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCancelButton.ForeColor = System.Drawing.Color.White;
            this.editCancelButton.Location = new System.Drawing.Point(202, 564);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(110, 34);
            this.editCancelButton.TabIndex = 9;
            this.editCancelButton.TabStop = false;
            this.editCancelButton.Text = "취소";
            this.editCancelButton.UseVisualStyleBackColor = false;
            this.editCancelButton.Click += new System.EventHandler(this.editCancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(72, 564);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 34);
            this.editButton.TabIndex = 8;
            this.editButton.TabStop = false;
            this.editButton.Text = "정보 수정";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // editBirthLabel
            // 
            this.editBirthLabel.ForeColor = System.Drawing.Color.White;
            this.editBirthLabel.Location = new System.Drawing.Point(72, 487);
            this.editBirthLabel.Name = "editBirthLabel";
            this.editBirthLabel.Size = new System.Drawing.Size(98, 21);
            this.editBirthLabel.TabIndex = 4;
            this.editBirthLabel.Text = "생년월일";
            // 
            // editPasswordCheckLabel
            // 
            this.editPasswordCheckLabel.ForeColor = System.Drawing.Color.White;
            this.editPasswordCheckLabel.Location = new System.Drawing.Point(72, 417);
            this.editPasswordCheckLabel.Name = "editPasswordCheckLabel";
            this.editPasswordCheckLabel.Size = new System.Drawing.Size(130, 21);
            this.editPasswordCheckLabel.TabIndex = 4;
            this.editPasswordCheckLabel.Text = "비밀번호 확인";
            // 
            // editBirthPanel
            // 
            this.editBirthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editBirthPanel.Controls.Add(this.editBirthPicker);
            this.editBirthPanel.Location = new System.Drawing.Point(72, 516);
            this.editBirthPanel.Name = "editBirthPanel";
            this.editBirthPanel.Size = new System.Drawing.Size(240, 22);
            this.editBirthPanel.TabIndex = 5;
            // 
            // editBirthPicker
            // 
            this.editBirthPicker.CalendarFont = new System.Drawing.Font("굴림", 9F);
            this.editBirthPicker.CustomFormat = "";
            this.editBirthPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.editBirthPicker.Location = new System.Drawing.Point(0, 0);
            this.editBirthPicker.Name = "editBirthPicker";
            this.editBirthPicker.Size = new System.Drawing.Size(238, 21);
            this.editBirthPicker.TabIndex = 0;
            this.editBirthPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // editPasswordLabel
            // 
            this.editPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.editPasswordLabel.Location = new System.Drawing.Point(72, 347);
            this.editPasswordLabel.Name = "editPasswordLabel";
            this.editPasswordLabel.Size = new System.Drawing.Size(83, 21);
            this.editPasswordLabel.TabIndex = 4;
            this.editPasswordLabel.Text = "비밀번호";
            // 
            // editPasswordCheckPanel
            // 
            this.editPasswordCheckPanel.BackColor = System.Drawing.Color.White;
            this.editPasswordCheckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPasswordCheckPanel.Controls.Add(this.editPasswordCheckTextBox);
            this.editPasswordCheckPanel.Location = new System.Drawing.Point(72, 442);
            this.editPasswordCheckPanel.Name = "editPasswordCheckPanel";
            this.editPasswordCheckPanel.Size = new System.Drawing.Size(240, 31);
            this.editPasswordCheckPanel.TabIndex = 5;
            // 
            // editPasswordCheckTextBox
            // 
            this.editPasswordCheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editPasswordCheckTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editPasswordCheckTextBox.Location = new System.Drawing.Point(6, 4);
            this.editPasswordCheckTextBox.Name = "editPasswordCheckTextBox";
            this.editPasswordCheckTextBox.Size = new System.Drawing.Size(230, 19);
            this.editPasswordCheckTextBox.TabIndex = 0;
            this.editPasswordCheckTextBox.UseSystemPasswordChar = true;
            // 
            // editEmailLabel
            // 
            this.editEmailLabel.ForeColor = System.Drawing.Color.White;
            this.editEmailLabel.Location = new System.Drawing.Point(72, 274);
            this.editEmailLabel.Name = "editEmailLabel";
            this.editEmailLabel.Size = new System.Drawing.Size(61, 21);
            this.editEmailLabel.TabIndex = 6;
            this.editEmailLabel.Text = "이메일";
            // 
            // editPasswordPanel
            // 
            this.editPasswordPanel.BackColor = System.Drawing.Color.White;
            this.editPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPasswordPanel.Controls.Add(this.editPasswordTextBox);
            this.editPasswordPanel.Location = new System.Drawing.Point(72, 372);
            this.editPasswordPanel.Name = "editPasswordPanel";
            this.editPasswordPanel.Size = new System.Drawing.Size(240, 31);
            this.editPasswordPanel.TabIndex = 5;
            // 
            // editPasswordTextBox
            // 
            this.editPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editPasswordTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editPasswordTextBox.Location = new System.Drawing.Point(6, 4);
            this.editPasswordTextBox.Name = "editPasswordTextBox";
            this.editPasswordTextBox.Size = new System.Drawing.Size(230, 19);
            this.editPasswordTextBox.TabIndex = 0;
            this.editPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // editEmailPanel
            // 
            this.editEmailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editEmailPanel.Controls.Add(this.editEmailTextBox);
            this.editEmailPanel.Location = new System.Drawing.Point(72, 299);
            this.editEmailPanel.Name = "editEmailPanel";
            this.editEmailPanel.Size = new System.Drawing.Size(240, 31);
            this.editEmailPanel.TabIndex = 7;
            // 
            // editEmailTextBox
            // 
            this.editEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.editEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editEmailTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editEmailTextBox.ForeColor = System.Drawing.Color.White;
            this.editEmailTextBox.Location = new System.Drawing.Point(6, 4);
            this.editEmailTextBox.Name = "editEmailTextBox";
            this.editEmailTextBox.ReadOnly = true;
            this.editEmailTextBox.Size = new System.Drawing.Size(230, 19);
            this.editEmailTextBox.TabIndex = 0;
            // 
            // editNameLabel
            // 
            this.editNameLabel.ForeColor = System.Drawing.Color.White;
            this.editNameLabel.Location = new System.Drawing.Point(72, 204);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(61, 21);
            this.editNameLabel.TabIndex = 4;
            this.editNameLabel.Text = "이름";
            // 
            // editNamePanel
            // 
            this.editNamePanel.BackColor = System.Drawing.Color.White;
            this.editNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editNamePanel.Controls.Add(this.editNameTextBox);
            this.editNamePanel.Location = new System.Drawing.Point(72, 229);
            this.editNamePanel.Name = "editNamePanel";
            this.editNamePanel.Size = new System.Drawing.Size(240, 31);
            this.editNamePanel.TabIndex = 5;
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editNameTextBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editNameTextBox.Location = new System.Drawing.Point(6, 4);
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(230, 19);
            this.editNameTextBox.TabIndex = 0;
            // 
            // StudentHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "StudentHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHomeView";
            this.Load += new System.EventHandler(this.StudentHomeView_Load);
            this.mainPanel.ResumeLayout(false);
            this.cameraPanel.ResumeLayout(false);
            this.cameraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.testInfoPanel.ResumeLayout(false);
            this.testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).EndInit();
            this.myPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editStdNumPanel.ResumeLayout(false);
            this.editStdNumPanel.PerformLayout();
            this.editUnivPanel.ResumeLayout(false);
            this.editUnivPanel.PerformLayout();
            this.editBirthPanel.ResumeLayout(false);
            this.editPasswordCheckPanel.ResumeLayout(false);
            this.editPasswordCheckPanel.PerformLayout();
            this.editPasswordPanel.ResumeLayout(false);
            this.editPasswordPanel.PerformLayout();
            this.editEmailPanel.ResumeLayout(false);
            this.editEmailPanel.PerformLayout();
            this.editNamePanel.ResumeLayout(false);
            this.editNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Panel myPagePanel;
        private Button checkScoreBtn;
        private Button editLectureBtn;
        private Button editInfoBtn;
        private DataGridView lectureTable;
        private Label nameLabel;
        private Label stuNumLabel;
        private Label univLabel;
        private Label emailLabel;
        private PictureBox pictureBox;
        private Panel editPanel;
        private Button editExitButton;
        private Button editMinimizeButton;
        private Label editStdNumLabel;
        private Panel editStdNumPanel;
        private TextBox editStdNumTextBox;
        private Label editUnivLabel;
        private Panel editUnivPanel;
        private TextBox editUnivTextBox;
        private Button editCancelButton;
        private Button editButton;
        private Label editBirthLabel;
        private Label editPasswordCheckLabel;
        private Panel editBirthPanel;
        private DateTimePicker editBirthPicker;
        private Label editPasswordLabel;
        private Panel editPasswordCheckPanel;
        private TextBox editPasswordCheckTextBox;
        private Label editEmailLabel;
        private Panel editPasswordPanel;
        private TextBox editPasswordTextBox;
        private Panel editEmailPanel;
        private TextBox editEmailTextBox;
        private Label editNameLabel;
        private Panel editNamePanel;
        private TextBox editNameTextBox;
        private DataGridViewTextBoxColumn lectureName;
        private DataGridViewTextBoxColumn professor;
        private DataGridViewTextBoxColumn testDay;
        private DataGridViewTextBoxColumn testTime;
        private DataGridViewTextBoxColumn testName;
        private Panel testInfoPanel;
        private Label testInfoTimeLbl;
        private Label testInfoDayLbl;
        private Label testInfoProfNameLbl;
        private Label testInfoLectureLbl;
        private Button testStartBtn;
        private Button testInfoExitBtn;
        private Button testInfoMinimizeBtn;
        private Label testInfoTestNameLbl;
        private Button testInfoCancelBtn;
        private Panel cameraPanel;
        private Label cameraLabel;
        private PictureBox cameraPictureBox;
        private Button cameraCancelBtn;
    }
}