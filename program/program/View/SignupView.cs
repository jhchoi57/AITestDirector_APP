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
    public partial class SignupView : Form
    {
        public SignupView()
        {
            InitializeComponent();
        }

        // 취소 버튼 클릭
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
