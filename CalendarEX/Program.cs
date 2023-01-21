//dodane biblioteki
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//TWORZONE PRZEZ VISUAL STUDIO W TRAKCIE TWORZENIA PROJEKTU
namespace CalendarEX //przestrzen nazw
{
    internal static class Program //klasa Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() //funkcja statyczna Main, tworzenie okna - aplikacja graficzna
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlowneOkno());
        }
    }
}
