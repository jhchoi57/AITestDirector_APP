using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace program.View
{
    partial class StudentHomeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.signupExitButton = new System.Windows.Forms.Button();
            this.signupMinimizeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.lectureTable = new System.Windows.Forms.DataGridView();
            this.lectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkScoreBtn = new System.Windows.Forms.Button();
            this.editLectureBtn = new System.Windows.Forms.Button();
            this.myPagePanel = new System.Windows.Forms.Panel();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.univLabel = new System.Windows.Forms.Label();
            this.stuNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).BeginInit();
            this.myPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signupExitButton
            // 
            this.signupExitButton.FlatAppearance.BorderSize = 0;
            this.signupExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupExitButton.Location = new System.Drawing.Point(349, 0);
            this.signupExitButton.Name = "signupExitButton";
            this.signupExitButton.Size = new System.Drawing.Size(30, 28);
            this.signupExitButton.TabIndex = 0;
            this.signupExitButton.TabStop = false;
            this.signupExitButton.Text = "✕";
            this.signupExitButton.Click += new System.EventHandler(this.signupExitButton_Click);
            // 
            // signupMinimizeButton
            // 
            this.signupMinimizeButton.FlatAppearance.BorderSize = 0;
            this.signupMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupMinimizeButton.Location = new System.Drawing.Point(319, 0);
            this.signupMinimizeButton.Name = "signupMinimizeButton";
            this.signupMinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.signupMinimizeButton.TabIndex = 1;
            this.signupMinimizeButton.TabStop = false;
            this.signupMinimizeButton.Text = "_";
            this.signupMinimizeButton.Click += new System.EventHandler(this.signupMinimizeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.testPanel);
            this.mainPanel.Controls.Add(this.myPagePanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1264, 682);
            this.mainPanel.TabIndex = 0;
            // 
            // testPanel
            // 
            this.testPanel.BackColor = System.Drawing.Color.White;
            this.testPanel.Controls.Add(this.lectureTable);
            this.testPanel.Controls.Add(this.checkScoreBtn);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.lectureName,
            this.professor,
            this.testDay,
            this.testTime,
            this.testName});
            this.lectureTable.GridColor = System.Drawing.Color.AliceBlue;
            this.lectureTable.Location = new System.Drawing.Point(12, 69);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lectureTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lectureTable.RowTemplate.Height = 23;
            this.lectureTable.Size = new System.Drawing.Size(862, 601);
            this.lectureTable.TabIndex = 11;
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
            this.professor.FillWeight = 5F;
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
            // 
            // editLectureBtn
            // 
            this.editLectureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
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
            // myPagePanel
            // 
            this.myPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myPagePanel.Controls.Add(this.pictureBox);
            this.myPagePanel.Controls.Add(this.emailLabel);
            this.myPagePanel.Controls.Add(this.nameLabel);
            this.myPagePanel.Controls.Add(this.stuNumLabel);
            this.myPagePanel.Controls.Add(this.univLabel);
            this.myPagePanel.Controls.Add(this.editInfoBtn);
            this.myPagePanel.Controls.Add(this.signupExitButton);
            this.myPagePanel.Controls.Add(this.signupMinimizeButton);
            this.myPagePanel.Location = new System.Drawing.Point(885, 0);
            this.myPagePanel.Name = "myPagePanel";
            this.myPagePanel.Size = new System.Drawing.Size(379, 682);
            this.myPagePanel.TabIndex = 1;
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(246)))));
            this.editInfoBtn.FlatAppearance.BorderSize = 0;
            this.editInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editInfoBtn.ForeColor = System.Drawing.Color.White;
            this.editInfoBtn.Location = new System.Drawing.Point(259, 638);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(110, 34);
            this.editInfoBtn.TabIndex = 11;
            this.editInfoBtn.TabStop = false;
            this.editInfoBtn.Text = "정보 수정";
            this.editInfoBtn.UseVisualStyleBackColor = false;
            // 
            // univLabel
            // 
            this.univLabel.Location = new System.Drawing.Point(161, 69);
            this.univLabel.Name = "univLabel";
            this.univLabel.Size = new System.Drawing.Size(208, 21);
            this.univLabel.TabIndex = 12;
            this.univLabel.Text = "[학교]";
            // 
            // stuNumLabel
            // 
            this.stuNumLabel.Location = new System.Drawing.Point(161, 116);
            this.stuNumLabel.Name = "stuNumLabel";
            this.stuNumLabel.Size = new System.Drawing.Size(208, 21);
            this.stuNumLabel.TabIndex = 13;
            this.stuNumLabel.Text = "[학번]";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(161, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(208, 21);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "[이름]";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(161, 207);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(208, 21);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "[이메일]";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(23, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(105, 112);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // StudentHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.mainPanel);
            this.Name = "StudentHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHomeView";
            this.Load += new System.EventHandler(this.StudentHomeView_Load);
            this.mainPanel.ResumeLayout(false);
            this.testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lectureTable)).EndInit();
            this.myPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupExitButton;
        private System.Windows.Forms.Button signupMinimizeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Panel myPagePanel;
        private Button checkScoreBtn;
        private Button editLectureBtn;
        private Button editInfoBtn;
        private DataGridView lectureTable;
        private DataGridViewTextBoxColumn lectureName;
        private DataGridViewTextBoxColumn professor;
        private DataGridViewTextBoxColumn testDay;
        private DataGridViewTextBoxColumn testTime;
        private DataGridViewTextBoxColumn testName;
        private Label nameLabel;
        private Label stuNumLabel;
        private Label univLabel;
        private Label emailLabel;
        private PictureBox pictureBox;
    }
}