namespace program.View
{
    partial class ProfessorExamView
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
            this.testInfoPanel = new System.Windows.Forms.Panel();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.webViewPanel = new System.Windows.Forms.Panel();
            this.sendNoticeBtn = new System.Windows.Forms.Button();
            this.testEndBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatReceiveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // testInfoPanel
            // 
            this.testInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.testInfoPanel.Controls.Add(this.exitBtn);
            this.testInfoPanel.Controls.Add(this.testEndBtn);
            this.testInfoPanel.Controls.Add(this.sendNoticeBtn);
            this.testInfoPanel.Controls.Add(this.studentTable);
            this.testInfoPanel.Location = new System.Drawing.Point(900, 28);
            this.testInfoPanel.Name = "testInfoPanel";
            this.testInfoPanel.Size = new System.Drawing.Size(363, 654);
            this.testInfoPanel.TabIndex = 20;
            // 
            // studentTable
            // 
            this.studentTable.AllowUserToAddRows = false;
            this.studentTable.AllowUserToDeleteRows = false;
            this.studentTable.AllowUserToResizeColumns = false;
            this.studentTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.studentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.studentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.chatReceiveColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.studentTable.GridColor = System.Drawing.Color.AliceBlue;
            this.studentTable.Location = new System.Drawing.Point(18, 32);
            this.studentTable.MultiSelect = false;
            this.studentTable.Name = "studentTable";
            this.studentTable.ReadOnly = true;
            this.studentTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studentTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.studentTable.RowTemplate.Height = 23;
            this.studentTable.Size = new System.Drawing.Size(328, 186);
            this.studentTable.TabIndex = 21;
            this.studentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellClick);
            // 
            // webViewPanel
            // 
            this.webViewPanel.BackColor = System.Drawing.Color.Yellow;
            this.webViewPanel.Location = new System.Drawing.Point(0, 28);
            this.webViewPanel.Name = "webViewPanel";
            this.webViewPanel.Size = new System.Drawing.Size(900, 460);
            this.webViewPanel.TabIndex = 22;
            // 
            // sendNoticeBtn
            // 
            this.sendNoticeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.sendNoticeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendNoticeBtn.ForeColor = System.Drawing.Color.White;
            this.sendNoticeBtn.Location = new System.Drawing.Point(18, 607);
            this.sendNoticeBtn.Name = "sendNoticeBtn";
            this.sendNoticeBtn.Size = new System.Drawing.Size(100, 34);
            this.sendNoticeBtn.TabIndex = 22;
            this.sendNoticeBtn.TabStop = false;
            this.sendNoticeBtn.Text = "공지사항 전송";
            this.sendNoticeBtn.UseVisualStyleBackColor = false;
            // 
            // testEndBtn
            // 
            this.testEndBtn.BackColor = System.Drawing.Color.Black;
            this.testEndBtn.FlatAppearance.BorderSize = 0;
            this.testEndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testEndBtn.ForeColor = System.Drawing.Color.White;
            this.testEndBtn.Location = new System.Drawing.Point(132, 607);
            this.testEndBtn.Name = "testEndBtn";
            this.testEndBtn.Size = new System.Drawing.Size(101, 34);
            this.testEndBtn.TabIndex = 23;
            this.testEndBtn.TabStop = false;
            this.testEndBtn.Text = "시험 종료";
            this.testEndBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(246, 607);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 34);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "나가기";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.FillWeight = 17F;
            this.dataGridViewTextBoxColumn1.HeaderText = "학번";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 13F;
            this.dataGridViewTextBoxColumn4.HeaderText = "이름";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chatReceiveColumn
            // 
            this.chatReceiveColumn.FillWeight = 6F;
            this.chatReceiveColumn.HeaderText = "채팅";
            this.chatReceiveColumn.Name = "chatReceiveColumn";
            this.chatReceiveColumn.ReadOnly = true;
            // 
            // ProfessorExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.webViewPanel);
            this.Controls.Add(this.testInfoPanel);
            this.Name = "ProfessorExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorExamView";
            this.Load += new System.EventHandler(this.ProfessorExamView_Load);
            this.testInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel testInfoPanel;
        private System.Windows.Forms.DataGridView studentTable;
        private System.Windows.Forms.Panel webViewPanel;
        private System.Windows.Forms.Button sendNoticeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button testEndBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatReceiveColumn;
    }
}