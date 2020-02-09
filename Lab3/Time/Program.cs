using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace Time
{
    class Program
    {
        [DllImport(@"Lab3.dll", EntryPoint = "CurrDate", CallingConvention = CallingConvention.StdCall)]
        public static extern string CurrDate();
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, String pText,
    String pCaption, int utype);

        [STAThread]
        static void Main(string[] args)
        {
            String pText = "Hello, programmer";
            String pCaption = "See dll in action";
            MessageBox(0, pText, pCaption, 0);
            Console.WriteLine("Time: " + CurrDate());
            Console.ReadLine();
        }

    }
}
