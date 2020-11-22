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
        private Process[] allProc;
        public ProcessController()
        {
            GetProcess();
        }

        public void GetProcess()
        {
            try {
                allProc = Process.GetProcesses();    //시스템의 모든 프로세스 정보 출력
                int i = 1;

                Console.WriteLine("****** 모든 프로세스 정보 ******");
                Console.WriteLine("현재 실행중은 모든 프로세스 수 : {0}", allProc.Length);

                foreach (Process p in allProc) {
                    //Console.WriteLine("***** {0}번째 프로세스 ******", i++);
                    //WriteProcessInfo(p);
                    //Console.WriteLine();
                }
            }

            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void KillProcess()
        {
            foreach (Process processInfo in allProc)
            {
                /*
                if(processInfo.ProcessName == "chrome")
                {                    
                    Console.WriteLine(" 크롬 종료 이벤트 ");
                    //processInfo.Kill();
                }
                */
            }
        }

        private void WriteProcessInfo(Process processInfo) 
        {
            Console.WriteLine("Process : {0}", processInfo.ProcessName);
            Console.WriteLine("시작시간 : {0}", processInfo.StartTime);
            Console.WriteLine("프로세스 PID : {0}", processInfo.Id);
            Console.WriteLine("메모리 : {0}", processInfo.VirtualMemorySize);
        }

        /*-----------Windows 10 기본 프로세스---------------//
        System Idle Process - 시스템 유휴 시간 프로세스
        System.exe
        smss.exe
        csrss.exe
        wininit.exe
        services.exe
        lsass.exe
        svchost.exe
        spoolsv.exe
        MsMpEng.exe
        SearchIndexer.exe
        SearchProtocolHost.exe
        winlogon.exe
        dwm.exe
        sihost.exe
        taskhostw.exe
        explorer.exe
        dllhost.exe
        TapTip.exe
        TabTip32.exe
        ShellExperienceHost.exe
        SearchUI.exe
        RuntimeBroker.exe
        dasHost.exe
        WmiPrvSE.exe
        NisSrv.exe
        audiodg.exe
        TrustedInstaller.exe
        TiWorker.exe
        WUDFHost.exe
        SearchFilterHost.exe
        OneDrive.exe
        OneDriveSetup.exe
        rundll32.exe
        CompatTelRunner.exe
        DismHost.exe



        //--------------------------------------------------*/
    }
}
