namespace program.View
{
    partial class ProfessorDetailScoreView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.excelDownBtn = new System.Windows.Forms.Button();
            this.avgScoreText = new System.Windows.Forms.Label();
            this.totalScoreText = new System.Windows.Forms.Label();
            this.testDayText = new System.Windows.Forms.Label();
            this.testNameText = new System.Windows.Forms.Label();
            this.lectureText = new System.Windows.Forms.Label();
            this.avgScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.testDayLbl = new System.Windows.Forms.Label();
            this.testNameLbl = new System.Windows.Forms.Label();
            this.lectureLbl = new System.Windows.Forms.Label();
            this.scoreCheckLabel = new System.Windows.Forms.Label();
            this.scorePictureBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.mainPanel.Controls.Add(this.excelDownBtn);
            this.mainPanel.Controls.Add(this.avgScoreText);
            this.mainPanel.Controls.Add(this.totalScoreText);
            this.mainPanel.Controls.Add(this.testDayText);
            this.mainPanel.Controls.Add(this.testNameText);
            this.mainPanel.Controls.Add(this.lectureText);
            this.mainPanel.Controls.Add(this.avgScoreLbl);
            this.mainPanel.Controls.Add(this.totalScoreLbl);
            this.mainPanel.Controls.Add(this.testDayLbl);
            this.mainPanel.Controls.Add(this.testNameLbl);
            this.mainPanel.Controls.Add(this.lectureLbl);
            this.mainPanel.Controls.Add(this.scoreCheckLabel);
            this.mainPanel.Controls.Add(this.scorePictureBox);
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.lectureTable);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 654);
            this.mainPanel.TabIndex = 20;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // excelDownBtn
            // 
            this.excelDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.excelDownBtn.FlatAppearance.BorderSize = 0;
            this.excelDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelDownBtn.ForeColor = System.Drawing.Color.White;
            this.excelDownBtn.Location = new System.Drawing.Point(910, 603);
            this.excelDownBtn.Name = "excelDownBtn";
            this.excelDownBtn.Size = new System.Drawing.Size(143, 34);
            this.excelDownBtn.TabIndex = 32;
            this.excelDownBtn.TabStop = false;
            this.excelDownBtn.Text = "엑셀 다운로드";
            this.excelDownBtn.UseVisualStyleBackColor = false;
            // 
            // avgScoreText
            // 
            this.avgScoreText.AutoSize = true;
            this.avgScoreText.ForeColor = System.Drawing.Color.White;
            this.avgScoreText.Location = new System.Drawing.Point(387, 505);
            this.avgScoreText.Name = "avgScoreText";
            this.avgScoreText.Size = new System.Drawing.Size(57, 12);
            this.avgScoreText.TabIndex = 31;
            this.avgScoreText.Text = "평균 점수";
            // 
            // totalScoreText
            // 
            this.totalScoreText.AutoSize = true;
            this.totalScoreText.ForeColor = System.Drawing.Color.White;
            this.totalScoreText.Location = new System.Drawing.Point(387, 409);
            this.totalScoreText.Name = "totalScoreText";
            this.totalScoreText.Size = new System.Drawing.Size(45, 12);
            this.totalScoreText.TabIndex = 30;
            this.totalScoreText.Text = "총 점수";
            // 
            // testDayText
            // 
            this.testDayText.AutoSize = true;
            this.testDayText.ForeColor = System.Drawing.Color.White;
            this.testDayText.Location = new System.Drawing.Point(387, 317);
            this.testDayText.Name = "testDayText";
            this.testDayText.Size = new System.Drawing.Size(57, 12);
            this.testDayText.TabIndex = 29;
            this.testDayText.Text = "시험 날짜";
            // 
            // testNameText
            // 
            this.testNameText.AutoSize = true;
            this.testNameText.ForeColor = System.Drawing.Color.White;
            this.testNameText.Location = new System.Drawing.Point(387, 224);
            this.testNameText.Name = "testNameText";
            this.testNameText.Size = new System.Drawing.Size(41, 12);
            this.testNameText.TabIndex = 28;
            this.testNameText.Text = "시험명";
            // 
            // lectureText
            // 
            this.lectureText.AutoSize = true;
            this.lectureText.ForeColor = System.Drawing.Color.White;
            this.lectureText.Location = new System.Drawing.Point(387, 132);
            this.lectureText.Name = "lectureText";
            this.lectureText.Size = new System.Drawing.Size(41, 12);
            this.lectureText.TabIndex = 27;
            this.lectureText.Text = "강의명";
            // 
            // avgScoreLbl
            // 
            this.avgScoreLbl.AutoSize = true;
            this.avgScoreLbl.ForeColor = System.Drawing.Color.White;
            this.avgScoreLbl.Location = new System.Drawing.Point(180, 505);
            this.avgScoreLbl.Name = "avgScoreLbl";
            this.avgScoreLbl.Size = new System.Drawing.Size(57, 12);
            this.avgScoreLbl.TabIndex = 26;
            this.avgScoreLbl.Text = "평균 점수";
            // 
            // totalScoreLbl
            // 
            this.totalScoreLbl.AutoSize = true;
            this.totalScoreLbl.ForeColor = System.Drawing.Color.White;
            this.totalScoreLbl.Location = new System.Drawing.Point(180, 409);
            this.totalScoreLbl.Name = "totalScoreLbl";
            this.totalScoreLbl.Size = new System.Drawing.Size(45, 12);
            this.totalScoreLbl.TabIndex = 25;
            this.totalScoreLbl.Text = "총 점수";
            // 
            // testDayLbl
            // 
            this.testDayLbl.AutoSize = true;
            this.testDayLbl.ForeColor = System.Drawing.Color.White;
            this.testDayLbl.Location = new System.Drawing.Point(180, 317);
            this.testDayLbl.Name = "testDayLbl";
            this.testDayLbl.Size = new System.Drawing.Size(57, 12);
            this.testDayLbl.TabIndex = 24;
            this.testDayLbl.Text = "시험 날짜";
            // 
            // testNameLbl
            // 
            this.testNameLbl.AutoSize = true;
            this.testNameLbl.ForeColor = System.Drawing.Color.White;
            this.testNameLbl.Location = new System.Drawing.Point(180, 224);
            this.testNameLbl.Name = "testNameLbl";
            this.testNameLbl.Size = new System.Drawing.Size(41, 12);
            this.testNameLbl.TabIndex = 23;
            this.testNameLbl.Text = "시험명";
            // 
            // lectureLbl
            // 
            this.lectureLbl.AutoSize = true;
            this.lectureLbl.ForeColor = System.Drawing.Color.White;
            this.lectureLbl.Location = new System.Drawing.Point(180, 132);
            this.lectureLbl.Name = "lectureLbl";
            this.lectureLbl.Size = new System.Drawing.Size(41, 12);
            this.lectureLbl.TabIndex = 22;
            this.lectureLbl.Text = "강의명";
            // 
            // scoreCheckLabel
            // 
            this.scoreCheckLabel.AutoSize = true;
            this.scoreCheckLabel.ForeColor = System.Drawing.Color.White;
            this.scoreCheckLabel.Location = new System.Drawing.Point(111, 27);
            this.scoreCheckLabel.Name = "scoreCheckLabel";
            this.scoreCheckLabel.Size = new System.Drawing.Size(97, 12);
            this.scoreCheckLabel.TabIndex = 21;
            this.scoreCheckLabel.Text = "학생별 성적 확인";
            // 
            // scorePictureBox
            // 
            this.scorePictureBox.Location = new System.Drawing.Point(37, 14);
            this.scorePictureBox.Name = "scorePictureBox";
            this.scorePictureBox.Size = new System.Drawing.Size(61, 59);
            this.scorePictureBox.TabIndex = 20;
            this.scorePictureBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1079, 603);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(143, 34);
            this.backBtn.TabIndex = 19;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "나가기";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.lectureTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
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
            this.studentName,
            this.studentScore,
            this.scoreRate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(792, 78);
            this.lectureTable.MultiSelect = false;
            this.lectureTable.Name = "lectureTable";
            this.lectureTable.ReadOnly = true;
            this.lectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lectureTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lectureTable.RowTemplate.Height = 23;
            this.lectureTable.Size = new System.Drawing.Size(331, 484);
            this.lectureTable.TabIndex = 12;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.studentName.FillWeight = 7F;
            this.studentName.Frozen = true;
            this.studentName.HeaderText = "학생명";
            this.studentName.MinimumWidth = 7;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 150;
            // 
            // studentScore
            // 
            this.studentScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentScore.FillWeight = 1F;
            this.studentScore.HeaderText = "학생점수";
            this.studentScore.MinimumWidth = 3;
            this.studentScore.Name = "studentScore";
            this.studentScore.ReadOnly = true;
            this.studentScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studentScore.Width = 78;
            // 
            // scoreRate
            // 
            this.scoreRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scoreRate.FillWeight = 1F;
            this.scoreRate.HeaderText = "채점 여부";
            this.scoreRate.MinimumWidth = 3;
            this.scoreRate.Name = "scoreRate";
            this.scoreRate.ReadOnly = true;
            this.scoreRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scoreRate.Width = 82;
            // 
            // ProfessorDetailScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProfessorDetailScoreView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorDetailScoreView";
            this.Load += new System.EventHandler(this.ProfessorDetailScoreView_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label scoreCheckLabel;
        private System.Windows.Forms.PictureBox scorePictureBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView lectureTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreRate;
        private System.Windows.Forms.Label testDayText;
        private System.Windows.Forms.Label testNameText;
        private System.Windows.Forms.Label lectureText;
        private System.Windows.Forms.Label avgScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label testDayLbl;
        private System.Windows.Forms.Label testNameLbl;
        private System.Windows.Forms.Label lectureLbl;
        private System.Windows.Forms.Label avgScoreText;
        private System.Windows.Forms.Label totalScoreText;
        private System.Windows.Forms.Button excelDownBtn;
    }
}