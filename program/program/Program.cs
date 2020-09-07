using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //Application.Run(new View.MakeExamView());
            //Application.Run(new View.StudentHomeView());
            //Application.Run(new View.LoginView());
            //Application.Run(new View.StudentScoreCheckView());
            //Application.Run(new View.ProfessorHomeView());
            Application.Run(new View.ProfessorLectureEditView());
        }
    }
}
