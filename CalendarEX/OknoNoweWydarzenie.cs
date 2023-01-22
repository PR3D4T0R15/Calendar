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
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace CalendarEX
{
    public partial class OknoNoweWydarzenie : Form //Klasa OknoNoweWydarzenie dziedziczaca atrybuty i metody po klasie Form
    {
        public OknoNoweWydarzenie() //konstruktor klasy
        {
            InitializeComponent(); //zrobione przez visual

        }

        //FUNKCJA ZAPISUJACA DODANIE WPISU DO TERMINARZA
        private void Zapisz_Click(object sender, EventArgs e) //zaladowanie okna do zapisu
        {
            DodajWpisyTerminarza(); //funkcja obslugujaca dodanie wpisu do terminarza
            this.Hide(); //ukrycie okna po zapisaniu
            GlowneOkno.uchwytGlowneOkno.AktualizujWydarzenia(); //aktualizacja wydarzen w oknie glownym
            OknoMiesiac.uchwytOknoMiesiac.AktualizujWydarzenia(); //aktualizacja wydarzen w konkretnym miesiacu w ktorym dane zostaly wpisane
        }

        //FUNKCJA USTAWIAJACA WYBRANA DATE JAKO DOMYSLNA, MOZLIWA DO ZMIANY DO ZAPISANIA WYDARZENIA
        public void UstawDomyslnaDate(int dzien, int miesiac, int rok) //zawiera dzien, miesiac, rok
        {
            Data_dzien.Text = dzien.ToString(); //wpisanie do pola odpowiedni dzien
            Data_rok.Text = rok.ToString(); //wpisanie do pola odpowiedniego roku
            Data_miesiac.SelectedIndex = miesiac - 1; //wpisanie do pola odpowiedniego miesiaca (bo combobox liczy od 0)
        }

        //FUNKCJA OBSLUGUJACA DODANIE DO BAZY DANYCH WPISU Z TERMINARA
        private void DodajWpisyTerminarza()
        {
            //pobrane dane do zapytania (jaka nazwa, dzien, miesiac, rok, czy wazne - wybranie przez uzytkownika opcji z comboboxa)
            string nazwa = NazwaWydarzenia.Text;
            string dzien = Data_dzien.Text;
            string miesiac = Convert.ToString(Data_miesiac.SelectedIndex + 1);
            string rok = Data_rok.Text;
            string czyWazne = "0"; //domyslnie jest ustawione 0
            if (CzyWazneWydarzenie.Checked == true) //sprawdzenie czy uzytkownik zaznaczyl ze wydarzenie jest WAZNE (checkbox)
            {
                czyWazne = "1";
            }
            
            //POLACZENIE Z BAZA DANYCH
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //PROBA POLACZENIA Z BAZA DANYCH
            try
            {
                sqlitePolaczenie.Open(); //otwarcie bazy danych
            }
            catch { } //przechwycenie ewentualnych bledow i wyswietlenie errorow

            
            SQLiteCommand wpisanieWydarzenia = sqlitePolaczenie.CreateCommand(); //tworzenie zmiennej ktora bedzie przechowywac zapytanie do bazy danych
            //zapisanie zapytania do bazy danych - zapytanie wprowadzajace wpisane nowe wydarzenie
            wpisanieWydarzenia.CommandText = "INSERT INTO main.Wydarzenia (nazwa, dzien, miesiac, rok, czyWazne) VALUES ($nazwa, $dzien, $miesiac, $rok, $czyWazne);";
            //zamiana $nazwa na nazwe ktora uzytkownik wpisze
            wpisanieWydarzenia.Parameters.AddWithValue("$nazwa", nazwa);
            wpisanieWydarzenia.Parameters.AddWithValue("$dzien", dzien);
            wpisanieWydarzenia.Parameters.AddWithValue("$miesiac", miesiac);
            wpisanieWydarzenia.Parameters.AddWithValue("$rok", rok);
            wpisanieWydarzenia.Parameters.AddWithValue("$czyWazne", czyWazne);
            
            //WYKONANIE ZAPYTANIA
            try
            {
                wpisanieWydarzenia.ExecuteNonQuery(); //wpisanie wydarzenia do bazy
            }
            catch { }

            sqlitePolaczenie.Close(); //zamkniecie bazy danych

        }
    }
}
