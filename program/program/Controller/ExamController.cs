using CefSharp.DevTools.Debugger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using program.Model;
using program.Model.Exams;
using program.View;
using program.View.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program.Controller
{
    class ExamController
    {
        private Queue<Student> enterQueue;
        private Queue<Student> exitQueue;
        private Queue<Doubt> doubtQueue;
        private Queue<string> messageQueue;
        private Queue<string> noticeQueue;
        private Queue<Chat> chatQueue;
        private WebSocketSharp.WebSocket ws;
        private string URL;
        private Boolean isStudent;

        public ExamController(Queue<string> messageQueue, Queue<string> noticeQueue, string room_id, string user_token)
        {
            this.noticeQueue = noticeQueue;
            this.messageQueue = messageQueue;
            URL = "wss://test.inchang.dev:9000/ws/" + room_id + "/" + user_token + "/pc/";
            //Console.WriteLine(URL);
            isStudent = true;
        }

        public ExamController(Queue<Chat> chatQueue, Queue<Doubt> doubtQueue, Queue<Student> enterQueue, Queue<Student> exitQueue, string room_id, string user_token)
        {
            this.chatQueue = chatQueue;
            this.enterQueue = enterQueue;
            this.exitQueue = exitQueue;
            this.doubtQueue = doubtQueue;
            URL = "wss://test.inchang.dev:9000/ws/" + room_id + "/" + user_token + "/pc/";
            //Console.WriteLine(URL);
            isStudent = false;
        }

        public Boolean connect()
        {
            try
            {
                ws = new WebSocketSharp.WebSocket(URL);
                ws.Connect();

                if (!ws.IsAlive) return false;

                ws.OnMessage += (sender, e) =>
                {
                    JObject jObject;
                    Console.WriteLine(e.Data);
                    jObject = (JObject)JsonConvert.DeserializeObject(e.Data);
                    string type = (string)jObject["type"];

                    if (type.Equals("user_entered"))
                    {
                        JObject jMessage = (JObject)jObject["message"];
                        Console.WriteLine(jMessage);
                        string id = (string)jMessage["id"];
                        string room_id = (string)jMessage["room"];
                        string user_id = (string)jMessage["user_id"];
                        string user_type = (string)jMessage["user_type"];
                        string user_name = (string)jMessage["user_name"];
                        string client_type = (string)jMessage["client_type"];
                        string remote_ip = (string)jMessage["remote_ip"];

                        if (!isStudent)
                        {
                            if (user_type.Equals("student"))
                            {
                                enterQueue.Enqueue(new Student(user_name, user_id, ""));
                            }
                        }
                    }
                    else if (type.Equals("notice_message"))
                    {
                        string message = (string)jObject["message"];
                        Console.WriteLine(message);

                        if (isStudent)
                        {
                            noticeQueue.Enqueue(message);
                        }
                    }
                    else if (type.Equals("whisper"))
                    {
                        string message = (string)jObject["message"];
                        string receiver_id = (string)jObject["receiver_id"];
                        string receiver_name = (string)jObject["receive_name"];
                        string transmitter_id = (string)jObject["transmitter_id"];
                        string transmitter_name = (string)jObject["transmitter_name"];

                        if (isStudent)
                        {
                            messageQueue.Enqueue(message);
                        }
                        else
                        {
                            chatQueue.Enqueue(new Chat(transmitter_id, message));
                        }
                    }
                    else if (type.Equals("user_exited"))
                    {
                        JObject jMessage = (JObject)jObject["message"];
                        Console.WriteLine(jMessage);
                        string id = (string)jMessage["id"];
                        string room_id = (string)jMessage["room"];
                        string user_id = (string)jMessage["user_id"];
                        string user_type = (string)jMessage["user_type"];
                        string user_name = (string)jMessage["user_name"];
                        string client_type = (string)jMessage["client_type"];
                        string remote_ip = (string)jMessage["remote_ip"];

                        if (!isStudent)
                        {
                            if (user_type.Equals("student"))
                            {
                                exitQueue.Enqueue(new Student(user_name, user_id, ""));
                            }
                        }
                    }
                    else if (type.Equals("change_exam_status"))
                    {
                        string status = (string)jObject["finish"];
                        if (status.Equals("start"))
                        {
                            Console.WriteLine(status);
                        }
                        else if (status.Equals("pause"))
                        {
                            Console.WriteLine(status);
                        }
                        else if (status.Equals("resume"))
                        {
                            Console.WriteLine(status);
                        }
                        else
                        {
                            Console.WriteLine("finish");
                        }
                    }
                    else if (type.Equals("cheat_alert"))
                    {
                        JObject jMessage = (JObject)jObject["message"];
                        Console.WriteLine(jMessage);
                        string id = (string)jMessage["id"];
                        string room_id = (string)jMessage["room"];
                        string user_id = (string)jMessage["user"];
                        string source = (string)jMessage["source"];
                        string detected_at = (string)jMessage["detected_at"];
                        string probability = (string)jMessage["probability"];

                        if (!isStudent)
                        {
                            doubtQueue.Enqueue(new Doubt(source, user_id));
                        }
                    }
                    else if (type.Equals("user_list"))
                    {
                        JArray jMessage = (JArray)jObject["message"];
                        int count = jMessage.Count;
                        for (int i = 0; i < count; i++)
                        {
                            string user_type = (string)jMessage[i]["user_type"];

                            if (!isStudent)
                            {
                                if (user_type.Equals("student"))
                                {
                                    string user_id = (string)jMessage[i]["user_id"];
                                    string user_name = (string)jMessage[i]["user_name"];
                                    enterQueue.Enqueue(new Student(user_name, user_id, ""));
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(jObject);
                        Console.WriteLine("여긴가?");
                    }
                };
                ws.OnClose += (send, e) =>
                {
                    Console.WriteLine("-----On close-----");
                    Console.WriteLine(e.Reason);
                };
                ws.OnOpen += (sender, e) =>
                {
                    Console.WriteLine("----- OnOpen-----");
                    Console.WriteLine(e);
                };
                ws.OnError += (sender, e) =>
                {
                    Console.WriteLine("----- OnError-----");
                    Console.WriteLine(e);
                };

                Console.WriteLine("성공!");
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean disconnect()
        {
            try
            {
                ws.CloseAsync();
                ws.Close(WebSocketSharp.CloseStatusCode.Normal);
                return true;
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean isConnected()
        {
            return ws.IsAlive;
        }

        public Boolean healthCheck()
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "health_check");
                jMessage.Add("data", "hello");
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean professorChangeExamStatus(string status)
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "change_exam_status");
                jMessage.Add("status", status);
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean professorNotice(string notice)
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "notice_message");
                jMessage.Add("message", notice);
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean professorSendMessage(string student_id, string message)
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "whisper");
                jMessage.Add("receiver", student_id);
                jMessage.Add("message", message);
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean getAllExamUser()
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "user_list_request");
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public Boolean studentSendMessage(string message)
        {
            try
            {
                JObject jMessage = new JObject();
                jMessage.Add("type", "whisper");
                jMessage.Add("message", message);
                ws.Send(jMessage.ToString());
                return true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }
    }
}
