using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program.Controller;
using program.View.Components;

namespace program.View
{
    public partial class BookMarkView : Form
    {
        private MainController mainController;
        private TopBarPanel topBarPanel;
        public BookMarkView(MainController mainController)
        {
            InitializeComponent();
            // 프로그램 상단바 및 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 프로그램 중앙에 메인패널 위치
            //this.mainPanel.Location = new System.Drawing.Point((this.Width - this.mainPanel.Width) / 2, (this.Height - this.mainPanel.Height) / 2);
            this.mainController = mainController;
        }

        private void VideoView_Load(object sender, EventArgs e)
        {
            // 폰트
            CustomFonts customFonts = new CustomFonts();
            // NormalFont : 10f
            // LabelFont : 13f
            // TextBoxFont : 12f
            // SmallFont : 8f
            // TitleFont: 20f
            // SubTitleFont : 17f

            bookMarkLbl.Font = customFonts.SubTitleFont();
            exitBtn.Font = customFonts.TextBoxFont();
            bookMarkTable.Font = customFonts.NormalFont();


            // 이미지
            bookMarkPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bookMarkPictureBox.Image = System.Drawing.Image.FromFile("../../src/Assets/Images/face.png");

            // 상단바
            this.topBarPanel = new TopBarPanel(customFonts);
            this.topBarPanel.Location = new Point(0, 0);
            this.Controls.Add(topBarPanel);

            // 테이블 Sample
            bookMarkTable.Rows.Add("가나다", "2020-10-22 13:11:56", "음성?");
            bookMarkTable.Rows.Add("가나다", "2020-10-22 13:11:56", "화면에 다른 사람?");
            bookMarkTable.Rows.Add("가나다", "2020-10-22 13:11:56", "시선 이탈?");

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            mainController.moveToPreviousForm();
        }

        private void bookMarkPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
