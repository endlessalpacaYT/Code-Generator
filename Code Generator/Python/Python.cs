using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace Code_Generator.Python
{
    internal class Python
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

        public const byte VK_RETURN = 0x0D; // ENTER key
        public const byte VK_MENU = 0xA4; // ALT key
        public const byte VK_TAB = 0x09; // TAB key

        public static void StartGenerator()
        {
            Console.Title = "Code Generator [Python]";
            Console.WriteLine("Setting Up Generator (Give Us A Moment...)");
            Thread.Sleep(2000);
            Console.WriteLine("Alt Tab To Ide [Should Be Your Last Window]");
            AltTab();
            GenerateCode();
        }

        public static void AltTab()
        {
            keybd_event(VK_MENU, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_TAB, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(500);
        }

        public static void GenerateCode()
        {
            string[] codeSnippets = {
            "PrintHelloWorld",
            "PrintProgramIsWorking",
            };
            Random random = new Random();

            while (true)
            {
                int index = random.Next(codeSnippets.Length); 
                string randomSnippet = codeSnippets[index];
                Console.WriteLine("Generating Code Snippet: " + randomSnippet);
                Thread.Sleep(500);
                switch (randomSnippet)
                {
                    case "PrintHelloWorld":
                        Keypresses.PrintHelloWorld();
                        PressEnter();
                        break;
                    case "PrintProgramIsWorking":
                        Keypresses.PrintProgramIsWorking();
                        PressEnter();
                        break;
                }
            }
        }

        public static void PressEnter()
        {
            keybd_event(VK_RETURN, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100); 
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
        }
    }
}
