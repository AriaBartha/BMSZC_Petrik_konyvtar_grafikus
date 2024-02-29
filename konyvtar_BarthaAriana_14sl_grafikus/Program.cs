using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyvtar_BarthaAriana_14sl_grafikus
{
    internal static class Program
    {
        public static List<Book> books = new List<Book>();
        public static Adatbazis adatok = null;
        public static Form1 form1 = null;
              
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            adatok = new Adatbazis();
            books = adatok.getAllBooks();
            form1 = new Form1();
            Application.Run(form1);
        }
    }
}
