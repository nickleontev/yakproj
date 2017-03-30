using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_number_7_Model
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static Modeling modeling;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            TESTPicture first = new TESTPicture();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(2);
            first.Show();
            
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();



            Application.Run(new Form1());

        }
    }
}
