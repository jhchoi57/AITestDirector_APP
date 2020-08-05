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
    public partial class StudentHomeView : Form
    {
        public StudentHomeView()
        {
            InitializeComponent();
                  // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
                  // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
        }

        private void signupMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signupExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
