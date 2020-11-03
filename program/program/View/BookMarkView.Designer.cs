namespace program.View
{
    partial class BookMarkView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookMarkTopPanel = new System.Windows.Forms.Panel();
            this.bookMarkTable = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doubtInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookMarkLbl = new System.Windows.Forms.Label();
            this.bookMarkPictureBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.bookMarkBotPanel = new System.Windows.Forms.Panel();
            this.bookMarkTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkPictureBox)).BeginInit();
            this.bookMarkBotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookMarkTopPanel
            // 
            this.bookMarkTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.bookMarkTopPanel.Controls.Add(this.bookMarkLbl);
            this.bookMarkTopPanel.Controls.Add(this.bookMarkPictureBox);
            this.bookMarkTopPanel.Location = new System.Drawing.Point(0, 28);
            this.bookMarkTopPanel.Name = "bookMarkTopPanel";
            this.bookMarkTopPanel.Size = new System.Drawing.Size(1264, 82);
            this.bookMarkTopPanel.TabIndex = 21;
            this.bookMarkTopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookMarkPanel_Paint);
            // 
            // bookMarkTable
            // 
            this.bookMarkTable.AllowUserToAddRows = false;
            this.bookMarkTable.AllowUserToDeleteRows = false;
            this.bookMarkTable.AllowUserToResizeColumns = false;
            this.bookMarkTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            this.bookMarkTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bookMarkTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookMarkTable.BackgroundColor = System.Drawing.Color.White;
            this.bookMarkTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookMarkTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookMarkTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bookMarkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookMarkTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName,
            this.dataGridViewTextBoxColumn4,
            this.doubtInfo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookMarkTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.bookMarkTable.GridColor = System.Drawing.Color.AliceBlue;
            this.bookMarkTable.Location = new System.Drawing.Point(42, 29);
            this.bookMarkTable.MultiSelect = false;
            this.bookMarkTable.Name = "bookMarkTable";
            this.bookMarkTable.ReadOnly = true;
            this.bookMarkTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookMarkTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.bookMarkTable.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookMarkTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bookMarkTable.RowTemplate.Height = 23;
            this.bookMarkTable.Size = new System.Drawing.Size(1178, 484);
            this.bookMarkTable.TabIndex = 16;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.FillWeight = 5F;
            this.studentName.HeaderText = "학생명";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 10F;
            this.dataGridViewTextBoxColumn4.HeaderText = "시간";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // doubtInfo
            // 
            this.doubtInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doubtInfo.FillWeight = 15F;
            this.doubtInfo.HeaderText = "의심내용";
            this.doubtInfo.Name = "doubtInfo";
            this.doubtInfo.ReadOnly = true;
            // 
            // bookMarkLbl
            // 
            this.bookMarkLbl.AutoSize = true;
            this.bookMarkLbl.ForeColor = System.Drawing.Color.White;
            this.bookMarkLbl.Location = new System.Drawing.Point(82, 28);
            this.bookMarkLbl.Name = "bookMarkLbl";
            this.bookMarkLbl.Size = new System.Drawing.Size(149, 12);
            this.bookMarkLbl.TabIndex = 16;
            this.bookMarkLbl.Text = "부정행위 의심 학생 리스트";
            // 
            // bookMarkPictureBox
            // 
            this.bookMarkPictureBox.Location = new System.Drawing.Point(15, 16);
            this.bookMarkPictureBox.Name = "bookMarkPictureBox";
            this.bookMarkPictureBox.Size = new System.Drawing.Size(50, 50);
            this.bookMarkPictureBox.TabIndex = 16;
            this.bookMarkPictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1142, 525);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 34);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "나가기";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // bookMarkBotPanel
            // 
            this.bookMarkBotPanel.BackColor = System.Drawing.Color.White;
            this.bookMarkBotPanel.Controls.Add(this.bookMarkTable);
            this.bookMarkBotPanel.Controls.Add(this.exitBtn);
            this.bookMarkBotPanel.Location = new System.Drawing.Point(0, 110);
            this.bookMarkBotPanel.Name = "bookMarkBotPanel";
            this.bookMarkBotPanel.Size = new System.Drawing.Size(1264, 573);
            this.bookMarkBotPanel.TabIndex = 22;
            // 
            // BookMarkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bookMarkBotPanel);
            this.Controls.Add(this.bookMarkTopPanel);
            this.Name = "BookMarkView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoView";
            this.Load += new System.EventHandler(this.VideoView_Load);
            this.bookMarkTopPanel.ResumeLayout(false);
            this.bookMarkTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkPictureBox)).EndInit();
            this.bookMarkBotPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookMarkTopPanel;
        private System.Windows.Forms.DataGridView bookMarkTable;
        private System.Windows.Forms.Label bookMarkLbl;
        private System.Windows.Forms.PictureBox bookMarkPictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn doubtInfo;
        private System.Windows.Forms.Panel bookMarkBotPanel;
    }
}