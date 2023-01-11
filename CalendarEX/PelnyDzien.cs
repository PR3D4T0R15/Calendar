using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarEX
{
    public partial class PelnyDzien : UserControl
    {
        public PelnyDzien()
        {
            InitializeComponent();
        }

        public void UstawNumerDnia(int numer)
        {
            NumerDnia.Text = numer.ToString();
        }

        private void NumerDnia_Click(object sender, EventArgs e)
        {
            int numerDnia = Convert.ToInt16(NumerDnia.Text);
            
            OknoNoweWydarzenie oknoWydarzenie = new OknoNoweWydarzenie();

            oknoWydarzenie.UstawDomyslnaDate(numerDnia, GlowneOkno.miesiac, GlowneOkno.rok);

            oknoWydarzenie.Show();
        }

        private void WczytajWydarzeniaDnia(int wybranyDzien)
        {
            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();
            pobranieDat.CommandText = "SELECT nazwa FROM main.Wydarzenia WHERE dzien = $dzien AND miesiac = $miesiac AND rok = $rok ORDER BY id ASC;";
            pobranieDat.Parameters.AddWithValue("$miesiac", GlowneOkno.miesiac);
            pobranieDat.Parameters.AddWithValue("$dzien", wybranyDzien);
            pobranieDat.Parameters.AddWithValue("$rok", GlowneOkno.rok);

            SQLiteDataReader wynik = pobranieDat.ExecuteReader();
            while (wynik.Read())
            {
                string nazwa = wynik.GetString(0);

                DodajWydarzenieDoListy(nazwa, wybranyDzien);
            }

            sqlitePolaczenie.Close();
        }

        private void DodajWydarzenieDoListy(string nazwa, int dzien)
        {
            WpisWydarzenia wydarzenie = new WpisWydarzenia();

            wydarzenie.UstawTekst(nazwa);
            wydarzenie.Name = "wydarzenie_" + nazwa;
            wydarzenie.Width = ZadaniaDnia.Width - 8;

            ZadaniaDnia.Controls.Add(wydarzenie);
        }

        private void NumerDnia_TextChanged(object sender, EventArgs e)
        {
            int numerDnia = Convert.ToInt16(NumerDnia.Text);
            WczytajWydarzeniaDnia(numerDnia);
        }
    }
}
