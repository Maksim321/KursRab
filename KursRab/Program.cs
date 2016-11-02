using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursRab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class getAutomatInfo
    {
        public static CListProduct Automat = new CListProduct();
        public static CListProduct ProductInBox = new CListProduct();
        public static CAutomatCash Money = new CAutomatCash(10, 0);
    }
    static class getUserInfo
    {
        public static CListProduct User = new CListProduct();
        public static double Money_User = 50;
    }
}
