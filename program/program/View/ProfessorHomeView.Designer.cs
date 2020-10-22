namespace program.View
{
    partial class ProfessorHomeView
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.checkScoreBtn = new System.Windows.Forms.Button();
            this.testAddBtn = new System.Windows.Forms.Button();
            this.editLectureBtn = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
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
            this.myPagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.univLabel = new System.Windows.Forms.Label();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.lectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mainPanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.editPanel.SuspendLayout();
            this.editUnivPanel.SuspendLayout();
            this.editBirthPanel.SuspendLayout();
            this.editPasswordCheckPanel.SuspendLayout();
            this.editPasswordPanel.SuspendLayout();
            this.editEmailPanel.SuspendLayout();
            this.editNamePanel.SuspendLayout();
            this.myPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.testPanel);
            this.mainPanel.Controls.Add(this.editPanel);
            this.mainPanel.Controls.Add(this.myPagePanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 1;
            // 
            // testPanel
            // 
            this.testPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.testPanel.Controls.Add(this.lectureTable);
            this.testPanel.Controls.Add(this.checkScoreBtn);
            this.testPanel.Controls.Add(this.testAddBtn);
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
            this.testName,
            this.editBtn,
            this.deleteColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(12, 61);
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
            this.lectureTable.Size = new System.Drawing.Size(862, 581);
            this.lectureTable.TabIndex = 12;
            this.lectureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellClick);
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
            this.checkScoreBtn.Click += new System.EventHandler(this.checkScoreBtn_Click);
            // 
            // testAddBtn
            // 
            this.testAddBtn.BackColor = System.Drawing.Color.Gray;
            this.testAddBtn.FlatAppearance.BorderSize = 0;
            this.testAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testAddBtn.ForeColor = System.Drawing.Color.White;
            this.testAddBtn.Location = new System.Drawing.Point(520, 12);
            this.testAddBtn.Name = "testAddBtn";
            this.testAddBtn.Size = new System.Drawing.Size(110, 34);
            this.testAddBtn.TabIndex = 9;
            this.testAddBtn.TabStop = false;
            this.testAddBtn.Text = "시험 추가";
            this.testAddBtn.UseVisualStyleBackColor = false;
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
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
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
            this.editPanel.Size = new System.Drawing.Size(379, 654);
            this.editPanel.TabIndex = 12;
            this.editPanel.Visible = false;
            // 
            // editUnivLabel
            // 
            this.editUnivLabel.ForeColor = System.Drawing.Color.White;
            this.editUnivLabel.Location = new System.Drawing.Point(72, 63);
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
            this.editUnivPanel.Location = new System.Drawing.Point(72, 88);
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
            this.editCancelButton.Location = new System.Drawing.Point(202, 558);
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
            this.editButton.Location = new System.Drawing.Point(72, 558);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 34);
            this.editButton.TabIndex = 8;
            this.editButton.TabStop = false;
            this.editButton.Text = "정보 수정";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editBirthLabel
            // 
            this.editBirthLabel.ForeColor = System.Drawing.Color.White;
            this.editBirthLabel.Location = new System.Drawing.Point(72, 477);
            this.editBirthLabel.Name = "editBirthLabel";
            this.editBirthLabel.Size = new System.Drawing.Size(98, 21);
            this.editBirthLabel.TabIndex = 4;
            this.editBirthLabel.Text = "생년월일";
            // 
            // editPasswordCheckLabel
            // 
            this.editPasswordCheckLabel.ForeColor = System.Drawing.Color.White;
            this.editPasswordCheckLabel.Location = new System.Drawing.Point(72, 394);
            this.editPasswordCheckLabel.Name = "editPasswordCheckLabel";
            this.editPasswordCheckLabel.Size = new System.Drawing.Size(130, 21);
            this.editPasswordCheckLabel.TabIndex = 4;
            this.editPasswordCheckLabel.Text = "비밀번호 확인";
            // 
            // editBirthPanel
            // 
            this.editBirthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editBirthPanel.Controls.Add(this.editBirthPicker);
            this.editBirthPanel.Location = new System.Drawing.Point(72, 506);
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
            this.editPasswordLabel.Location = new System.Drawing.Point(72, 310);
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
            this.editPasswordCheckPanel.Location = new System.Drawing.Point(72, 419);
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
            this.editEmailLabel.Location = new System.Drawing.Point(72, 228);
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
            this.editPasswordPanel.Location = new System.Drawing.Point(72, 335);
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
            this.editEmailPanel.Location = new System.Drawing.Point(72, 253);
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
            this.editNameLabel.Location = new System.Drawing.Point(72, 148);
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
            this.editNamePanel.Location = new System.Drawing.Point(72, 173);
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
            // myPagePanel
            // 
            this.myPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.myPagePanel.Controls.Add(this.pictureBox);
            this.myPagePanel.Controls.Add(this.emailLabel);
            this.myPagePanel.Controls.Add(this.nameLabel);
            this.myPagePanel.Controls.Add(this.univLabel);
            this.myPagePanel.Controls.Add(this.editInfoBtn);
            this.myPagePanel.Location = new System.Drawing.Point(885, 0);
            this.myPagePanel.Name = "myPagePanel";
            this.myPagePanel.Size = new System.Drawing.Size(379, 654);
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
            this.emailLabel.Location = new System.Drawing.Point(161, 169);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(208, 21);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "[이메일]";
            // 
            // nameLabel
            // 
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(161, 119);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(208, 21);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "[이름]";
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
            this.editInfoBtn.Location = new System.Drawing.Point(259, 608);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(110, 34);
            this.editInfoBtn.TabIndex = 11;
            this.editInfoBtn.TabStop = false;
            this.editInfoBtn.Text = "정보 수정";
            this.editInfoBtn.UseVisualStyleBackColor = false;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
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
            this.professor.FillWeight = 6F;
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
            // editBtn
            // 
            this.editBtn.FillWeight = 5F;
            this.editBtn.HeaderText = "   ";
            this.editBtn.Name = "editBtn";
            this.editBtn.ReadOnly = true;
            this.editBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editBtn.Text = "수정";
            this.editBtn.ToolTipText = "수정";
            this.editBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteColumn.FillWeight = 5F;
            this.deleteColumn.HeaderText = "  ";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "삭제";
            this.deleteColumn.ToolTipText = "삭제";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // ProfessorHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProfessorHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorHomeView";
            this.Load += new System.EventHandler(this.ProfessorHomeView_Load);
            this.mainPanel.ResumeLayout(false);
            this.testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).EndInit();
            this.editPanel.ResumeLayout(false);
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
            this.myPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Button checkScoreBtn;
        private System.Windows.Forms.Button editLectureBtn;
        private System.Windows.Forms.Panel myPagePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label univLabel;
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label editUnivLabel;
        private System.Windows.Forms.Panel editUnivPanel;
        private System.Windows.Forms.TextBox editUnivTextBox;
        private System.Windows.Forms.Button editCancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label editBirthLabel;
        private System.Windows.Forms.Label editPasswordCheckLabel;
        private System.Windows.Forms.Panel editBirthPanel;
        private System.Windows.Forms.DateTimePicker editBirthPicker;
        private System.Windows.Forms.Label editPasswordLabel;
        private System.Windows.Forms.Panel editPasswordCheckPanel;
        private System.Windows.Forms.TextBox editPasswordCheckTextBox;
        private System.Windows.Forms.Label editEmailLabel;
        private System.Windows.Forms.Panel editPasswordPanel;
        private System.Windows.Forms.TextBox editPasswordTextBox;
        private System.Windows.Forms.Panel editEmailPanel;
        private System.Windows.Forms.TextBox editEmailTextBox;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Panel editNamePanel;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.DataGridView lectureTable;
        private System.Windows.Forms.Button testAddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn testName;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}