using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class QuestionDeleteButton : Button
    {
        public QuestionDeleteButton(CustomFonts customFonts) : base()
        {
            Size = new System.Drawing.Size(40, 28);
            Font = customFonts.SmallFont();
            Text = "제 거";
            ForeColor = Color.White;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }
    }
}
