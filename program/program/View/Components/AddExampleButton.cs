using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class AddExampleButton : Button
    {
        public AddExampleButton(CustomFonts customFonts) : base()
        {
            Size = new System.Drawing.Size(80, 28);
            Font = customFonts.NormalFont();
            Text = "+ 보기 추가";
            BackColor = Color.White;
            FlatAppearance.BorderSize = 1;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }
    }
}
