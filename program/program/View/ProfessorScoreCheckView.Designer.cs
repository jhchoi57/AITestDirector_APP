namespace program.View
{
    partial class ProfessorScoreCheckView
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.scoreCheckLabel = new System.Windows.Forms.Label();
            this.scorePictureBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.scoreLectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTestDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.mainPanel.Controls.Add(this.scoreCheckLabel);
            this.mainPanel.Controls.Add(this.scorePictureBox);
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.exitBtn);
            this.mainPanel.Controls.Add(this.lectureTable);
            this.mainPanel.Controls.Add(this.semesterComboBox);
            this.mainPanel.Location = new System.Drawing.Point(0, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 19;
            // 
            // scoreCheckLabel
            // 
            this.scoreCheckLabel.AutoSize = true;
            this.scoreCheckLabel.ForeColor = System.Drawing.Color.White;
            this.scoreCheckLabel.Location = new System.Drawing.Point(111, 27);
            this.scoreCheckLabel.Name = "scoreCheckLabel";
            this.scoreCheckLabel.Size = new System.Drawing.Size(57, 12);
            this.scoreCheckLabel.TabIndex = 21;
            this.scoreCheckLabel.Text = "성적 확인";
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
            this.backBtn.Location = new System.Drawing.Point(1079, 624);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(143, 34);
            this.backBtn.TabIndex = 19;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "나가기";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1234, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 28);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "✕";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lectureTable
            // 
            this.lectureTable.AllowUserToAddRows = false;
            this.lectureTable.AllowUserToDeleteRows = false;
            this.lectureTable.AllowUserToResizeColumns = false;
            this.lectureTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            this.lectureTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.lectureTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.lectureTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.lectureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreLectureName,
            this.scoreTestName,
            this.scoreTestDay,
            this.scoreScore,
            this.scoreAvg,
            this.scoreRate});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle16;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(35, 86);
            this.lectureTable.MultiSelect = false;
            this.lectureTable.Name = "lectureTable";
            this.lectureTable.ReadOnly = true;
            this.lectureTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.lectureTable.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lectureTable.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.lectureTable.RowTemplate.Height = 23;
            this.lectureTable.Size = new System.Drawing.Size(1187, 523);
            this.lectureTable.TabIndex = 12;
            // 
            // scoreLectureName
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.scoreLectureName.DefaultCellStyle = dataGridViewCellStyle15;
            this.scoreLectureName.FillWeight = 10F;
            this.scoreLectureName.HeaderText = "강의명";
            this.scoreLectureName.Name = "scoreLectureName";
            this.scoreLectureName.ReadOnly = true;
            this.scoreLectureName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreTestName
            // 
            this.scoreTestName.FillWeight = 10F;
            this.scoreTestName.HeaderText = "시험명";
            this.scoreTestName.Name = "scoreTestName";
            this.scoreTestName.ReadOnly = true;
            this.scoreTestName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreTestDay
            // 
            this.scoreTestDay.FillWeight = 7F;
            this.scoreTestDay.HeaderText = "시험 날짜";
            this.scoreTestDay.Name = "scoreTestDay";
            this.scoreTestDay.ReadOnly = true;
            this.scoreTestDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreScore
            // 
            this.scoreScore.FillWeight = 5F;
            this.scoreScore.HeaderText = "성적 / 총점수";
            this.scoreScore.Name = "scoreScore";
            this.scoreScore.ReadOnly = true;
            this.scoreScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreAvg
            // 
            this.scoreAvg.FillWeight = 3F;
            this.scoreAvg.HeaderText = "평균점수";
            this.scoreAvg.Name = "scoreAvg";
            this.scoreAvg.ReadOnly = true;
            this.scoreAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreRate
            // 
            this.scoreRate.FillWeight = 3F;
            this.scoreRate.HeaderText = "반영비율";
            this.scoreRate.Name = "scoreRate";
            this.scoreRate.ReadOnly = true;
            this.scoreRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.Font = new System.Drawing.Font("굴림", 14F);
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(1049, 53);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(173, 27);
            this.semesterComboBox.TabIndex = 15;
            // 
            // ProfessorScoreCheckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProfessorScoreCheckView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorScoreCheckView";
            this.Load += new System.EventHandler(this.ProfessorScoreCheckView_Load);
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
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView lectureTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreLectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTestDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreRate;
        private System.Windows.Forms.ComboBox semesterComboBox;
    }
}