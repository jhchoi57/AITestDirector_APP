using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.View.Components
{
    public static class CustomFonts
    {
        private static Font normalFont { get; set; }
        private static Font labelFont { get; set; }
        private static Font textBoxFont { get; set; }
        private static Font smallFont { get; set; }

        public static Font NormalFont
        {
            get { return normalFont; }
            set { normalFont = value; }
        }

        public static Font LabelFont
        {
            get { return labelFont; }
            set { labelFont = value; }
        }

        public static Font TextBoxFont
        {
            get { return textBoxFont; }
            set { textBoxFont = value; }
        }

        public static Font SmallFont
        {
            get { return smallFont; }
            set { smallFont = value; }
        }

        static CustomFonts()
        {
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
            normalFont = new Font(privateFont.Families[1], 10f);
            labelFont = new Font(privateFont.Families[1], 13f);
            textBoxFont = new Font(privateFont.Families[1], 12f);
            smallFont = new Font(privateFont.Families[1], 8f);
        }
    }
}
