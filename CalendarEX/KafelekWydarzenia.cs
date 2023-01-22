//BIBLIOTEKI
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
    public partial class KafelekWydarzenia : UserControl //Klasa PelnyDzien dziedziczaca atrybuty i metody po klasie UserControl
    {
        public KafelekWydarzenia() //konstruktor klasy
        {
            InitializeComponent();//zrobione przez visual
        }

        public void UstawTekst(string tekst) //ustawienie nazwy kafelka
        {
            WpisWydarzenia_tekst.Text = tekst;
        }

        public void WylaczAkcjeKlikniecia() //wylaczenie mozliwosci obslugi klikniecia
        {
            WpisWydarzenia_tekst.Click -= WpisWydarzenia_tekst_Click;
        }

        //USUWANIE WYDARZENIA PO KLIKNIECIU NA NIE
        private void WpisWydarzenia_Click(object sender, EventArgs e)
        {
            UsuwanieWydarzenia();
        }

        //FUNKCJA KTORA USUWA WYDARZENIE PO KLIKNIECIU NA NIE
        private void UsuwanieWydarzenia()
        {

            string zapytanie = PobieranieDaty(); //znalezienie daty dla ktorej ma zostac usuniete wybrane wydarzenie

            //POLACZENIE Z BAZA DANYCH
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //PROBA POLACZENIA DO BAZY DANYCH
            try
            {
                sqlitePolaczenie.Open(); //otwarcie polaczenia
            }
            catch { } //obsluga ewentualnego bledu polaczenia z baza

            //tworzenie nowego zapytania
            SQLiteCommand wpisanieWydarzenia = sqlitePolaczenie.CreateCommand();
            //przypisanie zapytania do zmiennej
            wpisanieWydarzenia.CommandText = zapytanie;

            //wykonanie zapytania
            try
            {
                wpisanieWydarzenia.ExecuteNonQuery();
            }
            catch { }

            sqlitePolaczenie.Close(); //zamkniecie polaczenia z baza

            this.Controls.Clear(); //usuniecie tego wydarzenia

        }

        //FUNKCJA OBSULGUJACA POBRANIE DATY Z KONTROLKI
        private string PobieranieDaty()
        {
            //tablica typu string, ktora przechowuje dzien, miesiac, rok i nazwe
            string[] wartosci = { "0", "0", "0", "nazwa" }; //dzien-miesiac-rok-nazwa
            //pobranie nazwy wydarzenia i wpisanie go do tablicy
            wartosci[3] = WpisWydarzenia_tekst.Text; //wrzucona do 4 komorki "nazwa"
            //wykonanie regexpa i pobranie dnia miesiaca i roku
            string wzor = @"\d{1,}";
            Regex regex = new Regex(wzor);
            string dane = this.Name;
            MatchCollection kolekcja = regex.Matches(dane);
            for (int i = 0; i < kolekcja.Count; i++)
            {
                wartosci[i] = kolekcja[i].Value;
            }

            //przygotowanie zapytania
            string wynik = "DELETE FROM main.Wydarzenia WHERE dzien = " + wartosci[0] + " AND miesiac = " + wartosci[1] + " AND rok = " + wartosci[2] + " AND nazwa = '" + wartosci[3] + "';";

            //zwrocenie wyniku zapytania
            return wynik;
        }

        //FUNKCJA OBSLUGUJACA KLIKNIECIE NA WYDARZENIE
        private void WpisWydarzenia_tekst_Click(object sender, EventArgs e)
        {
            UsuwanieWydarzenia(); //usuniecie wydarzenia z bazy danych i z pola kafelka
            GlowneOkno.uchwytGlowneOkno.AktualizujWydarzenia(); //odwswiezenie okna glownego
            OknoMiesiac.uchwytOknoMiesiac.AktualizujWydarzenia(); //odswiezenie okna miesiaca
        }
    }
}
