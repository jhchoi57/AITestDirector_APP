using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using program.Controller;
using program.Model;
using program.View;

namespace program
{
    static class Program
    {
        //public static LoginView LoginView = new LoginView();
        //public static StudentHomeView StudentHomeView = new StudentHomeView();
        //public static MakeExamView MakeExamView = new MakeExamView();
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainController mainController = new MainController();

            Application.Run(mainController.NowForm);
        }
    }
}
