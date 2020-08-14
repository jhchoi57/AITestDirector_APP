using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class AddSubQuestionButton : Button
    {
        public AddSubQuestionButton() : base()
        {
            // addSubQuestionButton
            this.Text = "+ 하위 문제";
            this.Size = new Size(100, 27);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.Font = CustomFonts.TextBoxFont;
        }
    }
}
