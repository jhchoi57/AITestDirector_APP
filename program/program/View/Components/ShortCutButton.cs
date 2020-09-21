using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.View.Components
{
    class ShortCutButton : Button
    {
        private int mainQuestionNo { get; set; }
        private int subQuestionNo { get; set; }
        public int MainQuestionNo
        {
            get { return mainQuestionNo; }
            set { mainQuestionNo = value; }
        }
        public int SubQuestionNo
        {
            get { return subQuestionNo; }
            set { subQuestionNo = value; }
        }
        public ShortCutButton(CustomFonts customFonts, int number) : base() 
        {
            ForeColor = Color.Black;
            BackColor = Color.White;
            Text = number.ToString();
            Font = customFonts.NormalFont();
            Size = new System.Drawing.Size(75, 25);
            FlatAppearance.BorderSize = 1;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }
    }
}
