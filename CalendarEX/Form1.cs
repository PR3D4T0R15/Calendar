//BIBLIOTEKI
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarEX
{
    public partial class GlowneOkno : Form //Klasa GlowneOKno dziedziczaca atrybuty i metody po klasie Form
    {
        public static int rok = 0;      //deklaracja zmiennej statycznej publicznej rok (mozemy uzyskac do nich dostep poza klasa) 
        public static int miesiac = 0;  //deklaracja zmiennej statycznej publicznej miesiac
        public static int dzien = 0;    //deklaracja zmiennej statycznej publicznej dzien
        public static DateTime dataTeraz;   //deklaracja zmiennej C# przechowująca czas i date
        public static GlowneOkno uchwytGlowneOkno;  //deklaracja zmiennej wskazujaca na klase GlowneOkno

        public GlowneOkno()     //konstruktor klasy 
        {
            InitializeComponent();     //zaladowanie okna
            uchwytGlowneOkno = this;    //przypisujemy do zmienne uchwytGLowneOkno klase GlowneOKno
        }

        //FUNKCJE PRYWATNE TYLKO DLA TEGO JEDNEGO OKNA
        private void Form1_Load(object sender, EventArgs e) //funkcja ktora uruchamia sie kiedy zostanie zaladowane okno glowne
        {
            //DLA UŁATWIENIA DALSZEJ PRACY:
            dataTeraz = DateTime.Now;   //do zmiennej dataTeraz przypisujemy date DateTime
            rok = dataTeraz.Year;   //do zmiennej rok przypisujemy jaki jest teraz rok
            dzien = dataTeraz.Day;  //do zmiennej dzien przypisujemy dzisiejsza date
            //DZIĘKI TEMU NIE MUSZĘ ZA KAŻDYM RAZEM WPISYWAĆ ZMIENNEJ PRZECHOWUJĄCEJ DATĘ, MOGĘ OPEROWAĆ ZMIENNYMI dataTeraz, rok, dzien

            UstawRok(); //funkcja wyswietlajaca biezacy rok po wlaczeniu programu

            //WYWOLANIE FUNKCJI
            //W PRZYPADKU ODSWIEZANIA OKNA MOZNA UZYC FUNKCJI KTORA CZYSCI STARE DANE
            WyczyscListyWydarzenMiesiecy(); //funkcja czyszczaca wydarzenia z miesiaca w oknie
            WczytajWydarzeniaOknoGlowne();  //funkcja ladujaca z bazy danych wydarzenia z miesiaca

            WyczyscListyWydarzenNadchodzace();  //funkcja czyszczaca nadchodzacewydarzenia w oknie
            WczytajWydarzeniaNadchodzace(); //funkcja ladujaca nadchodzacewydarzenia z bazy danych w oknie programu

            WyczyscListyWydarzenWazne(); //funkcja czyszaca wydarzeniawazne w oknie
            WczytajWydarzeniaWazne();   //funkcja ladujaca wydarzeniawazne z bazy danych w oknie programu

            WczytajNotatki(); //funkcja ladujaca notatki uzytkownika z pliku tekstowego

        }

        //ZMIANA ROKU O ROK DO PRZODU
        private void PanelRoku_rokDoPrzodu_Click(object sender, EventArgs e)
        {
            rok++;  //zwiekszenie biezacego roku o 1
            //PONOWNE LADOWANIE WSZYSTKICH FUNKCJI DLA KALENDARZA
            UstawRok();

            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        //ZMIANA ROKU O ROK DO TYLU
        private void PanelRoku_rokDoTylu_Click(object sender, EventArgs e)
        {
            rok--; //zmniejszenie biezacego roku o 1
            //PONOWNE LADOWANIE WSZYSTKICH FUNKCJI DLA KALENDARZA   
            UstawRok();

            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        //USTAWIENIE JAKI ROK MA BYC WYSWIETLONY W GLOWNYM OKNIE
        private void UstawRok() //funkcja UstawRok
        {
            PanelRoku_rok.Text = "ROK " + rok.ToString();    //zamiana tekstu ROK na odpowiedni rok pobrany ze zmiennej int i wyswietlenie liczby jako ciag znakow string
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC STYCZEN
        private void Styczen_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 1;    //przypisanie do zmiennej miesiac wartosci 1 - od teraz styczen ma wartosc 1

            OknoMiesiac WidokMiesiac = new OknoMiesiac();   //stworzenie uchwytu do nowego okna - jak klikne w miesiac styczen to odpali mi sie nowe okno zawierajace dane konkretnie dla stycznia
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC LUTY
        private void Luty_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 2; //przypisanie do zmiennej miesiac wartosci 2 - od teraz luty ma wartosc 2

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC MARZEC
        private void Marzec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 3; //przypisanie do zmiennej miesiac wartosci 3 - od teraz marzec ma wartosc 3

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC KWIECIEN
        private void Kwiecien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 4;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC MAJ
        private void Maj_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 5;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC CZERWIEC
        private void Czerwiec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 6;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC LIPIEC
        private void Lipiec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 7;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC SIERPIEŃ
        private void Sierpien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 8;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC WRZESIEŃ
        private void Wrzesien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 9;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC PAŹDZIERNIK
        private void Pazdziernik_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 10;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC LISTOPAD
        private void Listopad_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 11;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //FUNKCJA PRYWATNA KTORA URUCHAMIA NOWE OKNO PO KLIKNIECIU W MIESIAC GRUDZIEŃ
        private void Grudzien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 12;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show(); //metoda show - pozwala na pokazanie zaladowanego okna
        }

        //DEFINICJA FUNKCJI DLA WYDARZEN OKNA GLOWNEGO
        private void WczytajWydarzeniaOknoGlowne()
        {
            //ŁĄCZENIE Z BAZĄ DANYCH (źródło, wersja 3, nie twórz nowego pliku, skompresuj plik jak się da)
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //PRÓBA POŁĄCZENIA Z BAZĄ DANYCH
            try
            {
                sqlitePolaczenie.Open(); //OTWORZ POLACZENIE
            }
            catch { } //informacja o ewentualnym bledzie z polaczeniem

            for(int miesiac = 1;  miesiac <= 12; miesiac++) //petla wyciagajaca dane 12x z bazy bo jest 12 miesiecy
            {
                SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();   //tworzenie zmiennej ktora bedzie przechowywac zapytanie do bazy danych
                //zapisanie zapytania do tej zmiennej aby wyciagnac z bazy nazwy wydarzen dla poszczegolnych miesiecy:
                pobranieDat.CommandText = "SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND rok = $rok ORDER BY dzien ASC;";
                //zamiana miesiaca na numer i, np. dla stycznia i to 1, dla marca i to 3:
                pobranieDat.Parameters.AddWithValue("$miesiac", miesiac);
                //zamiana roku na numer biezacego roku:
                pobranieDat.Parameters.AddWithValue("$rok", rok);

                //wyslanie zapytania do bazy danych:
                SQLiteDataReader wynik = pobranieDat.ExecuteReader();
                //petla pobierajaca dane z bazy (kolumny dzien i nazwa) i przetwarzajaca wyniki
                while(wynik.Read())
                {
                    int dzien = wynik.GetInt16(0);  //z wyniku zapytania pobiera dzien
                    string nazwa = wynik.GetString(1);  //z wyniku zapytania pobiera nazwe wydarzenia

                    DodajWydarzenieDoListy(dzien, miesiac, nazwa); //uruchomienie funkcji zadeklarowanej ponizej zawierajacej dzien,miesiac i nazwe
                }
            }
            sqlitePolaczenie.Close();   //zamkniecie polaczenia z baza
        }

        //FUNKCJA DODAJACA WYDARZENIE Z BAZY DANYCH JAKO "KAFELEK" DO EKRANU GŁOWNEGO
        private void DodajWydarzenieDoListy(int dzien, int miesiac, string nazwa)
        {
            //utworzenie napisu z wydarzeniem/utworzenie nowego wpisu (kafelka) w konkretny miesiac
            WpisWydarzenia wydarzenie = new WpisWydarzenia(); 

            wydarzenie.UstawTekst(dzien.ToString() + ": " + nazwa); //ustawienie tekstu w kafelku: [numer dnia] np. 14: walentynki
            //ustawianie nazwy wydarzenia, pobranie danych z konkretnego dnia, miesiaca, roku i ustawenie nazwy wydarzenia z tymi danymi
            wydarzenie.Name = dzien.ToString() + ":" + miesiac.ToString() + ":" + rok.ToString() + ":" + nazwa;
            wydarzenie.WylaczAkcjeKlikniecia();     //ustawienie ze wydarzenie jest nieklikalne
            wydarzenie.Width = Styczen_lista.Width - 6; //ustawienie szerokosci wydarzenia (-6 pikseli)


            //FUNCKJA UNIWERSALNA DLA KAZDEGO MIESIACA
            //WYBRANIE DLA JAKIEGO MIESIACA NALEZY PRZYPISAC KAFELEK Z WYDARZENIEM
            switch (miesiac)
            {
                case 1:
                    Styczen_lista.Controls.Add(wydarzenie); //pole pod styczniem, dodanie wydarzenia do tego pola
                    break;
                case 2:
                    Luty_lista.Controls.Add(wydarzenie); //pole pod lutym, dodanie wydarzenia do tego pola
                    break;
                case 3:
                    Marzec_lista.Controls.Add(wydarzenie); //pole pod marcem, dodanie wydarzenia do tego pola
                    break;
                case 4:
                    Kwiecien_lista.Controls.Add(wydarzenie); //pole pod kwietniem, dodanie wydarzenia do tego pola
                    break;
                case 5:
                    Maj_lista.Controls.Add(wydarzenie); //pole pod majem, dodanie wydarzenia do tego pola
                    break;
                case 6:
                    Czerwiec_lista.Controls.Add(wydarzenie); //pole pod czerwcem, dodanie wydarzenia do tego pola
                    break;
                case 7:
                    Lipiec_lista.Controls.Add(wydarzenie); //pole pod lipcem, dodanie wydarzenia do tego pola
                    break;
                case 8:
                    Sierpien_lista.Controls.Add(wydarzenie); //pole pod sierpniem, dodanie wydarzenia do tego pola
                    break;
                case 9:
                    Wrzesien_lista.Controls.Add(wydarzenie); //pole pod wrzesniem, dodanie wydarzenia do tego pola
                    break;
                case 10:
                    Pazdziernik_lista.Controls.Add(wydarzenie); //pole pod pazdziernikiem, dodanie wydarzenia do tego pola
                    break;
                case 11:
                    Listopad_lista.Controls.Add(wydarzenie); //pole pod listopadem, dodanie wydarzenia do tego pola
                    break;
                case 12:
                    Grudzien_lista.Controls.Add(wydarzenie); //pole pod grudniem, dodanie wydarzenia do tego pola
                    break;
            }
        }
        
        //FUNKCJA CZYSZCZACA WYDARZENIA PRZY LADOWANIU PROGRAMU
        private void WyczyscListyWydarzenMiesiecy()
        {
            Styczen_lista.Controls.Clear();
            Luty_lista.Controls.Clear();
            Marzec_lista.Controls.Clear();
            Kwiecien_lista.Controls.Clear();
            Maj_lista.Controls.Clear();
            Czerwiec_lista.Controls.Clear();
            Lipiec_lista.Controls.Clear();
            Sierpien_lista.Controls.Clear();
            Wrzesien_lista.Controls.Clear();
            Pazdziernik_lista.Controls.Clear();
            Listopad_lista.Controls.Clear();
            Grudzien_lista.Controls.Clear();

        }

        //FUNKCJA WCZYTUJACA WYDARZENIA NADCHODZACE PODCZAS LADOWANIA PROGRAMU
        private void WczytajWydarzeniaNadchodzace() //TO SAMO CO DO WYDARZEN DLA MIESIACA ALE INNE ZAPYTANIE
        {
            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            //wyslanie zapytania do bazy danych
            SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();
            //WYDARZENIA NADCHODZACE SA USTAWIONE DLA TEGO MIESIACA BIEZACEGO I TEGO ROKU BIEZACEGO
            pobranieDat.CommandText = "SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND dzien > $dzien AND rok=  $rok ORDER BY dzien ASC;";
            //zamiana $miesiac na miesiac aktualny (Now.Month)
            pobranieDat.Parameters.AddWithValue("$miesiac", DateTime.Now.Month);
            //zamiana $dzien na aktualny dzien (Now.Day)
            pobranieDat.Parameters.AddWithValue("$dzien", DateTime.Now.Day);
            //zamiana $rok na aktualny rok (Now.Year)
            pobranieDat.Parameters.AddWithValue("$rok", DateTime.Now.Year);

            //wyslanie zapytania do bazy danych
            SQLiteDataReader wynik = pobranieDat.ExecuteReader();
            //petla pobierajaca dane z bazy i przetwarzajaca wyniki
            while (wynik.Read())
               {
                 int dzien = wynik.GetInt16(0); //z wyniku zapytania pobiera dzien
                 string nazwa = wynik.GetString(1); //z wyniku zapytanie pobiera nazwe wydarzenia

                 DodajWydarzenieDoListy(dzien, 0, nazwa, 0); //uruchomienie funkcji zadeklarowanej ponizej zawierajacej dzien i nazwe
                //dzien, 0-miesiac, nazwa, 0 czy wazne - NIE
                }
            
            sqlitePolaczenie.Close(); //zamkniecie polaczenia z baza
        }

        //FUNKCJA DODAJACA WYDARZENIA DO POLA NADCHODZACE WYDARZENIA LUB NAJWAZNIEJSZE WYDARZENIA
        private void DodajWydarzenieDoListy(int dzien, int miesiac, string nazwa, int czyWazne)
        {
            if (czyWazne == 0) //czyWazne == 0 - NIE WAZNE WIEC DODA WYDARZENIE DO POLA NADCHODZACE WYDARZENIA
            {
                //utworzenie napisu z wydarzeniem/utworzenie nowego wpisu w pole Nadchodzace Wydarzenia
                WpisWydarzenia wydarzenie = new WpisWydarzenia();

                wydarzenie.UstawTekst(dzien.ToString() + ": " + nazwa); //ustawienie tekstu w kafelku: [numer dnia] np. 14: walentynki
                //ustawianie nazwy wydarzenia, pobranie danych z konkretnego dnia, miesiaca, roku i ustawienie nazwy wydarzenia z tymi danymi
                wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa;
                wydarzenie.Width = Nadchodzace_lista.Width - 6; //ustawienie szerokosci pola (-6 pikseli)
                wydarzenie.WylaczAkcjeKlikniecia(); //ustawienie ze wydarzenie jest nieklikalne
                Nadchodzace_lista.Controls.Add(wydarzenie); //dodanie/wyswietlenie wydarzenia do listy
            }
            else if (czyWazne == 1) //czyWazne == 1 - WAZNE WIEC DODA WYDARZENIE DO POLA NAJWAZNIEJSZE WYDARZENIA
            {
                //utworzenie napisu z wydarzeniem/utworzenie nowego wpisu w pole Najwazniejsze Wydarzenia
                WpisWydarzenia wydarzenie = new WpisWydarzenia();

                wydarzenie.UstawTekst(dzien.ToString() + "." + miesiac.ToString() + " : " + nazwa); //ustawienie tekstu w kafelku: [numer dnia] np. 14. [numer miesiaca] np.2: walentynki
                //ustawianie nazwy wydarzenia, pobranie danych z konkretnego dnia, miesiaca, roku i ustawienie nazwy wydarzenia z tymi danymi
                wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa;
                wydarzenie.Width = Najwazniejsze_lista.Width - 6; //ustawienie szerokosci pola (-6 pikseli)
                wydarzenie.WylaczAkcjeKlikniecia(); //ustawienie ze wydarzenie jest nieklikalne
                Najwazniejsze_lista.Controls.Add(wydarzenie); //dodanie/wyswietlenie wydarzenia do listy
            }
            
        }

        //FUNKCJA CZYSZCZACA WYDARZENIA NADCHODZACE PODCZAS LADOWANIA PROGRAMU
        private void WyczyscListyWydarzenNadchodzace()
        {
            Nadchodzace_lista.Controls.Clear();
        }

        //FUNKCJA WCZYTUJACA WYDARZENIA WAZNE PODCZAS LADOWANIA PROGRAMU
        private void WczytajWydarzeniaWazne()
        {
            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            //wyslanie zapytania do bazy danych
            SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();
            //zapisanie zapytania do bazy danych
            pobranieDat.CommandText = "SELECT dzien,miesiac,nazwa FROM main.Wydarzenia WHERE czyWazne = $czyWazne ORDER BY dzien ASC;";
            //zamiana $czyWazne na wartosc 1 - WAZNE
            pobranieDat.Parameters.AddWithValue("$czyWazne", 1);

            //wyslanie zapytania do bazy danych
            SQLiteDataReader wynik = pobranieDat.ExecuteReader();
            //petla pobierajaca dane z bazy i przetwarzajaca wyniki
            while (wynik.Read())
            {
                int dzien = wynik.GetInt16(0); //dodatkowe pole pobierajace dzien
                int miesiac = wynik.GetInt16(1); //dodatkowe pole pobierajace miesiac
                string nazwa = wynik.GetString(2); //dodatkowe pole pobierajace nazwe

                DodajWydarzenieDoListy(dzien, miesiac, nazwa, 1); //uruchomienie funkcji zadeklarowanej ponizej zawierajacej dzien, miesiac, nazwe i wartosc CZY WAZNE
                //dzien, miesiac, nazwa, 1 czy wazne - WAZNE
            }

            sqlitePolaczenie.Close(); //zamkniecie polaczenia z baza
        }

        //FUNKCJA CZYSZCZACA WYDARZENIA WAZNE
        private void WyczyscListyWydarzenWazne()
        {
            Najwazniejsze_lista.Controls.Clear();
        }

        //FUNKCJA WYSWIETLAJACA NA NOWO GLOWNE OKNO PO ZMIANIE ROZMIARU OKNA 
        private void GlowneOkno_Resize(object sender, EventArgs e)
        {
            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();

        }

        //FUNKCJA AKTUALIZUJACA WYDARZENIA
        public void AktualizujWydarzenia()
        {
            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        //FUNKCJA OBSLUGUJACA POLE NOTATKI
        //PO KLIKNIECIU NA POLE Z NOTATKAMI WYSWIETLI SIE NOWE OKNO
        private void Notatki_tekst_Click(object sender, EventArgs e)
        {
            OknoNotatki OknoNotatki = new OknoNotatki();
            OknoNotatki.Show();
        }

        //FUNKCJA WCZYTUJACA NOTATKI Z PLIKU TXT
        public void WczytajNotatki()
        {
            string plik = "notatki.txt"; //przechowanie nazwy pliku notatki.txt

            //SPRAWDZENIE CZY PLIK ISTNIEJE
            try
            {
                StreamReader plikR = new StreamReader(plik); //odczytanie pliku ktorego nazwa jest w stringu plik
                Notatki_pole.Text = plikR.ReadToEnd(); //laduje notatki do pola notatki w ekranie glownym
                plikR.Close(); //zamkniecie pliku
            }
            catch (System.IO.FileNotFoundException) //catch wyswietlajacy komunikat ze pliku nie znaleziono
            {
                
            }
        }

        private void PanelRoku_rok_Click(object sender, EventArgs e)
        {

        }
    }
}
