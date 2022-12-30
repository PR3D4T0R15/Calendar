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
        }
    }
}
