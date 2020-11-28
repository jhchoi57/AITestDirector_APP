using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model.Exams
{
    class Doubt
    {
        private string type { get; set; }
        private string student_id { get; set; }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public Doubt(string type, string student_id)
        {
            this.type = type;
            this.student_id = student_id;
        }
    }
}
