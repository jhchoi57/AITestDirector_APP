using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ExitButton : Button
    {
        public ExitButton(CustomFonts customFonts) : base()
        {
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name = "exitButton";
            this.Size = new System.Drawing.Size(30, 28);
            this.TabIndex = 0;
            this.TabStop = false;
            this.Text = "✕";
            this.Font = customFonts.LabelFont();
        }
    }
}
