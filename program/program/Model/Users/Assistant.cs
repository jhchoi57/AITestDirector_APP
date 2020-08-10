using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Model
{
    /*
     * Assistant 클래스
     * 
     * 상속 클래스
     *  - User 클래스
     * 
     * 멤버 함수
     *  - Assistant(): 생성자 초기화 without data
     *  - Assistant(name, email): 생성자 초기화
     * 
     * */
    class Assistant : User
    {
        /*
         * 생성자 초기화 without data
         * */
        public Assistant() : base()
        {

        }
        /*
         * 생성자 초기화
         * */
        public Assistant(string name, string email) 
            : base(name, email)
        {

        } 
    }
}
