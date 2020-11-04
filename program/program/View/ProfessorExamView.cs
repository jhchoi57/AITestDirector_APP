using program.Controller;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View
{
    public partial class ProfessorExamView : Form
    {
        private CustomFonts customFonts;
        private ChatPanel chatPanel;
        private MainController mainController;
        private TopBarPanel topBarPanel;

        public ProfessorExamView(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;

            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ProfessorExamView_Load(object sender, EventArgs e)
        {
            // 폰트
            customFonts = new CustomFonts();


            this.chatPanel = new ChatPanel(customFonts, "학생을", "선택해주세요");
            this.chatPanel.Location = new Point(18, 242);
            this.chatPanel.BringToFront();
            this.testInfoPanel.Controls.Add(this.chatPanel);

            //상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            //Sample 
            studentTable.Rows.Add("17011495", "최주형");
            studentTable.Rows.Add("17011496", "홍길동");
            studentTable.Rows.Add("17011497", "이순신");
            studentTable.Rows.Add("17011498", "아무개");
            studentTable.Rows.Add("17011499", "최주형");
            studentTable.Rows.Add("17011500", "최주형");
            studentTable.Rows.Add("17011501", "최주형");
            studentTable.Rows.Add("17011502", "최주형");

        }

        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chatPanel.changeHeaderLabelText(studentTable.Rows[e.RowIndex].Cells[0].Value.ToString(),
                studentTable.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
