namespace program.View
{
    partial class ProfessorLectureEditView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myLecturePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.myLectureTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myLectureLbl = new System.Windows.Forms.Label();
            this.lecturePictureBox = new System.Windows.Forms.PictureBox();
            this.addLectureBtn = new System.Windows.Forms.Button();
            this.editLecturePanel = new System.Windows.Forms.Panel();
            this.infoLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.lectureTotalStudentPanel = new System.Windows.Forms.Panel();
            this.lectureTotalStudentTextBox = new System.Windows.Forms.TextBox();
            this.lectureTimePanel = new System.Windows.Forms.Panel();
            this.lectureTimeTextBox = new System.Windows.Forms.TextBox();
            this.lectureNamePanel = new System.Windows.Forms.Panel();
            this.lectureNameTextBox = new System.Windows.Forms.TextBox();
            this.lectureSemesterLbl = new System.Windows.Forms.Label();
            this.lectureTotalStuentLbl = new System.Windows.Forms.Label();
            this.lectureTimeLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.lectureNameLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.myLecturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLectureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturePictureBox)).BeginInit();
            this.editLecturePanel.SuspendLayout();
            this.lectureTotalStudentPanel.SuspendLayout();
            this.lectureTimePanel.SuspendLayout();
            this.lectureNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // myLecturePanel
            // 
            this.myLecturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.myLecturePanel.Controls.Add(this.button1);
            this.myLecturePanel.Controls.Add(this.backButton);
            this.myLecturePanel.Controls.Add(this.myLectureTable);
            this.myLecturePanel.Controls.Add(this.myLectureLbl);
            this.myLecturePanel.Controls.Add(this.lecturePictureBox);
            this.myLecturePanel.Location = new System.Drawing.Point(0, 28);
            this.myLecturePanel.Name = "myLecturePanel";
            this.myLecturePanel.Size = new System.Drawing.Size(843, 653);
            this.myLecturePanel.TabIndex = 21;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 41);
            this.backButton.TabIndex = 17;
            this.backButton.TabStop = false;
            this.backButton.Text = "◀";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // myLectureTable
            // 
            this.myLectureTable.AllowUserToAddRows = false;
            this.myLectureTable.AllowUserToDeleteRows = false;
            this.myLectureTable.AllowUserToResizeColumns = false;
            this.myLectureTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            this.myLectureTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.myLectureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myLectureTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.myLectureTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myLectureTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myLectureTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.myLectureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myLectureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.lectureSemester});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myLectureTable.DefaultCellStyle = dataGridViewCellStyle22;
            this.myLectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.myLectureTable.Location = new System.Drawing.Point(20, 124);
            this.myLectureTable.MultiSelect = false;
            this.myLectureTable.Name = "myLectureTable";
            this.myLectureTable.ReadOnly = true;
            this.myLectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myLectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.myLectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myLectureTable.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.myLectureTable.RowTemplate.Height = 23;
            this.myLectureTable.Size = new System.Drawing.Size(801, 479);
            this.myLectureTable.TabIndex = 16;
            this.myLectureTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myLectureTable_CellClick);
            this.myLectureTable.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.myLectureTable_CellLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn1.FillWeight = 13F;
            this.dataGridViewTextBoxColumn1.HeaderText = "강의명";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 13F;
            this.dataGridViewTextBoxColumn2.HeaderText = "강의 시간";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 6F;
            this.dataGridViewTextBoxColumn4.HeaderText = "수강 학생 인원";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lectureSemester
            // 
            this.lectureSemester.FillWeight = 6F;
            this.lectureSemester.HeaderText = "강의년도-학기";
            this.lectureSemester.Name = "lectureSemester";
            this.lectureSemester.ReadOnly = true;
            // 
            // myLectureLbl
            // 
            this.myLectureLbl.AutoSize = true;
            this.myLectureLbl.ForeColor = System.Drawing.Color.White;
            this.myLectureLbl.Location = new System.Drawing.Point(100, 67);
            this.myLectureLbl.Name = "myLectureLbl";
            this.myLectureLbl.Size = new System.Drawing.Size(85, 12);
            this.myLectureLbl.TabIndex = 16;
            this.myLectureLbl.Text = "담당 강의 목록";
            // 
            // lecturePictureBox
            // 
            this.lecturePictureBox.Location = new System.Drawing.Point(33, 55);
            this.lecturePictureBox.Name = "lecturePictureBox";
            this.lecturePictureBox.Size = new System.Drawing.Size(50, 50);
            this.lecturePictureBox.TabIndex = 16;
            this.lecturePictureBox.TabStop = false;
            // 
            // addLectureBtn
            // 
            this.addLectureBtn.BackColor = System.Drawing.Color.Gray;
            this.addLectureBtn.FlatAppearance.BorderSize = 0;
            this.addLectureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLectureBtn.ForeColor = System.Drawing.Color.White;
            this.addLectureBtn.Location = new System.Drawing.Point(41, 511);
            this.addLectureBtn.Name = "addLectureBtn";
            this.addLectureBtn.Size = new System.Drawing.Size(110, 34);
            this.addLectureBtn.TabIndex = 13;
            this.addLectureBtn.TabStop = false;
            this.addLectureBtn.Text = "강의 추가";
            this.addLectureBtn.UseVisualStyleBackColor = false;
            this.addLectureBtn.Click += new System.EventHandler(this.addLectureBtn_Click);
            // 
            // editLecturePanel
            // 
            this.editLecturePanel.BackColor = System.Drawing.Color.White;
            this.editLecturePanel.Controls.Add(this.yearComboBox);
            this.editLecturePanel.Controls.Add(this.semesterComboBox);
            this.editLecturePanel.Controls.Add(this.infoLbl);
            this.editLecturePanel.Controls.Add(this.confirmBtn);
            this.editLecturePanel.Controls.Add(this.lectureTotalStudentPanel);
            this.editLecturePanel.Controls.Add(this.addLectureBtn);
            this.editLecturePanel.Controls.Add(this.lectureTimePanel);
            this.editLecturePanel.Controls.Add(this.lectureNamePanel);
            this.editLecturePanel.Controls.Add(this.lectureSemesterLbl);
            this.editLecturePanel.Controls.Add(this.lectureTotalStuentLbl);
            this.editLecturePanel.Controls.Add(this.lectureTimeLbl);
            this.editLecturePanel.Controls.Add(this.editBtn);
            this.editLecturePanel.Controls.Add(this.lectureNameLbl);
            this.editLecturePanel.Controls.Add(this.deleteBtn);
            this.editLecturePanel.Location = new System.Drawing.Point(843, 28);
            this.editLecturePanel.Name = "editLecturePanel";
            this.editLecturePanel.Size = new System.Drawing.Size(421, 653);
            this.editLecturePanel.TabIndex = 22;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(150, 477);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(117, 12);
            this.infoLbl.TabIndex = 25;
            this.infoLbl.Text = "버튼을 선택해주세요";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(157, 582);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(110, 34);
            this.confirmBtn.TabIndex = 24;
            this.confirmBtn.TabStop = false;
            this.confirmBtn.Text = "확인버튼";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // lectureTotalStudentPanel
            // 
            this.lectureTotalStudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lectureTotalStudentPanel.Controls.Add(this.lectureTotalStudentTextBox);
            this.lectureTotalStudentPanel.Location = new System.Drawing.Point(60, 258);
            this.lectureTotalStudentPanel.Name = "lectureTotalStudentPanel";
            this.lectureTotalStudentPanel.Size = new System.Drawing.Size(309, 31);
            this.lectureTotalStudentPanel.TabIndex = 23;
            // 
            // lectureTotalStudentTextBox
            // 
            this.lectureTotalStudentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureTotalStudentTextBox.Location = new System.Drawing.Point(6, 7);
            this.lectureTotalStudentTextBox.Name = "lectureTotalStudentTextBox";
            this.lectureTotalStudentTextBox.Size = new System.Drawing.Size(294, 14);
            this.lectureTotalStudentTextBox.TabIndex = 0;
            // 
            // lectureTimePanel
            // 
            this.lectureTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lectureTimePanel.Controls.Add(this.lectureTimeTextBox);
            this.lectureTimePanel.Location = new System.Drawing.Point(60, 187);
            this.lectureTimePanel.Name = "lectureTimePanel";
            this.lectureTimePanel.Size = new System.Drawing.Size(309, 31);
            this.lectureTimePanel.TabIndex = 23;
            // 
            // lectureTimeTextBox
            // 
            this.lectureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureTimeTextBox.Location = new System.Drawing.Point(6, 7);
            this.lectureTimeTextBox.Name = "lectureTimeTextBox";
            this.lectureTimeTextBox.Size = new System.Drawing.Size(294, 14);
            this.lectureTimeTextBox.TabIndex = 0;
            // 
            // lectureNamePanel
            // 
            this.lectureNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lectureNamePanel.Controls.Add(this.lectureNameTextBox);
            this.lectureNamePanel.Location = new System.Drawing.Point(60, 110);
            this.lectureNamePanel.Name = "lectureNamePanel";
            this.lectureNamePanel.Size = new System.Drawing.Size(309, 31);
            this.lectureNamePanel.TabIndex = 22;
            // 
            // lectureNameTextBox
            // 
            this.lectureNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureNameTextBox.Location = new System.Drawing.Point(6, 7);
            this.lectureNameTextBox.Name = "lectureNameTextBox";
            this.lectureNameTextBox.Size = new System.Drawing.Size(294, 14);
            this.lectureNameTextBox.TabIndex = 0;
            // 
            // lectureSemesterLbl
            // 
            this.lectureSemesterLbl.AutoSize = true;
            this.lectureSemesterLbl.BackColor = System.Drawing.Color.White;
            this.lectureSemesterLbl.ForeColor = System.Drawing.Color.Black;
            this.lectureSemesterLbl.Location = new System.Drawing.Point(64, 314);
            this.lectureSemesterLbl.Name = "lectureSemesterLbl";
            this.lectureSemesterLbl.Size = new System.Drawing.Size(87, 12);
            this.lectureSemesterLbl.TabIndex = 21;
            this.lectureSemesterLbl.Text = "강의 년도-학기";
            // 
            // lectureTotalStuentLbl
            // 
            this.lectureTotalStuentLbl.AutoSize = true;
            this.lectureTotalStuentLbl.BackColor = System.Drawing.Color.White;
            this.lectureTotalStuentLbl.ForeColor = System.Drawing.Color.Black;
            this.lectureTotalStuentLbl.Location = new System.Drawing.Point(64, 233);
            this.lectureTotalStuentLbl.Name = "lectureTotalStuentLbl";
            this.lectureTotalStuentLbl.Size = new System.Drawing.Size(85, 12);
            this.lectureTotalStuentLbl.TabIndex = 19;
            this.lectureTotalStuentLbl.Text = "수강 학생 인원";
            // 
            // lectureTimeLbl
            // 
            this.lectureTimeLbl.AutoSize = true;
            this.lectureTimeLbl.BackColor = System.Drawing.Color.White;
            this.lectureTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.lectureTimeLbl.Location = new System.Drawing.Point(64, 159);
            this.lectureTimeLbl.Name = "lectureTimeLbl";
            this.lectureTimeLbl.Size = new System.Drawing.Size(57, 12);
            this.lectureTimeLbl.TabIndex = 18;
            this.lectureTimeLbl.Text = "강의 시간";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Gray;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(157, 511);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(110, 34);
            this.editBtn.TabIndex = 17;
            this.editBtn.TabStop = false;
            this.editBtn.Text = "강의 수정";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // lectureNameLbl
            // 
            this.lectureNameLbl.AutoSize = true;
            this.lectureNameLbl.BackColor = System.Drawing.Color.White;
            this.lectureNameLbl.ForeColor = System.Drawing.Color.Black;
            this.lectureNameLbl.Location = new System.Drawing.Point(64, 83);
            this.lectureNameLbl.Name = "lectureNameLbl";
            this.lectureNameLbl.Size = new System.Drawing.Size(41, 12);
            this.lectureNameLbl.TabIndex = 16;
            this.lectureNameLbl.Text = "강의명";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(273, 511);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 34);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "강의 삭제";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(263, 354);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(106, 20);
            this.semesterComboBox.TabIndex = 29;
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.White;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(60, 354);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(109, 20);
            this.yearComboBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(727, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "Excel로 추가";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfessorLectureEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.editLecturePanel);
            this.Controls.Add(this.myLecturePanel);
            this.Name = "ProfessorLectureEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorLectureEditView";
            this.Load += new System.EventHandler(this.ProfessorLectureEditView_Load);
            this.myLecturePanel.ResumeLayout(false);
            this.myLecturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLectureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturePictureBox)).EndInit();
            this.editLecturePanel.ResumeLayout(false);
            this.editLecturePanel.PerformLayout();
            this.lectureTotalStudentPanel.ResumeLayout(false);
            this.lectureTotalStudentPanel.PerformLayout();
            this.lectureTimePanel.ResumeLayout(false);
            this.lectureTimePanel.PerformLayout();
            this.lectureNamePanel.ResumeLayout(false);
            this.lectureNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel myLecturePanel;
        private System.Windows.Forms.DataGridView myLectureTable;
        private System.Windows.Forms.Label myLectureLbl;
        private System.Windows.Forms.PictureBox lecturePictureBox;
        private System.Windows.Forms.Button addLectureBtn;
        private System.Windows.Forms.Panel editLecturePanel;
        private System.Windows.Forms.Label lectureSemesterLbl;
        private System.Windows.Forms.Label lectureTotalStuentLbl;
        private System.Windows.Forms.Label lectureTimeLbl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label lectureNameLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel lectureTotalStudentPanel;
        private System.Windows.Forms.TextBox lectureTotalStudentTextBox;
        private System.Windows.Forms.Panel lectureTimePanel;
        private System.Windows.Forms.TextBox lectureTimeTextBox;
        private System.Windows.Forms.Panel lectureNamePanel;
        private System.Windows.Forms.TextBox lectureNameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureSemester;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button button1;
    }
}