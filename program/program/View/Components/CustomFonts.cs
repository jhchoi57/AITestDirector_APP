using RestSharp;
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
        private static FontFamily fontFamilyBold;
        private static FontFamily fontFamilyLight;
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



            //string targetURL = "https://test.inchang.dev:9000/static/NanumBarunGothicBold.ttf";

            //var client = new RestClient(targetURL);
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            ////request.AddParameter("id", email);
            ////request.AddParameter("password", password);
            //IRestResponse response = client.Execute(request);

            //IntPtr ptr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(response.Content.Length);


            //privateFont = new PrivateFontCollection();

            //privateFont.AddMemoryFont(ptr, response.Content.le)

            //FontFamily fontFamilyBold = new System.Windows.Media.FontFamily(new Uri("https://test.inchange.dev:9000/static/NanumBarunGothicBold.ttf", "NanumBarunGothicBold");
            //FontFamily fontFamilyLight = new System.Windows.Media.FontFamily(new Uri("https://test.inchange.dev:9000/static/NanumBarunGothicLight.ttf", "light"));

            privateFont.AddFontFile("./src/Assets/Fonts/NanumBarunGothic.ttf");
            privateFont.AddFontFile("./src/Assets/Fonts/NanumBarunGothicBold.ttf");
            privateFont.AddFontFile("./src/Assets/Fonts/NanumBarunGothicLight.ttf");
            privateFont.AddFontFile("./src/Assets/Fonts/NanumBarunGothicUltraLight.ttf");
        }
    }
}
