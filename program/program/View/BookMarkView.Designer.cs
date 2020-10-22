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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookMarkPanel = new System.Windows.Forms.Panel();
            this.bookMarkTable = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doubtInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookMarkLbl = new System.Windows.Forms.Label();
            this.bookMarkPictureBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.bookMarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bookMarkPanel
            // 
            this.bookMarkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.bookMarkPanel.Controls.Add(this.bookMarkTable);
            this.bookMarkPanel.Controls.Add(this.bookMarkLbl);
            this.bookMarkPanel.Controls.Add(this.bookMarkPictureBox);
            this.bookMarkPanel.Controls.Add(this.exitBtn);
            this.bookMarkPanel.Location = new System.Drawing.Point(0, 28);
            this.bookMarkPanel.Name = "bookMarkPanel";
            this.bookMarkPanel.Size = new System.Drawing.Size(1264, 655);
            this.bookMarkPanel.TabIndex = 21;
            this.bookMarkPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookMarkPanel_Paint);
            // 
            // bookMarkTable
            // 
            this.bookMarkTable.AllowUserToAddRows = false;
            this.bookMarkTable.AllowUserToDeleteRows = false;
            this.bookMarkTable.AllowUserToResizeColumns = false;
            this.bookMarkTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.bookMarkTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookMarkTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookMarkTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(97)))));
            this.bookMarkTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookMarkTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookMarkTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookMarkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookMarkTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName,
            this.dataGridViewTextBoxColumn4,
            this.doubtInfo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookMarkTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookMarkTable.GridColor = System.Drawing.Color.AliceBlue;
            this.bookMarkTable.Location = new System.Drawing.Point(253, 98);
            this.bookMarkTable.MultiSelect = false;
            this.bookMarkTable.Name = "bookMarkTable";
            this.bookMarkTable.ReadOnly = true;
            this.bookMarkTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookMarkTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bookMarkTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookMarkTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bookMarkTable.RowTemplate.Height = 23;
            this.bookMarkTable.Size = new System.Drawing.Size(770, 484);
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
            this.bookMarkLbl.Location = new System.Drawing.Point(109, 41);
            this.bookMarkLbl.Name = "bookMarkLbl";
            this.bookMarkLbl.Size = new System.Drawing.Size(149, 12);
            this.bookMarkLbl.TabIndex = 16;
            this.bookMarkLbl.Text = "부정행위 의심 학생 리스트";
            // 
            // bookMarkPictureBox
            // 
            this.bookMarkPictureBox.Location = new System.Drawing.Point(42, 29);
            this.bookMarkPictureBox.Name = "bookMarkPictureBox";
            this.bookMarkPictureBox.Size = new System.Drawing.Size(50, 50);
            this.bookMarkPictureBox.TabIndex = 16;
            this.bookMarkPictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1142, 607);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 34);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "나가기";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // BookMarkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bookMarkPanel);
            this.Name = "BookMarkView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoView";
            this.Load += new System.EventHandler(this.VideoView_Load);
            this.bookMarkPanel.ResumeLayout(false);
            this.bookMarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookMarkPanel;
        private System.Windows.Forms.DataGridView bookMarkTable;
        private System.Windows.Forms.Label bookMarkLbl;
        private System.Windows.Forms.PictureBox bookMarkPictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn doubtInfo;
    }
}