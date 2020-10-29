using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    /**
     * Professor 클래스
     * 
     * 상속 클래스
     *  - User 클래스
     * 
     * 멤버 함수
     *  - Professor(): 생성자 초기화 without data
     *  - Professor(name, id, token): 생성자 초기화 
     */
    class Professor : User
    {
        /**
         * 생성자 초기화 without data
         */
        public Professor() : base()
        {

        }
        /**
         * 생성자 초기화 
         */
        public Professor(string name, string id, string token)
            : base(name, id, token)
        {

        }
    }
}
