using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class NoticePanel : Panel
    {
        private Panel headerPanel;
        private Label headerLabel;
        private Panel contentPanel;
        private Label noticeLabel;
        private Button OKButton;
        public NoticePanel(CustomFonts customFonts)
        {
            headerPanel = new Panel();
            contentPanel = new Panel();
            headerLabel = new Label();
            noticeLabel = new Label();
            OKButton = new Button();

            this.Size = new Size(685, 340);
            this.BackColor = Color.White;
            this.Controls.Add(headerPanel);
            this.Controls.Add(contentPanel);
            this.Controls.Add(OKButton);

            headerPanel.Size = new Size(681, 28);
            headerPanel.BackColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            headerPanel.Location = new Point(2, 2);
            headerPanel.Controls.Add(headerLabel);

            headerLabel.Text = "공지사항";
            headerLabel.ForeColor = Color.White;
            headerLabel.Font = customFonts.LabelFont();
            headerLabel.Location = new Point(3, 3);

            contentPanel.Size = new Size(681, 253);
            contentPanel.Location = new Point(2, 30);
            contentPanel.BackColor = Color.White;
            contentPanel.AutoScroll = true;
            contentPanel.Controls.Add(noticeLabel);

            noticeLabel.Text = "- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n- 혼난다.\n";
            noticeLabel.Font = customFonts.TextBoxFont();
            noticeLabel.AutoSize = true;
            noticeLabel.MaximumSize = new Size(671, 0);
            noticeLabel.Location = new Point(5, 5);

            OKButton.Size = new Size(91, 40);
            OKButton.Location = new Point(295, 288);
            OKButton.Font = customFonts.LabelFont();
            OKButton.Text = "확   인";
            OKButton.BackColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            OKButton.FlatAppearance.BorderSize = 0;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.ForeColor = Color.White;
            OKButton.Click += OKButton_Click_1;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, 
                borderColor, borderWidth, ButtonBorderStyle.Solid, 
                borderColor, borderWidth, ButtonBorderStyle.Solid, 
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void OKButton_Click_1 (object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }

        public void showNotice(string notice)
        {
            noticeLabel.Text = notice;
            this.BringToFront();
            this.Visible = true;
        }
    }
}
