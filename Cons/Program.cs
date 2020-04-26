using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************");
            Console.WriteLine("*   _   ______      *");
            Console.WriteLine("*  | | |  __  |     *");
            Console.WriteLine("*  | | | |  | |     *");
            Console.WriteLine("*  | | | |__| |     *");
            Console.WriteLine("*  | | |  ____|     *");
            Console.WriteLine("*  | | | |          *");
            Console.WriteLine("*  |_| |_| HELPER   *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*********************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            refrenSolo();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*-КОМАНДЫ-----------------*");
            Console.WriteLine("");
            Console.WriteLine("  arg - показать аргументы");
            Console.WriteLine("  inf - запустить Readme");
            Console.WriteLine("  help - справка");
            Console.WriteLine("");
            Console.WriteLine("*-------------------------*");
            Console.WriteLine("");


            int m = 0;
            while (m < 1000)
            {
                string line = Console.ReadLine();
                switch (line)
                    {
                    case "arg":
                        for (int i = 0; i < args.Length; i++)
                        Console.WriteLine("Arg: {0}", args[i]);
                        break;
                    case "inf":
                        ProcessStartInfo procInfo = new ProcessStartInfo();
                        procInfo.FileName = @"C:\Windows\System32\notepad.exe";
                        procInfo.Arguments = @"C:\Users\PC501\Source\Repos\IPhelper\FormsApp\bin\Debug\readme.txt";
                        Process.Start(procInfo);
                        break;
                    case "help":
                        Console.WriteLine("Руководство по работе с программой");
                        break;
                    default:
                        Console.WriteLine("Команда не найдена");
                        break;
                }
                m++;
            }



            Console.ReadLine();
            
        }
        static void refrenSolo()
        {
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
        }


    }
}
