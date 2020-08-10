using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    /*
     * Student 클래스
     * 
     * 상속 클래스
     *  - User 클래스
     *  
     * 멤버 변수
     *  - string no: 학생 번호
     * 
     * 멤버 함수
     *  - Student(): 생성자 초기화 without data
     *  - Student(name, email, studentNo): 생성자 초기화
     * 
     * */
    class Student : User
    {
        /*
         * 학생 번호
         * 19012345, 20003841, ... 등
         * */
        private string no { get; set; }
        public string No
        {
            get { return no; }
            set { no = value; }
        }
        /*
         * 생성자 초기화 without data
         * */
        public Student() : base()
        {

        }
        /*
         * 생성자 초기화
         * */
        public Student(string name, string email, string studentNo)
            : base(name, email)
        {
            this.no = studentNo;
        }
    }
}
