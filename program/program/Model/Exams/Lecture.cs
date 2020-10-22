using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model.Exams
{
    /**
     * Lecture 클래스
     * 
     * 멤버 변수
     *  - Professor mainProfessor: 담당 교수
     *  - string name: 강의명
     *  - string no: 강의 번호
     *  - int year: 강의 년도
     *  - string semester: 강의 학기
     *  
     * 멤버 함수
     *  - Lecture(): 생성자 초기화 without data
     *  - Lecture(mainProfessor, name, no, year, semester): 생성자 초기화
     *  
     */
    public class Lecture
    {
        /**
         * 담당 교수
         * ex) 이병헌, 송중기 등
         */
        private string professor { get; set; }
        public string Professor
        {
            get { return professor; }
            set { professor = value; }
        }
        /**
         * 강의명
         * ex) 운영체제, C프로그래밍 및 실습, ... 등
         */
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /**
         * 강의 ID
         * ex) d37b8956-908b-4220-a8e8-b7fc7c7cea4a 등
         */
        private string id { get; set; }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        /**
         * 강의 년도
         * ex) 2020, 2021, 2022, ... 등
         */
        private int studentCnt { get; set; }
        public int StudentCnt
        {
            get { return studentCnt; }
            set { studentCnt = value; }
        }

        /**
         * 학기 정보
         * ex) 2020-1학기, 2020-2학기, 2020-여름학기, 2020-겨울학기 등
         */
        private string semester { get; set; }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        /**
         * 강의 시간
         * ex) 월/화 14:00~15:30 등
         */
        private string time { get; set; }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        /**
         * 생성자 초기화 without data
         */
        public Lecture()
        {
            professor = "";
            name = "";
            id = "";
            semester = "";
            studentCnt = 0;
            time = "";
        }
        /**
         * 생성자 초기화 
         */
        public Lecture(string id, string name, string professor, int studentCnt, string semester, string time)
        {
            this.id = id;
            this.name = name;
            this.professor = professor;
            this.studentCnt = studentCnt;
            this.semester = semester;
            this.time = time;
        }

        public void modifyLecture(string name, string professor, int studentCnt, string semester, string time)
        {
            this.name = name;
            this.professor = professor;
            this.studentCnt = studentCnt;
            this.semester = semester;
            this.time = time;
        }
    }
}
