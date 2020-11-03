namespace program.View
{
    partial class StudentLectureEditView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.myLecturePanel = new System.Windows.Forms.Panel();
            this.myLectureTable = new System.Windows.Forms.DataGridView();
            this.myLectureCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLectureLbl = new System.Windows.Forms.Label();
            this.lecturePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteLectureBtn = new System.Windows.Forms.Button();
            this.lecturePanel = new System.Windows.Forms.Panel();
            this.lectureNamePanel = new System.Windows.Forms.Panel();
            this.lectureNameTxtBox = new System.Windows.Forms.TextBox();
            this.lectureNameLbl = new System.Windows.Forms.Label();
            this.professorNameLbl = new System.Windows.Forms.Label();
            this.professorNamePanel = new System.Windows.Forms.Panel();
            this.professorNameTxtBox = new System.Windows.Forms.TextBox();
            this.addLectureBtn = new System.Windows.Forms.Button();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.myLecturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLectureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturePictureBox)).BeginInit();
            this.lecturePanel.SuspendLayout();
            this.lectureNamePanel.SuspendLayout();
            this.professorNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1234, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "✕";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(1204, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 28);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.myLecturePanel);
            this.mainPanel.Controls.Add(this.lecturePanel);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.minimizeButton);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 4;
            // 
            // myLecturePanel
            // 
            this.myLecturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.myLecturePanel.Controls.Add(this.exitBtn);
            this.myLecturePanel.Controls.Add(this.myLectureTable);
            this.myLecturePanel.Controls.Add(this.myLectureLbl);
            this.myLecturePanel.Controls.Add(this.lecturePictureBox);
            this.myLecturePanel.Controls.Add(this.deleteLectureBtn);
            this.myLecturePanel.Location = new System.Drawing.Point(885, 0);
            this.myLecturePanel.Name = "myLecturePanel";
            this.myLecturePanel.Size = new System.Drawing.Size(379, 655);
            this.myLecturePanel.TabIndex = 20;
            // 
            // myLectureTable
            // 
            this.myLectureTable.AllowUserToAddRows = false;
            this.myLectureTable.AllowUserToDeleteRows = false;
            this.myLectureTable.AllowUserToResizeColumns = false;
            this.myLectureTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            this.myLectureTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.myLectureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myLectureTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.myLectureTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myLectureTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myLectureTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.myLectureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myLectureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.myLectureCheckBox,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myLectureTable.DefaultCellStyle = dataGridViewCellStyle16;
            this.myLectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.myLectureTable.Location = new System.Drawing.Point(20, 153);
            this.myLectureTable.MultiSelect = false;
            this.myLectureTable.Name = "myLectureTable";
            this.myLectureTable.ReadOnly = true;
            this.myLectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myLectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.myLectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myLectureTable.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.myLectureTable.RowTemplate.Height = 23;
            this.myLectureTable.Size = new System.Drawing.Size(343, 441);
            this.myLectureTable.TabIndex = 16;
            this.myLectureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myLectureTable_CellClick);
            // 
            // myLectureCheckBox
            // 
            this.myLectureCheckBox.FillWeight = 2F;
            this.myLectureCheckBox.HeaderText = "";
            this.myLectureCheckBox.Name = "myLectureCheckBox";
            this.myLectureCheckBox.ReadOnly = true;
            this.myLectureCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.myLectureCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn1.FillWeight = 17F;
            this.dataGridViewTextBoxColumn1.HeaderText = "강의명";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 5F;
            this.dataGridViewTextBoxColumn2.HeaderText = "담당 교수";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 7F;
            this.dataGridViewTextBoxColumn4.HeaderText = "시간";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // myLectureLbl
            // 
            this.myLectureLbl.AutoSize = true;
            this.myLectureLbl.ForeColor = System.Drawing.Color.White;
            this.myLectureLbl.Location = new System.Drawing.Point(99, 89);
            this.myLectureLbl.Name = "myLectureLbl";
            this.myLectureLbl.Size = new System.Drawing.Size(85, 12);
            this.myLectureLbl.TabIndex = 16;
            this.myLectureLbl.Text = "수강 중인 강의";
            // 
            // lecturePictureBox
            // 
            this.lecturePictureBox.Location = new System.Drawing.Point(32, 77);
            this.lecturePictureBox.Name = "lecturePictureBox";
            this.lecturePictureBox.Size = new System.Drawing.Size(50, 50);
            this.lecturePictureBox.TabIndex = 16;
            this.lecturePictureBox.TabStop = false;
            // 
            // deleteLectureBtn
            // 
            this.deleteLectureBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteLectureBtn.FlatAppearance.BorderSize = 0;
            this.deleteLectureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLectureBtn.ForeColor = System.Drawing.Color.White;
            this.deleteLectureBtn.Location = new System.Drawing.Point(141, 608);
            this.deleteLectureBtn.Name = "deleteLectureBtn";
            this.deleteLectureBtn.Size = new System.Drawing.Size(110, 34);
            this.deleteLectureBtn.TabIndex = 13;
            this.deleteLectureBtn.TabStop = false;
            this.deleteLectureBtn.Text = "강의 삭제";
            this.deleteLectureBtn.UseVisualStyleBackColor = false;
            this.deleteLectureBtn.Click += new System.EventHandler(this.deleteLectureBtn_Click);
            // 
            // lecturePanel
            // 
            this.lecturePanel.BackColor = System.Drawing.Color.White;
            this.lecturePanel.Controls.Add(this.lectureNamePanel);
            this.lecturePanel.Controls.Add(this.lectureNameLbl);
            this.lecturePanel.Controls.Add(this.professorNameLbl);
            this.lecturePanel.Controls.Add(this.professorNamePanel);
            this.lecturePanel.Controls.Add(this.addLectureBtn);
            this.lecturePanel.Controls.Add(this.lectureTable);
            this.lecturePanel.Controls.Add(this.searchBtn);
            this.lecturePanel.Location = new System.Drawing.Point(0, 0);
            this.lecturePanel.Name = "lecturePanel";
            this.lecturePanel.Size = new System.Drawing.Size(885, 655);
            this.lecturePanel.TabIndex = 5;
            // 
            // lectureNamePanel
            // 
            this.lectureNamePanel.BackColor = System.Drawing.Color.White;
            this.lectureNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lectureNamePanel.Controls.Add(this.lectureNameTxtBox);
            this.lectureNamePanel.Location = new System.Drawing.Point(429, 32);
            this.lectureNamePanel.Name = "lectureNamePanel";
            this.lectureNamePanel.Size = new System.Drawing.Size(282, 34);
            this.lectureNamePanel.TabIndex = 13;
            // 
            // lectureNameTxtBox
            // 
            this.lectureNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureNameTxtBox.Font = new System.Drawing.Font("굴림", 16F);
            this.lectureNameTxtBox.Location = new System.Drawing.Point(5, 5);
            this.lectureNameTxtBox.Name = "lectureNameTxtBox";
            this.lectureNameTxtBox.Size = new System.Drawing.Size(274, 25);
            this.lectureNameTxtBox.TabIndex = 0;
            this.lectureNameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lectureNameTxtBox_KeyDown);
            // 
            // lectureNameLbl
            // 
            this.lectureNameLbl.AutoSize = true;
            this.lectureNameLbl.Location = new System.Drawing.Point(357, 39);
            this.lectureNameLbl.Name = "lectureNameLbl";
            this.lectureNameLbl.Size = new System.Drawing.Size(41, 12);
            this.lectureNameLbl.TabIndex = 14;
            this.lectureNameLbl.Text = "강의명";
            // 
            // professorNameLbl
            // 
            this.professorNameLbl.AutoSize = true;
            this.professorNameLbl.Location = new System.Drawing.Point(101, 39);
            this.professorNameLbl.Name = "professorNameLbl";
            this.professorNameLbl.Size = new System.Drawing.Size(41, 12);
            this.professorNameLbl.TabIndex = 13;
            this.professorNameLbl.Text = "교수명";
            // 
            // professorNamePanel
            // 
            this.professorNamePanel.BackColor = System.Drawing.Color.White;
            this.professorNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.professorNamePanel.Controls.Add(this.professorNameTxtBox);
            this.professorNamePanel.Location = new System.Drawing.Point(176, 32);
            this.professorNamePanel.Name = "professorNamePanel";
            this.professorNamePanel.Size = new System.Drawing.Size(146, 34);
            this.professorNamePanel.TabIndex = 12;
            // 
            // professorNameTxtBox
            // 
            this.professorNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.professorNameTxtBox.Font = new System.Drawing.Font("굴림", 16F);
            this.professorNameTxtBox.Location = new System.Drawing.Point(5, 5);
            this.professorNameTxtBox.Name = "professorNameTxtBox";
            this.professorNameTxtBox.Size = new System.Drawing.Size(138, 25);
            this.professorNameTxtBox.TabIndex = 0;
            this.professorNameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.professorNameTxtBox_KeyDown);
            // 
            // addLectureBtn
            // 
            this.addLectureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.addLectureBtn.FlatAppearance.BorderSize = 0;
            this.addLectureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLectureBtn.ForeColor = System.Drawing.Color.White;
            this.addLectureBtn.Location = new System.Drawing.Point(764, 608);
            this.addLectureBtn.Name = "addLectureBtn";
            this.addLectureBtn.Size = new System.Drawing.Size(110, 34);
            this.addLectureBtn.TabIndex = 12;
            this.addLectureBtn.TabStop = false;
            this.addLectureBtn.Text = "강의 추가";
            this.addLectureBtn.UseVisualStyleBackColor = false;
            this.addLectureBtn.Click += new System.EventHandler(this.addLectureBtn_Click);
            // 
            // lectureTable
            // 
            this.lectureTable.AllowUserToAddRows = false;
            this.lectureTable.AllowUserToDeleteRows = false;
            this.lectureTable.AllowUserToResizeColumns = false;
            this.lectureTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            this.lectureTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.lectureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureTable.BackgroundColor = System.Drawing.Color.White;
            this.lectureTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.lectureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.lectureName,
            this.professor,
            this.testTime,
            this.testName});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle22;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(12, 101);
            this.lectureTable.MultiSelect = false;
            this.lectureTable.Name = "lectureTable";
            this.lectureTable.ReadOnly = true;
            this.lectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.lectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lectureTable.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.lectureTable.RowTemplate.Height = 23;
            this.lectureTable.Size = new System.Drawing.Size(862, 493);
            this.lectureTable.TabIndex = 11;
            this.lectureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellClick);
            // 
            // checkBox
            // 
            this.checkBox.FillWeight = 0.1403889F;
            this.checkBox.HeaderText = "";
            this.checkBox.Name = "checkBox";
            this.checkBox.ReadOnly = true;
            this.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lectureName
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.lectureName.DefaultCellStyle = dataGridViewCellStyle21;
            this.lectureName.FillWeight = 0.2193597F;
            this.lectureName.HeaderText = "강의명";
            this.lectureName.Name = "lectureName";
            this.lectureName.ReadOnly = true;
            this.lectureName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // professor
            // 
            this.professor.FillWeight = 0.3202531F;
            this.professor.HeaderText = "담당 교수";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            this.professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // testTime
            // 
            this.testTime.FillWeight = 0.5092764F;
            this.testTime.HeaderText = "시간";
            this.testTime.Name = "testTime";
            this.testTime.ReadOnly = true;
            this.testTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // testName
            // 
            this.testName.FillWeight = 0.1935527F;
            this.testName.HeaderText = "년도-학기";
            this.testName.Name = "testName";
            this.testName.ReadOnly = true;
            this.testName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(764, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 34);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(257, 607);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 34);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "나가기";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StudentLectureEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "StudentLectureEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLectureEditView";
            this.Load += new System.EventHandler(this.StudentLectureEditView_Load);
            this.mainPanel.ResumeLayout(false);
            this.myLecturePanel.ResumeLayout(false);
            this.myLecturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLectureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturePictureBox)).EndInit();
            this.lecturePanel.ResumeLayout(false);
            this.lecturePanel.PerformLayout();
            this.lectureNamePanel.ResumeLayout(false);
            this.lectureNamePanel.PerformLayout();
            this.professorNamePanel.ResumeLayout(false);
            this.professorNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel lecturePanel;
        private System.Windows.Forms.DataGridView lectureTable;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel myLecturePanel;
        private System.Windows.Forms.Button addLectureBtn;
        private System.Windows.Forms.Button deleteLectureBtn;
        private System.Windows.Forms.Panel professorNamePanel;
        private System.Windows.Forms.TextBox professorNameTxtBox;
        private System.Windows.Forms.Label professorNameLbl;
        private System.Windows.Forms.Label lectureNameLbl;
        private System.Windows.Forms.Panel lectureNamePanel;
        private System.Windows.Forms.TextBox lectureNameTxtBox;
        private System.Windows.Forms.PictureBox lecturePictureBox;
        private System.Windows.Forms.Label myLectureLbl;
        private System.Windows.Forms.DataGridView myLectureTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn myLectureCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn testName;
        private System.Windows.Forms.Button exitBtn;
    }
}