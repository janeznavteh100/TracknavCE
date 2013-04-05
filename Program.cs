using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using LXComm;

namespace LXF
{s
sfsdfasdfdsfsd
sdfsdf

tole je pa branck jkkkkkkkkkk

strela tag
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            try
            {
                Application.Run(new Form_main());
            }
            catch (Exception napaka)
            {

                int x = 5;
            }
           
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception napaka = (Exception)e.ExceptionObject;
            if (napaka != null)
            {
                StreamWriter sw = new StreamWriter(@"\"+Root.Instance.Path+@"\log.txt", true);
              
                sw.WriteLine("///////////////////////////////////////////////////////////////");
                sw.Write(napaka.Message);
                sw.WriteLine("---------------->");
                sw.Write(napaka.ToString());
                sw.Close();
                LXComm.Remote.WriteLastShutDownTime(LXComm.eReconnectType.UNHANDLED_EXCEPTION);
                System.Threading.Thread.Sleep(4000);
                System.Diagnostics.Process.Start(@"\Windows\D.exe", "");

            }



        }
    }
}