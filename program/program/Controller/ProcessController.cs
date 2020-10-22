using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace program.Controller
{
    public class ProcessController
    {
        public ProcessController()
        {
            try

            {

                Process[] allProc = Process.GetProcesses();    //시스템의 모든 프로세스 정보 출력

                int i = 1;

                Console.WriteLine("****** 모든 프로세스 정보 ******");

                Console.WriteLine("현재 실행중은 모든 프로세스 수 : {0}", allProc.Length);

                foreach (Process p in allProc)

                {

                    Console.WriteLine("***** {0}번째 프로세스 ******", i++);

                    WriteProcessInfo(p);

                    Console.WriteLine();

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
        }

        public void WriteProcessInfo(Process processInfo)

        {

            Console.WriteLine("Process : {0}", processInfo.ProcessName);

            Console.WriteLine("시작시간 : {0}", processInfo.StartTime);

            Console.WriteLine("프로세스 PID : {0}", processInfo.Id);

            Console.WriteLine("메모리 : {0}", processInfo.VirtualMemorySize);

        }
    }
}
