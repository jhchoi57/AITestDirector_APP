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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.scoreCheckLabel = new System.Windows.Forms.Label();
            this.scorePictureBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.scoreLectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTestDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.TopPanel);
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.lectureTable);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 654);
            this.mainPanel.TabIndex = 19;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.TopPanel.Controls.Add(this.scoreCheckLabel);
            this.TopPanel.Controls.Add(this.scorePictureBox);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1264, 82);
            this.TopPanel.TabIndex = 22;
            // 
            // scoreCheckLabel
            // 
            this.scoreCheckLabel.AutoSize = true;
            this.scoreCheckLabel.ForeColor = System.Drawing.Color.White;
            this.scoreCheckLabel.Location = new System.Drawing.Point(86, 24);
            this.scoreCheckLabel.Name = "scoreCheckLabel";
            this.scoreCheckLabel.Size = new System.Drawing.Size(57, 12);
            this.scoreCheckLabel.TabIndex = 21;
            this.scoreCheckLabel.Text = "성적 확인";
            // 
            // scorePictureBox
            // 
            this.scorePictureBox.Location = new System.Drawing.Point(12, 11);
            this.scorePictureBox.Name = "scorePictureBox";
            this.scorePictureBox.Size = new System.Drawing.Size(61, 59);
            this.scorePictureBox.TabIndex = 20;
            this.scorePictureBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1079, 599);
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
            this.lectureTable.BackgroundColor = System.Drawing.Color.White;
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
            this.scoreLectureName,
            this.scoreTestName,
            this.scoreTestDay,
            this.scoreScore,
            this.scoreRate,
            this.scoreAvg,
            this.id});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lectureTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(35, 116);
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
            this.lectureTable.Size = new System.Drawing.Size(1187, 461);
            this.lectureTable.TabIndex = 12;
            this.lectureTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureTable_CellDoubleClick);
            // 
            // scoreLectureName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.scoreLectureName.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.scoreScore.FillWeight = 3F;
            this.scoreScore.HeaderText = "총점수";
            this.scoreScore.Name = "scoreScore";
            this.scoreScore.ReadOnly = true;
            this.scoreScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreRate
            // 
            this.scoreRate.FillWeight = 3F;
            this.scoreRate.HeaderText = "반영비율";
            this.scoreRate.Name = "scoreRate";
            this.scoreRate.ReadOnly = true;
            this.scoreRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // scoreAvg
            // 
            this.scoreAvg.FillWeight = 3F;
            this.scoreAvg.HeaderText = "평균점수";
            this.scoreAvg.Name = "scoreAvg";
            this.scoreAvg.ReadOnly = true;
            this.scoreAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.scoreAvg.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
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
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreLectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTestDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}