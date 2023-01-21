using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;

namespace CalendarEX
{
    public partial class WpisWydarzenia : UserControl
    {
        public WpisWydarzenia()
        {
            InitializeComponent();
        }

        public void UstawTekst(string tekst)
        {
            WpisWydarzenia_tekst.Text = tekst;
        }

        public void WylaczAkcjeKlikniecia()
        {
            WpisWydarzenia_tekst.Click -= WpisWydarzenia_tekst_Click;
        }

        private void WpisWydarzenia_Click(object sender, EventArgs e)
        {
            UsuwanieWydarzenia();
        }

        private void UsuwanieWydarzenia()
        {

            string zapytanie = PobieranieDaty();

            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            //tworzenie nowego zapytania
            SQLiteCommand wpisanieWydarzenia = sqlitePolaczenie.CreateCommand();
            wpisanieWydarzenia.CommandText = zapytanie;

            //wykonanie zapytania
            try
            {
                wpisanieWydarzenia.ExecuteNonQuery();
            }
            catch { }

            sqlitePolaczenie.Close();

            this.Controls.Clear();

        }

        private string PobieranieDaty()
        {
            string[] wartosci = { "0", "0", "0", "nazwa" }; //dzien-miesiac-rok-nazwa
            wartosci[3] = WpisWydarzenia_tekst.Text;
            //regex
            string wzor = @"\d{1,}";
            Regex regex = new Regex(wzor);
            string dane = this.Name;
            MatchCollection kolekcja = regex.Matches(dane);
            for (int i = 0; i < kolekcja.Count; i++)
            {
                wartosci[i] = kolekcja[i].Value;
            }

            string wynik = "DELETE FROM main.Wydarzenia WHERE dzien = " + wartosci[0] + " AND miesiac = " + wartosci[1] + " AND rok = " + wartosci[2] + " AND nazwa = '" + wartosci[3] + "';";

            return wynik;
        }

        private void WpisWydarzenia_tekst_Click(object sender, EventArgs e)
        {
            UsuwanieWydarzenia();
            GlowneOkno.uchwytGlowneOkno.AktualizujWydarzenia();
            OknoMiesiac.uchwytOknoMiesiac.AktualizujWydarzenia();
        }
    }
}
