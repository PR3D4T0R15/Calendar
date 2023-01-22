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
    public partial class OknoMiesiac : Form //Klasa OknoMiesiac dziedziczaca atrybuty i metody po klasie Form
    {
        public static OknoMiesiac uchwytOknoMiesiac; //deklaracja zmiennej wskazujaca na klase OknoMiesiac

        public OknoMiesiac()    //konstruktor klasy 
        {
            InitializeComponent();  //zaladowanie okna, zrobione przez visual
            uchwytOknoMiesiac = this;   //przypisujemy do zmienne uchwytGLowneOkno klase GlowneOKno
        }

        //FUNKCJA AKTUALIZUJACA WYDARZENIA
        public void AktualizujWydarzenia()
        {
            PodzialTygodni_kontrolkiDni.Controls.Clear();
            WyswietlKalendarz();
        }

        //FUNKCJA WYKONUJACA SIE GDY OKNO JEST ZALADOWANE
        private void OknoMiesiac_Load(object sender, EventArgs e)
        {
            string miesiacNazwa = ""; //zmienna przechowujaca nazwe miesiaca

            switch(GlowneOkno.miesiac) //przelacznik sluzacy do zaladowania odpowiedniego obrazka przypisanego do konkretnego miesiaca
            {
                case 0:
                    miesiacNazwa = "ERROR"; //obsluga bledu jak cos sie nie zaladuje
                    break;
                case 1: //przypadek 1 - jak wybrany zostanie miesiac styczen to zaladuje sie obrazek przypisany do miesiaca styczen
                    miesiacNazwa = "STYCZEŃ";
                    PodzialTytul_obraz.Image = CalendarEX.img.styczen;
                    break; 
                case 2:
                    miesiacNazwa = "LUTY";
                    PodzialTytul_obraz.Image = CalendarEX.img.luty;
                    break;
                case 3:
                    miesiacNazwa = "MARZEC";
                    PodzialTytul_obraz.Image = CalendarEX.img.marzec;
                    break;
                case 4:
                    miesiacNazwa = "KWIECIEŃ";
                    PodzialTytul_obraz.Image = CalendarEX.img.kwiecien;
                    break;
                case 5:
                    miesiacNazwa = "MAJ";
                    PodzialTytul_obraz.Image = CalendarEX.img.maj;
                    break;
                case 6:
                    miesiacNazwa = "CZERWIEC";
                    PodzialTytul_obraz.Image = CalendarEX.img.czerwiec;
                    break;
                case 7:
                    miesiacNazwa = "LIPIEC";
                    PodzialTytul_obraz.Image = CalendarEX.img.lipiec;
                    break;
                case 8:
                    miesiacNazwa = "SIERPIEŃ";
                    PodzialTytul_obraz.Image = CalendarEX.img.sierpien;
                    break;
                case 9:
                    miesiacNazwa = "WRZESIEŃ";
                    PodzialTytul_obraz.Image = CalendarEX.img.wrzesien;
                    break;
                case 10:
                    miesiacNazwa = "PAŹDZIERNIK";
                    PodzialTytul_obraz.Image = CalendarEX.img.pazdziernik;
                    break;
                case 11:
                    miesiacNazwa = "LISTOPAD";
                    PodzialTytul_obraz.Image = CalendarEX.img.listopad;
                    break;
                case 12:
                    miesiacNazwa = "GRUDZIEŃ";
                    PodzialTytul_obraz.Image = CalendarEX.img.grudzien;
                    break;
            }

            PodzialTytul_tekst.Text = miesiacNazwa; //ustawienie nazwy miesiaca w oknie

            WyswietlKalendarz(); //wyswietlenie kalendarza - dni dla konkretnego miesiaca
        }

        //FUNKCJA WYSWIETLAJACA KALENDARZ DLA WYBRANEGO MIESIACA
        private void WyswietlKalendarz()
        {
            //ustawienie pierwszego dnia wybranego miesiaca (w jakim dniu tygodnia sie rozpoczyna)
            DateTime pierwszyDzienMiesiaca = new DateTime(GlowneOkno.rok, GlowneOkno.miesiac, 1);

            //pobranie ile dni ma wybvrany miesiac
            int liczbaDniMiesiac = DateTime.DaysInMonth(GlowneOkno.rok, GlowneOkno.miesiac);

            //pobranie danej jaki to jest dzien - czy poniedzialek, wtorek, ...
            string pierwszyDzienTygodniaMiesiac = pierwszyDzienMiesiaca.DayOfWeek.ToString();

            //zmienna przechowujaca konkretne wartosci dla danego dnia tygodnia
            int numerPierwszyDzienMiesiac = 0;

            if(pierwszyDzienTygodniaMiesiac == "Monday")
            {
                numerPierwszyDzienMiesiac = 0;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Tuesday")
            {
                numerPierwszyDzienMiesiac = 1;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Wednesday")
            {
                numerPierwszyDzienMiesiac = 2;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Thursday")
            {
                numerPierwszyDzienMiesiac = 3;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Friday")
            {
                numerPierwszyDzienMiesiac = 4;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Saturday")
            {
                numerPierwszyDzienMiesiac = 5;
            }
            else if (pierwszyDzienTygodniaMiesiac == "Sunday")
            {
                numerPierwszyDzienMiesiac = 6;
            }

            //WYPELNIENIE PUSTYCH DNI NA POCZATKU KALENDARZA (PUSTE KAFELKI)
            for(int i = 0; i < numerPierwszyDzienMiesiac; i++)
            {
                //tworzenie zmiennej przechowujacej kontrolke pustego dnia
                PustyDzien pustaKontrolkaDni = new PustyDzien();
                //dodanie kontrolki do listy dni
                PodzialTygodni_kontrolkiDni.Controls.Add(pustaKontrolkaDni);
                //ustawienie nazwy kontrolki
                pustaKontrolkaDni.Name = "pusta_" + i.ToString();

                //USTAWIENIE SZEROKOSCI I WYSOKOSCI KAFELKA
                pustaKontrolkaDni.Width = (PodzialTygodni_kontrolkiDni.Width / 7) - 2;
                pustaKontrolkaDni.Height = (PodzialTygodni_kontrolkiDni.Height / 6) - 2;
            }

            //WYPELNIENIE DNI DANEGO MIESIACA
            for(int i = 1; i <= liczbaDniMiesiac; i++) 
            {
                //tworzenie ziennej przechowujacej kontrolke pelnego dnia
                PelnyDzien kontrolkaDni = new PelnyDzien();
                //dodanie kontrolki do listy dni
                PodzialTygodni_kontrolkiDni.Controls.Add(kontrolkaDni);
                //ustawienie numeru dnia
                kontrolkaDni.UstawNumerDnia(i);
                //ustawienie nazwy kontrolki
                kontrolkaDni.Name = "dzien_" + i.ToString();

                //USTAWIENIE SZEROKOSCI I WYSOKOSCI KAFELKA
                kontrolkaDni.Width = (PodzialTygodni_kontrolkiDni.Width / 7) - 2;
                kontrolkaDni.Height = (PodzialTygodni_kontrolkiDni.Height / 6) - 2;
            }

        }

        //FUNKCJA WYSWIETLAJACA NA NOWO GLOWNE OKNO PO ZMIANIE ROZMIARU OKNA 
        private void OknoMiesiac_Resize(object sender, EventArgs e)
        {
            PodzialTygodni_kontrolkiDni.Controls.Clear();
            WyswietlKalendarz();
        }
    }
}
