using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Model;
using program.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.Controller
{
    public class MainController
    {
        private Stack<Form> formNavigator;
        private Form nowForm { get; set; }
        public Form NowForm
        {
            get { return nowForm; }
            set { nowForm = value; }
        }
        private User me { get; set; }
        public User Me
        {
            get { return me; }
            set { me = value; }
        }
        public MainController()
        {
            me = null;
            formNavigator = new Stack<Form>();
            nowForm = new LoginView(this);
            //nowForm = new ProfessorDetailScoreView(this);
            //nowForm = new StudentHomeView(this);
        }

        public string professorLoginRequest(string email, string password)
        {
            string targetURL = "https://test.inchang.dev:9000/account/professor/signin";

            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("id", "prof_test_id");
            request.AddParameter("password", "1234");
            //request.AddParameter("id", email);
            //request.AddParameter("password", password);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentLoginRequest(string email, string password)
        {
            string targetURL = "https://test.inchang.dev:9000/account/student/signin";          
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            //request.AddParameter("id", "1234");
            //request.AddParameter("password", "1234");
            request.AddParameter("email", email);
            request.AddParameter("password", password);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response.Content;
        }

        public void setUserInfo(string name, string id, string token, Boolean isStudent)
        {
            if(isStudent)
            {
                me = new Student(name, id, token);
            } 
            else
            {
                me = new Professor(name, id, token);
            }
            Console.WriteLine("이름: " + me.Name + ", 아이디: " + me.ID + ", 토큰: " + me.Token);
        }

        public void moveToNextForm(Form targetForm)
        {
            nowForm.Visible = false;
            formNavigator.Push(nowForm);
            nowForm = targetForm;
            nowForm.Show();
        }

        public void moveToPreviousForm()
        {
            nowForm.Visible = false;
            nowForm = formNavigator.Pop();
            if (nowForm is StudentHomeView)
            {
                Console.WriteLine("다시 로딩해주세요~");
                // 학생 홈으로 돌아올 때는 필요한 정보들 다시 로딩하기
            }
            nowForm.Show();
        }
    }
}
