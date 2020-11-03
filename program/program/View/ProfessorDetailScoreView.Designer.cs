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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.scoreCheckLabel = new System.Windows.Forms.Label();
            this.scorePictureBox = new System.Windows.Forms.PictureBox();
            this.doubtBtn = new System.Windows.Forms.Button();
            this.excelDownBtn = new System.Windows.Forms.Button();
            this.avgScoreText = new System.Windows.Forms.Label();
            this.totalScoreText = new System.Windows.Forms.Label();
            this.testDayText = new System.Windows.Forms.Label();
            this.testNameText = new System.Windows.Forms.Label();
            this.lectureText = new System.Windows.Forms.Label();
            this.avgScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.studentScoreTable = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentScoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.TopPanel);
            this.mainPanel.Controls.Add(this.doubtBtn);
            this.mainPanel.Controls.Add(this.excelDownBtn);
            this.mainPanel.Controls.Add(this.avgScoreText);
            this.mainPanel.Controls.Add(this.totalScoreText);
            this.mainPanel.Controls.Add(this.testDayText);
            this.mainPanel.Controls.Add(this.testNameText);
            this.mainPanel.Controls.Add(this.lectureText);
            this.mainPanel.Controls.Add(this.avgScoreLbl);
            this.mainPanel.Controls.Add(this.totalScoreLbl);
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.studentScoreTable);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 654);
            this.mainPanel.TabIndex = 20;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.TopPanel.Controls.Add(this.scoreCheckLabel);
            this.TopPanel.Controls.Add(this.scorePictureBox);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1264, 82);
            this.TopPanel.TabIndex = 34;
            // 
            // scoreCheckLabel
            // 
            this.scoreCheckLabel.AutoSize = true;
            this.scoreCheckLabel.ForeColor = System.Drawing.Color.White;
            this.scoreCheckLabel.Location = new System.Drawing.Point(85, 25);
            this.scoreCheckLabel.Name = "scoreCheckLabel";
            this.scoreCheckLabel.Size = new System.Drawing.Size(97, 12);
            this.scoreCheckLabel.TabIndex = 21;
            this.scoreCheckLabel.Text = "학생별 성적 확인";
            // 
            // scorePictureBox
            // 
            this.scorePictureBox.Location = new System.Drawing.Point(11, 12);
            this.scorePictureBox.Name = "scorePictureBox";
            this.scorePictureBox.Size = new System.Drawing.Size(61, 59);
            this.scorePictureBox.TabIndex = 20;
            this.scorePictureBox.TabStop = false;
            // 
            // doubtBtn
            // 
            this.doubtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.doubtBtn.FlatAppearance.BorderSize = 0;
            this.doubtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubtBtn.ForeColor = System.Drawing.Color.White;
            this.doubtBtn.Location = new System.Drawing.Point(733, 603);
            this.doubtBtn.Name = "doubtBtn";
            this.doubtBtn.Size = new System.Drawing.Size(143, 34);
            this.doubtBtn.TabIndex = 33;
            this.doubtBtn.TabStop = false;
            this.doubtBtn.Text = "부정행위 의심 학생";
            this.doubtBtn.UseVisualStyleBackColor = false;
            this.doubtBtn.Click += new System.EventHandler(this.doubtBtn_Click);
            // 
            // excelDownBtn
            // 
            this.excelDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
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
            this.excelDownBtn.Click += new System.EventHandler(this.excelDownBtn_Click);
            // 
            // avgScoreText
            // 
            this.avgScoreText.AutoSize = true;
            this.avgScoreText.ForeColor = System.Drawing.Color.Black;
            this.avgScoreText.Location = new System.Drawing.Point(274, 476);
            this.avgScoreText.Name = "avgScoreText";
            this.avgScoreText.Size = new System.Drawing.Size(57, 12);
            this.avgScoreText.TabIndex = 31;
            this.avgScoreText.Text = "평균 점수";
            // 
            // totalScoreText
            // 
            this.totalScoreText.AutoSize = true;
            this.totalScoreText.ForeColor = System.Drawing.Color.Black;
            this.totalScoreText.Location = new System.Drawing.Point(274, 403);
            this.totalScoreText.Name = "totalScoreText";
            this.totalScoreText.Size = new System.Drawing.Size(45, 12);
            this.totalScoreText.TabIndex = 30;
            this.totalScoreText.Text = "총 점수";
            // 
            // testDayText
            // 
            this.testDayText.AutoSize = true;
            this.testDayText.ForeColor = System.Drawing.Color.Black;
            this.testDayText.Location = new System.Drawing.Point(67, 319);
            this.testDayText.Name = "testDayText";
            this.testDayText.Size = new System.Drawing.Size(57, 12);
            this.testDayText.TabIndex = 29;
            this.testDayText.Text = "시험 날짜";
            // 
            // testNameText
            // 
            this.testNameText.AutoSize = true;
            this.testNameText.ForeColor = System.Drawing.Color.Black;
            this.testNameText.Location = new System.Drawing.Point(67, 238);
            this.testNameText.Name = "testNameText";
            this.testNameText.Size = new System.Drawing.Size(41, 12);
            this.testNameText.TabIndex = 28;
            this.testNameText.Text = "시험명";
            // 
            // lectureText
            // 
            this.lectureText.AutoSize = true;
            this.lectureText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lectureText.Location = new System.Drawing.Point(49, 129);
            this.lectureText.Name = "lectureText";
            this.lectureText.Size = new System.Drawing.Size(41, 12);
            this.lectureText.TabIndex = 27;
            this.lectureText.Text = "강의명";
            // 
            // avgScoreLbl
            // 
            this.avgScoreLbl.AutoSize = true;
            this.avgScoreLbl.ForeColor = System.Drawing.Color.Black;
            this.avgScoreLbl.Location = new System.Drawing.Point(67, 476);
            this.avgScoreLbl.Name = "avgScoreLbl";
            this.avgScoreLbl.Size = new System.Drawing.Size(57, 12);
            this.avgScoreLbl.TabIndex = 26;
            this.avgScoreLbl.Text = "평균 점수";
            // 
            // totalScoreLbl
            // 
            this.totalScoreLbl.AutoSize = true;
            this.totalScoreLbl.ForeColor = System.Drawing.Color.Black;
            this.totalScoreLbl.Location = new System.Drawing.Point(67, 403);
            this.totalScoreLbl.Name = "totalScoreLbl";
            this.totalScoreLbl.Size = new System.Drawing.Size(45, 12);
            this.totalScoreLbl.TabIndex = 25;
            this.totalScoreLbl.Text = "총 점수";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
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
            // studentScoreTable
            // 
            this.studentScoreTable.AllowUserToAddRows = false;
            this.studentScoreTable.AllowUserToDeleteRows = false;
            this.studentScoreTable.AllowUserToResizeColumns = false;
            this.studentScoreTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.studentScoreTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentScoreTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentScoreTable.BackgroundColor = System.Drawing.Color.White;
            this.studentScoreTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentScoreTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentScoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentScoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
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
            this.studentScoreTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentScoreTable.GridColor = System.Drawing.Color.AliceBlue;
            this.studentScoreTable.Location = new System.Drawing.Point(665, 108);
            this.studentScoreTable.MultiSelect = false;
            this.studentScoreTable.Name = "studentScoreTable";
            this.studentScoreTable.ReadOnly = true;
            this.studentScoreTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentScoreTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentScoreTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentScoreTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.studentScoreTable.RowTemplate.Height = 23;
            this.studentScoreTable.Size = new System.Drawing.Size(523, 454);
            this.studentScoreTable.TabIndex = 12;
            // 
            // studentID
            // 
            this.studentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentID.FillWeight = 5F;
            this.studentID.HeaderText = "학번";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.FillWeight = 5F;
            this.studentName.HeaderText = "학생명";
            this.studentName.MinimumWidth = 7;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // studentScore
            // 
            this.studentScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentScore.FillWeight = 3F;
            this.studentScore.HeaderText = "학생점수";
            this.studentScore.MinimumWidth = 3;
            this.studentScore.Name = "studentScore";
            this.studentScore.ReadOnly = true;
            this.studentScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreRate
            // 
            this.scoreRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scoreRate.FillWeight = 3F;
            this.scoreRate.HeaderText = "채점 여부";
            this.scoreRate.MinimumWidth = 3;
            this.scoreRate.Name = "scoreRate";
            this.scoreRate.ReadOnly = true;
            this.scoreRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentScoreTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label scoreCheckLabel;
        private System.Windows.Forms.PictureBox scorePictureBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView studentScoreTable;
        private System.Windows.Forms.Label testDayText;
        private System.Windows.Forms.Label testNameText;
        private System.Windows.Forms.Label lectureText;
        private System.Windows.Forms.Label avgScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label avgScoreText;
        private System.Windows.Forms.Label totalScoreText;
        private System.Windows.Forms.Button excelDownBtn;
        private System.Windows.Forms.Button doubtBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreRate;
        private System.Windows.Forms.Panel TopPanel;
    }
}