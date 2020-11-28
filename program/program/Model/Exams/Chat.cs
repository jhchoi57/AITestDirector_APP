using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model.Exams
{
    class Chat
    {
        private string studentID { get; set; }
        private string message { get; set; }
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public Chat (string studentID, string message)
        {
            this.studentID = studentID;
            this.message = message;
        }
    }
}
