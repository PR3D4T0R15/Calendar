//BIBLIOTEKI
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
    public partial class PelnyDzien : UserControl //Klasa PelnyDzien dziedziczaca atrybuty i metody po klasie UserControl
    {
        public PelnyDzien() //konstruktor klasy
        {
            InitializeComponent(); //zrobione przez visual
        }

        //FUNKCJA USTAWIAJACA NUMER POSZCZEGOLNEGO DNIA W MIESIACU
        public void UstawNumerDnia(int numer) 
        {
            NumerDnia.Text = numer.ToString(); //wyswietlenie numeru dnia w kontrolce dnia jako string
        }

        //FUNKCJA OBSLUGUJACA KLIKNIECIE NA KONKRETNY DZIEN
        private void NumerDnia_Click(object sender, EventArgs e)
        {
            int numerDnia = Convert.ToInt16(NumerDnia.Text); //pobranie numeru dnia z pola przechowujacego numer dnia
            
            OknoNoweWydarzenie oknoWydarzenie = new OknoNoweWydarzenie(); //wyswietlenie okna gdzie mozna wpisac nowe wydarzenie

            oknoWydarzenie.UstawDomyslnaDate(numerDnia, GlowneOkno.miesiac, GlowneOkno.rok); //ustawienie domyslnej daty w oknie wpisania daty

            oknoWydarzenie.Show(); //wyswietlenie okna
        }

        //FUNKCJA WCZYTUJACA WYDARZENIA DLA KONKRETNEGO DNIA
        private void WczytajWydarzeniaDnia(int wybranyDzien)
        {
            //POLACZENIE Z BAZA DANYCH
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //PROBA POLACZENIA Z BAZA DANYCH
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand(); //tworzenie zmiennej ktora bedzie przechowywac zapytanie do bazy danych
            //wpisanie zapytania
            pobranieDat.CommandText = "SELECT nazwa FROM main.Wydarzenia WHERE dzien = $dzien AND miesiac = $miesiac AND rok = $rok ORDER BY id ASC;";
            //zamiana $miesiac na nazwe ktora uzytkownik wpisze i wybierze
            pobranieDat.Parameters.AddWithValue("$miesiac", GlowneOkno.miesiac);
            pobranieDat.Parameters.AddWithValue("$dzien", wybranyDzien);
            pobranieDat.Parameters.AddWithValue("$rok", GlowneOkno.rok);

            SQLiteDataReader wynik = pobranieDat.ExecuteReader(); //wykonanie zapytania
            while (wynik.Read()) //przetworzenie zwroconego zapytania
            {
                string nazwa = wynik.GetString(0); //pobranie z wyniku zapytania nazwy wydarzenia

                DodajWydarzenieDoListy(nazwa, wybranyDzien); //funkcja obslugujaca wrzucenie wydarzenia do listy
            }

            sqlitePolaczenie.Close(); //zamkniecie polaczenia
        }

        //FUNKCJA OBSLUGUJACA DODANIE WYDARZENIA DO LISTY
        private void DodajWydarzenieDoListy(string nazwa, int dzien)
        {
            //utworzenie napisu z wydarzeniem/utworzenie nowego wpisu (kafelka) w konkretny miesiac
            KafelekWydarzenia wydarzenie = new KafelekWydarzenia();

            wydarzenie.UstawTekst(nazwa);//ustawienie tekstu tego wydarzenia
            //utworzenie nazwy tego wydarzenia
            wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa; 
            //zmiana szerokosci kafelka
            wydarzenie.Width = ZadaniaDnia.Width - 8;

            //dodanie wydarzenia zeby pojawilo sie w kafelku danego dnia w miesiacu
            ZadaniaDnia.Controls.Add(wydarzenie);
        }

        //FUNKCJA WPISUJACA WYDARZENIA DO DNIA
        private void NumerDnia_TextChanged(object sender, EventArgs e)
        {
            int numerDnia = Convert.ToInt16(NumerDnia.Text); //pobranie numeru dnia kafelka
            WczytajWydarzeniaDnia(numerDnia); //wpisanie wydarzen
        }


    }
}
