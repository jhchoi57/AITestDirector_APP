using program.Model.Exams;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    class Exam
    {
        private Lecture examLecture { get; set; }
        public Lecture ExamLecture
        {
            get { return examLecture; }
            set { examLecture = value; }
        }

        private string no { get; set; }
        public string No
        {
            get { return no; }
            set { no = value; }
        }

        private float totalScore { get; set; }
        public float TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        private List<MainQuestion> mainQuestions { get; set; }
        public List<MainQuestion> MainQuestions
        {
            get { return mainQuestions; }
            set { mainQuestions = value; }
        }

        private DateTime startTime { get; set; }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private DateTime endTime { get; set; }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}
