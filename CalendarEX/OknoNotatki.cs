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
using System.IO;

namespace CalendarEX
{
    public partial class OknoNotatki : Form //Klasa OknoNotatki dziedziczaca atrybuty i metody po klasie Form
    {
        private string plik = "notatki.txt"; //przypisanie do zmiennej plik pliku "notatki.txt"
        public OknoNotatki() //konstruktor klasy
        {
            InitializeComponent(); //zrobione przez visual
        }

        //FUNKCJA WYKONUJACA SIE JAK OKNO JEST ZALADOWANE
        private void OknoNotatki_Load(object sender, EventArgs e) //zaladowanie okna notatki
        {
            OdczytajDane(); //funkcja odczytujaca dane z pliku
        }

        //FUNKCJA ZAPISUJACA WPIS DO POLA NOTATKI - URUCHAMIA SIE PO KLIKNIECIU PRZYCISKU ZAPISZ
        private void Przyciski_zapisz_Click(object sender, EventArgs e) //funkcja wykonuje sie jak przycisk zostanie klikniety
        {
            ZapiszDane(); //zapisanie danych
            this.Hide(); //ukrycie okna
            GlowneOkno.uchwytGlowneOkno.WczytajNotatki(); //odswiezenie pola notatek w oknie glownym i wyswietlenie nowej notatki
        }

        //FUNKCJA WYKONUJACA SIE PO KLIKNIECIU PRZYCISKU ANULUJ
        private void Przyciski_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide(); //ukrycie okna
        }

        //FUNKCJA ZAPISUJACA DANE DO PLIKU WPISANE PRZEZ UZYTKOWNIKA
        private void ZapiszDane()
        {
            string tekst = PanelNotatek.Text; //pobranie danych z pola tekst i wrzucenie do zmiennej tekst

            StreamWriter plikW = new StreamWriter(plik); //otwarcie pliku

            plikW.Write(tekst); //zapisanie do pliku

            plikW.Close(); //zamkniecie pliku
        }

        //FUNKCJA ODCZYTUJACA DANE Z PLIKU
        private void OdczytajDane()
        {
            //proba otwarcia i odczytania danych z pliku
            try
            {
                StreamReader plikR = new StreamReader(plik); //proba otwarcia pliku do odczytu
                PanelNotatek.Text = plikR.ReadToEnd(); //proba odczytania calego pliku
                plikR.Close(); //proba zamkniecia pliku
            }
            //obsluga bledu ze nie znaleziono pliku
            catch (System.IO.FileNotFoundException)
            {
                StreamWriter plikW = new StreamWriter(plik); //proba otwarcia pliku do zapisu
                plikW.WriteLine("Nowy plik z notatkami!"); //wpisanie linii do pliku
                plikW.Close(); //proba zamkniecia pliku

                StreamReader plikR = new StreamReader(plik); //odczytanie pliku
                PanelNotatek.Text = plikR.ReadToEnd(); //czytanie linijek pliku
                plikR.Close(); //zamkniecie pliku
            }
        }

        
    }
}
