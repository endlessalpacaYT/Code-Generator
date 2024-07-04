using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Generator.Python
{
    internal class Keypresses
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

        // Common Virtual Key Codes
        public const byte VK_BACK = 0x08; // BACKSPACE key
        public const byte VK_TAB = 0x09; // TAB key
        public const byte VK_RETURN = 0x0D; // ENTER key
        public const byte VK_SHIFT = 0xA0; // SHIFT key
        public const byte VK_CONTROL = 0x11; // CTRL key
        public const byte VK_MENU = 0x12; // ALT key
        public const byte VK_PAUSE = 0x13; // PAUSE key
        public const byte VK_CAPITAL = 0x14; // CAPS LOCK key
        public const byte VK_ESCAPE = 0x1B; // ESC key
        public const byte VK_SPACE = 0x20; // SPACEBAR
        public const byte VK_LEFT = 0x25; // LEFT ARROW key
        public const byte VK_UP = 0x26; // UP ARROW key
        public const byte VK_RIGHT = 0x27; // RIGHT ARROW key
        public const byte VK_DOWN = 0x28; // DOWN ARROW key
        public const byte VK_DELETE = 0x2E; // DELETE key
        // Numeric keys 0-9
        public const byte VK_0 = 0x30;
        public const byte VK_1 = 0x31;
        public const byte VK_2 = 0x32;
        public const byte VK_3 = 0x33;
        public const byte VK_4 = 0x34;
        public const byte VK_5 = 0x35;
        public const byte VK_6 = 0x36;
        public const byte VK_7 = 0x37;
        public const byte VK_8 = 0x38;
        public const byte VK_9 = 0x39;
        // Alphabet keys A-Z
        public const byte VK_A = 0x41;
        public const byte VK_B = 0x42;
        public const byte VK_C = 0x43;
        public const byte VK_D = 0x44;
        public const byte VK_E = 0x45;
        public const byte VK_F = 0x46;
        public const byte VK_G = 0x47;
        public const byte VK_H = 0x48;
        public const byte VK_I = 0x49;
        public const byte VK_J = 0x4A;
        public const byte VK_K = 0x4B;
        public const byte VK_L = 0x4C;
        public const byte VK_M = 0x4D;
        public const byte VK_N = 0x4E;
        public const byte VK_O = 0x4F;
        public const byte VK_P = 0x50;
        public const byte VK_Q = 0x51;
        public const byte VK_R = 0x52;
        public const byte VK_S = 0x53;
        public const byte VK_T = 0x54;
        public const byte VK_U = 0x55;
        public const byte VK_V = 0x56;
        public const byte VK_W = 0x57;
        public const byte VK_X = 0x58;
        public const byte VK_Y = 0x59;
        public const byte VK_Z = 0x5A;

        // Additional Virtual Key Codes
        public const byte VK_LWIN = 0x5B; // Left Windows key

        public static void PrintHelloWorld()
        {
            keybd_event(VK_P, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_P, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(200);
            keybd_event(VK_R, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_R, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_I, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_I, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_N, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_N, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_T, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_T, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            OpenParenthesis();
            Thread.Sleep(100);
            DoubleQuote();
            Thread.Sleep(100);
            HelloWorld();
            Thread.Sleep(100);
            DoubleQuote();
            Thread.Sleep(100);
            CloseParenthesis();
        }

        public static void HelloWorld()
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_H, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_H, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            ReleaseShiftKeys(); // Release both shift keys
            Thread.Sleep(100);
            keybd_event(VK_E, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_E, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_O, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_O, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_SPACE, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_SPACE, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_W, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_W, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_O, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_O, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_R, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_R, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_L, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_D, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_D, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
        }

        public static void OpenParenthesis()
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_9, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_9, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            ReleaseShiftKeys();
        }

        public static void CloseParenthesis()
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_0, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_0, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            ReleaseShiftKeys();
        }

        public static void DoubleQuote()
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100);
            keybd_event(VK_2, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0); // Assuming double quote is shift + 2
            Thread.Sleep(100);
            keybd_event(VK_2, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
            Thread.Sleep(100);
            ReleaseShiftKeys();
        }

        public static void PressEnter()
        {
            keybd_event(VK_RETURN, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            Thread.Sleep(100); 
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
        }

        private static void ReleaseShiftKeys()
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Release left shift key
            keybd_event(0xA1, 0, KEYEVENTF_KEYUP, (UIntPtr)0); // Release right shift key
        }
    }
}
