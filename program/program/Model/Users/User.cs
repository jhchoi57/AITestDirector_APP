using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    /*
     * User 클래스
     * 
     * 멤버 변수
     *  - string name: 사용자 이름
     *  - string email: 사용자 이메일
     *  
     * 멤버 함수
     *  - User() : 생성자 초기화 without data
     *  - User(name, email) : 생성자 초기화
     * */
    class User
    {
        /*
         * 사용자 이름
         * ex) 강동원, 이병헌, ... 등
         * */
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /*
         * 사용자 이메일
         * ex) example@google.co.kr, ... 등
         * */
        private string email { get; set; }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        /*
         * 생성자 초기화 without data
         * */
        public User()
        {
            name = "";
            email = "";
        }
        /*
         * 생성자 초기화
         * */
        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
