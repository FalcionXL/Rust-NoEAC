using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rust_NoEAC
{
    class Program
    {
        public static bool file1;
        public static IntPtr os;
        public static SafeHandle safe;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Rust-NoEAC by CheeZeDark");
            Thread.Sleep(3000);
            Console.WriteLine("Replacing Orig Rust.exe to Cracked Rust.exe...");
            File.Replace("Rust.exe", "CrackedRust.exe", "Rust.exe");
            Thread.Sleep(2000);
            Console.Write("Launching RustClient.exe without EAC...");
            if (Thread.Yield())
            {
                Thread thr = new Thread(LaunchRust);
                thr.Start();
                if (thr.Join(4000) == true)
                {
                    thr.Abort();
                }
                else
                {
                    while(File.Exists("RustClient.exe") || file1)
                    {
                        Debug.WriteLine("RustClient Founded");
                        Thread.Sleep(2100);
                        break;
                    }
                }
            }
        }
        static void LaunchRust()
        {
            if (ThreadPool.BindHandle(safe) != true)
            {
                Process.Start("RustClient.exe");
            }
            else
            {
                throw new ExternalException("External BindHandle not Founded");
            }
            Console.Write("EAC is Successfully Bypassed");
            Directory.CreateDirectory("C:\\EAC");
            File.WriteAllText(@"C:\EAC\README.txt", "Thank u for using this Console Program... Made by CheeZeDark" + Environment.NewLine + "P.S: Some of Servers Doesn't Launched in ur PC because EAC is not Launched... If u want to Launch Rust with EAC, Pls Delete Fake Rust.exe and Rename CrackedRust.exe to Rust.exe");
            Process.Start("notepad", @"C:\EAC\README.txt");
            Environment.Exit(213);
        }
    }
}
