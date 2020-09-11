using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class TopBarPanel : Panel
    {
        private Label tabNameLabel;
        private ExitButton exitButton;
        private MinimizeButton minimizeButton;
        private Boolean isMouseDown;
        private Point Pos;
        public string TabName
        {
            get { return tabNameLabel.Text; }
            set { tabNameLabel.Text = value; }
        }

        public TopBarPanel(CustomFonts customFonts) : base()
        {
            this.Size = new Size(1264, 28);
            this.BackColor = Color.White;

            exitButton = new ExitButton(customFonts);
            exitButton.Location = new Point(1234, 0);
            this.Controls.Add(exitButton);
            
            minimizeButton = new MinimizeButton(customFonts);
            minimizeButton.Location = new Point(1204, 0);
            this.Controls.Add(minimizeButton);
            minimizeButton.Click += minimizeButton_Click_1;

            tabNameLabel = new Label();
            tabNameLabel.Text = "ExamDirector";
            tabNameLabel.Location = new Point(5, 5);
            tabNameLabel.Font = customFonts.NormalFont();
            this.Controls.Add(tabNameLabel);

            isMouseDown = false;
            this.MouseDown += mouseDown_1;
            this.MouseMove += mouseMove_1;
            this.MouseUp += mouseUp_1;
        }

        private void mouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TopBarPanel topBarPanel = (TopBarPanel)sender;
            Form form = (Form)topBarPanel.Parent;

            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                Pos = e.Location;
            }
        }

        private void mouseMove_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TopBarPanel topBarPanel = (TopBarPanel)sender;
            Form form = (Form)topBarPanel.Parent;

            if (isMouseDown)
            {
                form.Location = new Point(form.Location.X + (e.X - Pos.X), form.Location.Y + (e.Y - Pos.Y));
            }
        }

        private void mouseUp_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                Pos = e.Location;
            }
        }

            // 최소화 버튼
        private void minimizeButton_Click_1(object sender, EventArgs e)
        {
            MinimizeButton minimizeButton = (MinimizeButton)sender;
            TopBarPanel topBarPanel = (TopBarPanel)minimizeButton.Parent;
            Form form = (Form)topBarPanel.Parent;

            form.WindowState = FormWindowState.Minimized;
        }
    }
}
