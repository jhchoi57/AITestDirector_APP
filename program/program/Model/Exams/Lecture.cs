using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model.Exams
{
    /*
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
     * */
    class Lecture
    {
        /*
         * 담당 교수
         * ex) Professor 클래스 사용
         * */
        private Professor mainProfessor { get; set; }
        public Professor MainProfessor
        {
            get { return mainProfessor; }
            set { mainProfessor = value; }
        }
        /*
         * 강의명
         * ex) 운영체제, C프로그래밍 및 실습, ... 등
         * */
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        /*
         * 강의 번호
         * ex) 아직 어떻게 설정할지 미정
         * */
        private string no { get; set; }
        public string No
        {
            get { return no; }
            set { No = value; }
        }

        /*
         * 강의 년도
         * ex) 2020, 2021, 2022, ... 등
         * */
        private int year { get; set; }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        /*
         * 학기 정보
         * ex) 1학기, 2학기, 여름학기, 겨울학기 등
         * */
        private string semester { get; set; }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        /*
         * 생성자 초기화 without data
         * */
        public Lecture()
        {
            mainProfessor = null;
            name = "";
            no = "";
            year = 0;
            semester = "";
        }
        /*
         * 생성자 초기화 
         * */
        public Lecture(Professor mainProfessor, string name, string no, int year, string semester)
        {
            this.mainProfessor = mainProfessor;
            this.name = name;
            this.no = no;
            this.year = year;
            this.semester = semester;
        }
    }
}
