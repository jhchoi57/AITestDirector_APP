using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class MinimizeButton : Button
    {
        public MinimizeButton(CustomFonts customFonts) : base()
        {
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name = "minimizeButton";
            this.Size = new System.Drawing.Size(30, 28);
            this.TabIndex = 1;
            this.TabStop = false;
            this.Text = "_";
            this.Font = customFonts.LabelFont();
        }
    }
}
