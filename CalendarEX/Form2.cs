using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarEX
{
    public partial class OknoMiesiac : Form
    {
        public OknoMiesiac()
        {
            InitializeComponent();
        }

        private void PodzialTytul_tekst_Click(object sender, EventArgs e)
        {

        }

        private void OknoMiesiac_Load(object sender, EventArgs e)
        {
            string miesiacNazwa = "";

            switch(GlowneOkno.miesiac)
            {
                case 0:
                    miesiacNazwa = "ERROR";
                    break;
                case 1:
                    miesiacNazwa = "styczeń";
                    PodzialTytul_obraz.Image = CalendarEX.img.styczen;
                    break; 
                case 2:
                    miesiacNazwa = "luty";
                    PodzialTytul_obraz.Image = CalendarEX.img.luty;
                    break;
                case 3:
                    miesiacNazwa = "marzec";
                    PodzialTytul_obraz.Image = CalendarEX.img.marzec;
                    break;
                case 4:
                    miesiacNazwa = "kwiecień";
                    PodzialTytul_obraz.Image = CalendarEX.img.kwiecien;
                    break;
                case 5:
                    miesiacNazwa = "maj";
                    PodzialTytul_obraz.Image = CalendarEX.img.maj;
                    break;
                case 6:
                    miesiacNazwa = "czerwiec";
                    PodzialTytul_obraz.Image = CalendarEX.img.czerwiec;
                    break;
                case 7:
                    miesiacNazwa = "lipiec";
                    PodzialTytul_obraz.Image = CalendarEX.img.lipiec;
                    break;
                case 8:
                    miesiacNazwa = "sierpień";
                    PodzialTytul_obraz.Image = CalendarEX.img.sierpien;
                    break;
                case 9:
                    miesiacNazwa = "wrzesień";
                    PodzialTytul_obraz.Image = CalendarEX.img.wrzesien;
                    break;
                case 10:
                    miesiacNazwa = "październik";
                    PodzialTytul_obraz.Image = CalendarEX.img.pazdziernik;
                    break;
                case 11:
                    miesiacNazwa = "listopad";
                    PodzialTytul_obraz.Image = CalendarEX.img.listopad;
                    break;
                case 12:
                    miesiacNazwa = "grudzień";
                    PodzialTytul_obraz.Image = CalendarEX.img.grudzien;
                    break;
            }

            PodzialTytul_tekst.Text = miesiacNazwa;

            WyswietlKalendarz();
        }

        private void WyswietlKalendarz()
        {
            // pierwszy dzien wybranego miesiaca
            DateTime aktualnyMiesiac = new DateTime(GlowneOkno.rok, GlowneOkno.miesiac, 1);

            // liczba dni w miesiacu
            int liczbaDniMiesiac = DateTime.DaysInMonth(GlowneOkno.rok, GlowneOkno.miesiac);

            // pierwszy dzien wybranego miesiaca - jaki to jest dzien
            string pierwszyDzienTygodniaMiesiac = aktualnyMiesiac.DayOfWeek.ToString();

            //jaki to dzien tygodnia
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

            //wypelnienie pustych dni na początku kalendarza
            for(int i = 0; i < numerPierwszyDzienMiesiac; i++)
            {
                PustyDzien pustaKontrolkaDni = new PustyDzien();
                PodzialTygodni_kontrolkiDni.Controls.Add(pustaKontrolkaDni);
                pustaKontrolkaDni.Name = "pusta_" + i.ToString();
            }

            //wypelnienie dni danego miesiaca
            for(int i = 1; i <= liczbaDniMiesiac; i++)
            {
                PelnyDzien kontrolkaDni = new PelnyDzien();
                PodzialTygodni_kontrolkiDni.Controls.Add(kontrolkaDni);
                kontrolkaDni.UstawNumerDnia(i);
                kontrolkaDni.Name = "dzien_" + i.ToString();
            }

        }
    }
}
