using program.Model.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    /**
     * User 클래스
     * 
     * 멤버 변수
     *  - string name: 사용자 이름
     *  - string id: 사용자 id (학생: 학번, 교수: 아이디)
     *  - string token: 사용자 토큰
     *  
     * 멤버 함수
     *  - User() : 생성자 초기화 without data
     *  - User(name, id, token) : 생성자 초기화
     */
    public class User
    {
        /**
         * 사용자 이름
         * ex) 강동원, 이병헌, ... 등 
         */
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /**
         * 사용자 아이디
         * ex) example@google.co.kr, 17052345 ... 등
         */
        private string id { get; set; }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        /**
         * 사용자 토큰
         * ex) 81dc9bdb52d04dc20036dbd8313ed055 ... 등
         */
        private string token { get; set; }
        public string Token
        {
            get { return token; }
            set { token = value; }
        }
        /**
         *  사용자 강의 리스트
         */
        private List<Lecture> lectures { get; set; }
        public List<Lecture> Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }

        /**
         * 생성자 초기화 without data
         */
        public User()
        {
            name = "";
            id = "";
            token = "";
            lectures = new List<Lecture>();
        }
        /**
         * 생성자 초기화 
         */
        public User(string name, string id, string token)
        {
            this.name = name;
            this.id = id;
            this.token = token;
            lectures = new List<Lecture>();
        }
    }
}
