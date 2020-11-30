using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Model;
using program.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.Controller
{
    public class MainController
    {
        private string URL = "https://test.inchang.dev:9000";
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
        }

        public string professorLoginRequest(string email, string password)
        {
            string targetURL = URL + "/account/professor/signin";

            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("id", "prof_test_id15");
            request.AddParameter("password", "1234");
            //request.AddParameter("id", email);
            //request.AddParameter("password", password);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentLoginRequest(string email, string password)
        {
            string targetURL = URL + "/account/student/signin";          
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            //request.AddParameter("email", "stu_test_id20");
            //request.AddParameter("password", "1234");
            request.AddParameter("email", email);
            request.AddParameter("password", password);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public void setUserInfo(string name, string id, string token, string school, string birth, Boolean isStudent)
        {
            if (isStudent)
            {
                me = new Student(name, id, token);
            }
            else
            {
                me = new Professor(name, id, token, school, birth);
            }
            Console.WriteLine("이름: " + me.Name + ", 아이디: " + me.ID + ", 토큰: " + me.Token);
        }

        public string professorSignupRequest(string email, string password, string name, string school, string birth)
        {
            string targetURL = URL + "/account/professor/signup";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("id", email);
            request.AddParameter("password", password);
            request.AddParameter("name", name);
            request.AddParameter("institute", school);
            request.AddParameter("birth_day", birth);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentSignupRequest(string email, string password, string name, string school, int id, string birth)
        {
            string targetURL = URL + "/account/student/signup";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("email", email);
            request.AddParameter("password", password);
            request.AddParameter("name", name);
            request.AddParameter("institute", school);
            request.AddParameter("id", id);
            request.AddParameter("birth_day", birth);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getProfessorInfoRequest()
        {
            string targetURL = URL + "/account/professor/" + me.ID;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getStudentInfoRequest()
        {
            string targetURL = URL + "/account/student/" + me.ID;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string modifyProfessorInfoRequest(string name, string birth, string school, string password)
        {
            string targetURL = URL + "/account/professor/" + me.ID;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddParameter("name", name);
            request.AddParameter("institute", school);
            request.AddParameter("password", password);
            request.AddParameter("birth_day", birth);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string modifyStudentInfoRequest(string name, string email, string birth, string school, string password)
        {
            string targetURL = URL + "/account/student/" + me.ID;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddParameter("name", name);
            request.AddParameter("email", email);
            request.AddParameter("institute", school);
            request.AddParameter("password", password);
            request.AddParameter("birth_day", birth);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string modifyStudentImageRequest(string fileName)
        {
            string exportPath = @"C:\" + me.ID + ".jpg";
            resizeImage(fileName, exportPath);
            string targetURL = URL + "/account/student/" + me.ID + "/profile-image";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", exportPath);
            request.AddParameter("key", me.Token);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getAllLecturesRequest()
        {
            string targetURL = URL + "/lecture?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string findLectureByNameReqeust(string lecture_name)
        {
            string targetURL = URL + "/lecture?key=" + me.Token + "&lecture_name=" + lecture_name;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string findLectureByProfessorReqeust(string professor)
        {
            string targetURL = URL + "/lecture?key=" + me.Token + "&professor_name=" + professor;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }
        public string findLectureReqeust(string lecture_name, string professor)
        {
            string targetURL = URL + "/lecture?key=" + me.Token + "&lecture_name=" + lecture_name + "&professor_name=" + professor;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getProfessorAllLecturesRequest()
        {
            string targetURL = URL + "/lecture?key=" + me.Token + "&professor_id=" + me.ID;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getStudentAllLecturesRequest()
        {
            string targetURL = URL + "/lecture/my?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorAddLectureRequest(string name, string time, int studentCnt, string semester)
        {
            string targetURL = URL + "/lecture/";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("name", name);
            request.AddParameter("key", me.Token);
            request.AddParameter("student_cnt", studentCnt);
            request.AddParameter("time", time);
            request.AddParameter("semester", semester);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorModifyLectureRequest(string id, string name, string time, int studentCnt, string semester)
        {
            string targetURL = URL + "/lecture/" + id;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddParameter("name", name);
            request.AddParameter("key", me.Token);
            request.AddParameter("student_cnt", studentCnt);
            request.AddParameter("time", time);
            request.AddParameter("semester", semester);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorRemoveLectureRequest(string id)
        {
            string targetURL = URL + "/lecture/" + id + "?key=" + me.Token;
            Console.WriteLine(targetURL);
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentEnterLectureRequest(string id)
        {
            string targetURL = URL + "/lecture/" + id + "/participate";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("key", me.Token);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentLeaveLectureRequest(string id)
        {
            string targetURL = URL + "/lecture/" + id + "/participate?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getAllExamReqeust()
        {
            string targetURL = URL + "/room?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string getExamRequest(string id)
        {
            string targetURL = URL + "/room/" + id + "?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorAddExamRequest(string lecture_id, string startTime, string endTime, string name, int percent, JArray questions, JArray answers)
        {
            string targetURL = URL + "/room/";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("key", me.Token);
            request.AddParameter("lecture_id", lecture_id);
            request.AddParameter("start_at", startTime);
            request.AddParameter("finish_at", endTime);
            request.AddParameter("exam_name", name);
            request.AddParameter("exam_time", endTime);
            request.AddParameter("score_rate", percent);
            request.AddParameter("questions_json", questions);
            request.AddParameter("problems_json", answers);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorModifyExamRequest(string room_id, string lecture_id, string startTime, string endTime, string name, int percent, JArray questions, JArray answers)
        {
            string targetURL = URL + "/room/" + room_id;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddParameter("key", me.Token);
            request.AddParameter("lecture_id", lecture_id);
            request.AddParameter("start_at", startTime);
            request.AddParameter("finish_at", endTime);
            request.AddParameter("exam_name", name);
            request.AddParameter("exam_time", endTime);
            request.AddParameter("score_rate", percent);
            request.AddParameter("questions_json", questions);
            request.AddParameter("problems_json", answers);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorRemoveExamRequest(string room_id)
        {
            string targetURL = URL + "/room/" + room_id + "?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorAddExamAnswer(string room_id, JArray answers)
        {
            string targetURL = URL + "/room/" + room_id + "/problem";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("problems", answers);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorGetAllAnswer(string room_id)
        {
            string targetURL = URL + "/room/" + room_id + "/problem?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorRemoveAllAnswer(string room_id)
        {
            string targetURL = URL + "/room/" + room_id + "/problem?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string studentAddAnswer(string room_id, string answer, int num)
        {
            string targetURL = URL + "/room/" + room_id + "/answer";
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("key", me.Token);
            request.AddParameter("value", answer);
            request.AddParameter("room", room_id);
            request.AddParameter("problem_num", num);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorGetAllExamResult()
        {
            string targetURL = URL + "/account/professor/" + me.ID + "/scores?key=" + me.Token;
            Console.WriteLine(URL);
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorGetAllStudentExamResult(string room_id)
        {
            string targetURL = URL + "/room/" + room_id + "/score?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorGetStudentExamVideo(string room_id, string student_id)
        {
            string targetURL = URL + "/room/" + room_id + "/video/" + student_id + "?key=" + me.Token;
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public string professorGetStudentExamBookmark(string room_id, string student_id)
        {
            string targetURL = URL + "/room/" + room_id + "/bookmark?user_id=" + student_id + "&key=" + me.Token;
            Console.WriteLine(targetURL);
            var client = new RestClient(targetURL);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            return response.Content;
        }

        public void moveToNextForm(Form targetForm)
        {
            Form prevForm = nowForm;
            formNavigator.Push(prevForm);
            nowForm = targetForm;
            nowForm.Show();
            prevForm.Visible = false;

            if (nowForm is ExamView) return;
            nowForm.Location = new Point(prevForm.Location.X + ((prevForm.Width - nowForm.Width) / 2), prevForm.Location.Y + ((prevForm.Height - nowForm.Height) / 2));
        }

        public void moveToPreviousForm()
        {
            Form prevForm = nowForm;
            nowForm = formNavigator.Pop();
            if (nowForm is StudentHomeView && (prevForm is StudentLectureEditView || prevForm is ExamView))
            {
                StudentHomeView studentHomeView = (StudentHomeView)nowForm;
                studentHomeView.TestInfoCancelBtn.PerformClick();
                studentHomeView.setUserExam();
            }
            else if (nowForm is ProfessorHomeView && prevForm is MakeExamView)
            {
                ProfessorHomeView professorHomeView = (ProfessorHomeView)nowForm;
                professorHomeView.setUserExam();
            }
            nowForm.Show();
            prevForm.Visible = false;

            if (nowForm is ExamView) return;
            nowForm.Location = new Point(prevForm.Location.X + ((prevForm.Width - nowForm.Width) / 2), prevForm.Location.Y + ((prevForm.Height - nowForm.Height) / 2));

        }

        private void resizeImage(string importPath, string exportPath)
        {
            Image originalImage = Image.FromFile(importPath);

            double ratioX = 600 / (double)originalImage.Width;
            double ratioY = 600 / (double)originalImage.Height;

            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Bitmap newImage = new Bitmap(600, 600);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.FillRectangle(Brushes.Black, 0, 0, newImage.Width, newImage.Height);
                g.DrawImage(originalImage, (600 - newWidth) / 2, (600 - newHeight) / 2, newWidth, newHeight);
            }
            Console.WriteLine(exportPath);
            newImage.Save(exportPath, ImageFormat.Jpeg);

            originalImage.Dispose();
            newImage.Dispose();
        }
    }
}
