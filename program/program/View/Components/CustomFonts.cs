using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.View.Components
{
    public class CustomFonts
    {
        private static PrivateFontCollection privateFont;
        public Font NormalFont()
        {
            return new Font(privateFont.Families[1], 10f);
        }

        public Font LabelFont()
        {
            return new Font(privateFont.Families[1], 13f);
        }

        public Font TextBoxFont()
        {
            return new Font(privateFont.Families[1], 12f);
        }

        public Font SmallFont()
        {
            return new Font(privateFont.Families[1], 8f);
        }

        public Font TitleFont()
        {
            return new Font(privateFont.Families[1], 20f);
        }

        public Font SubTitleFont()
        {
            return new Font(privateFont.Families[1], 17f);
        }

        public Font TimeLabelFont()
        {
            return new Font(privateFont.Families[1], 19f);
        }

        public Font CopyRightFont()
        {
            return new Font(privateFont.Families[2], 8f);
        }

        public Font LectureTitleFont()
        {
            return new Font(privateFont.Families[2], 30f, FontStyle.Bold);
        }

        static CustomFonts()
        {
            privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("../../src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
        }
    }
}
