using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping
{
    static class Program
    {
        private static DateTime djf;
        private static string ftg;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Console.Write("Bienvenue sur le programe Pour la Compagnie" + Environment.NewLine + "nous sommes fier de vous presenter" + Environment.NewLine + " linterface avec intelligence artificiel" + Environment.NewLine + "elle peut apprendre evoluer et changer");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("Creer par : YAN BERGERON");
            Console.WriteLine("--------");

            string fth = File.ReadAllText("directory.tx");
            ftg = fth;
            System.IO.Directory.SetCurrentDirectory(fth);
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(ftg);
                Environment.CurrentDirectory = ftg;

                Properties.Settings.Default.Save();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
            // Print to console the results.
            Console.WriteLine("Root directory: {0}", Directory.GetDirectoryRoot(ftg));
            Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());



            try
            {
                string myHost = System.Net.Dns.GetHostName();
                string myIP = null;

                for (int i = 0; i <= System.Net.Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
                {
                    if (System.Net.Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                    {
                        myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[i].ToString();
                    }
                }
                Console.WriteLine("--------");
                Console.WriteLine("local ip : " + myIP);
                var xg = Environment.SystemPageSize;
                Console.WriteLine("--------");
                Console.WriteLine("memory paging loaded : " + xg);
                string[] sss = Environment.GetLogicalDrives();
                Console.WriteLine("logical drives : ");
                foreach (string bf in sss)
                {
                    Console.Write(bf);
                }
                var stt = Environment.MachineName;
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.WriteLine("machinne name : " + stt);
                int tre = Environment.ProcessorCount;
                Console.WriteLine("--------");
                Console.WriteLine("processor count : " + tre);
              
                var sut = Environment.UserDomainName;
                Console.WriteLine("--------");
                Console.WriteLine("network name : " + myHost);
                var scx = Environment.UserName;
                Console.WriteLine("--------");
                Console.WriteLine("user name : " + scx);
                var syr = Environment.Version;
                Console.WriteLine("--------");
                var syre = Environment.OSVersion;
                Console.WriteLine("os ver : " + syre);
                Console.WriteLine("--------");
                Console.WriteLine("ver : " + syr);
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                Console.WriteLine("--------");
                Console.WriteLine("ip adress : " + externalip);

                Console.WriteLine("--------");

                var sfg = Environment.UserInteractive;
                Console.WriteLine("interactif : " + sfg);
            }
            catch { Console.WriteLine("error environement"); }
             djf = DateTime.Now;
            Thread sjd = new Thread(mnfcfr);
            sjd.Start();
            do
            {
             
                Console.WriteLine(djf.ToString("HH.mm.ss")+ " : ping program checking connection.....");
                var frg = int.Parse("3");
                for (int i = 0; i < frg; i++)
                {
                    using (Ping p = new Ping())
                    {
                        Console.WriteLine(p.Send("www.google.com").RoundtripTime.ToString() + "ms\n");
                    }
                }
                Console.ReadLine();
            } while (true);
        }

        private static void mnfcfr()
        {
            do
            {
                Console.WriteLine(djf.ToString("HH.mm.ss") + " : ping program checking connection.....");
                var frg = int.Parse("3");
                for (int i = 0; i < frg; i++)
                {
                    using (Ping p = new Ping())
                    {
                        Console.WriteLine(p.Send("www.google.com").RoundtripTime.ToString() + "ms\n");
                    }
                }
                Thread.Sleep(100000);
            } while (true);
        }
    }
}
