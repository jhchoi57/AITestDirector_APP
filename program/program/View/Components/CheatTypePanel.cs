using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class CheatTypePanel : Panel
    {
        private Panel cheatColorPanel;
        private Label cheatTypeLabel;
        public CheatTypePanel(CustomFonts customFonts, Color cheatColor, string cheatType)
        {
            cheatColorPanel = new Panel();
            cheatTypeLabel = new Label();

            this.Size = new Size(140, 30);
            this.Controls.Add(cheatColorPanel);
            this.Controls.Add(cheatTypeLabel);

            cheatColorPanel.Size = new Size(20, 20);
            cheatColorPanel.Location = new Point(0, 5);
            cheatColorPanel.BackColor = cheatColor;

            cheatTypeLabel.Size = new Size(115, 21);
            cheatTypeLabel.Text = cheatType;
            cheatTypeLabel.Font = customFonts.TextBoxFont();
            cheatTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            cheatTypeLabel.Location = new Point(25, 5);
            
        }
    }
}
