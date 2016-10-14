using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Previewer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[DllImport("user32.dll")]
        //static extern bool SetForegroundWindow(IntPtr hWnd);
        //static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            //if (mutex.WaitOne(TimeSpan.Zero, true))
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            //    mutex.ReleaseMutex();
            //}
        }

        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new FormMain());

        //    //bool createdNew = true;
        //    //using (Mutex mutex = new Mutex(true, "Previewer", out createdNew))
        //    //{
        //    //    if (createdNew)
        //    //    {
        //    //        Application.EnableVisualStyles();
        //    //        Application.SetCompatibleTextRenderingDefault(false);
        //    //        Application.Run(new FormMain());
        //    //    }
        //    //    else
        //    //    {
        //    //        Process current = Process.GetCurrentProcess();
        //    //        foreach(Process process in Process.GetProcessesByName(current.ProcessName))
        //    //        {
        //    //            if(process.Id != current.Id)
        //    //            {
        //    //                SetForegroundWindow(process.MainWindowHandle);
        //    //                break;
        //    //            }
        //    //        }
        //    //    }
        //    //}

        //}
    }
}
