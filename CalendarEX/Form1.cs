using System;
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
    public partial class GlowneOkno : Form
    {
        public static int rok = 0;
        public static int miesiac = 0;
        public static int dzien = 0;
        public static DateTime dataTeraz;
        public static GlowneOkno uchwytGlowneOkno;

        public GlowneOkno()
        {
            InitializeComponent();
            uchwytGlowneOkno = this;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTeraz = DateTime.Now;
            rok = dataTeraz.Year;
            dzien = dataTeraz.Day;

            UstawRok();

            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();

            OdczytajDane();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRoku_rokDoPrzodu_Click(object sender, EventArgs e)
        {
            rok++;
            UstawRok();

            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        private void PanelRoku_rokDoTylu_Click(object sender, EventArgs e)
        {
            rok--;
            UstawRok();

            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        private void PanelRoku_rok_Click(object sender, EventArgs e)
        {

        }

        private void UstawRok()
        {
            PanelRoku_rok.Text = rok.ToString();
        }

        private void Styczen_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 1;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Luty_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 2;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Marzec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 3;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Kwiecien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 4;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Maj_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 5;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Czerwiec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 6;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Lipiec_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 7;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Sierpien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 8;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Wrzesien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 9;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Pazdziernik_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 10;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Listopad_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 11;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void Grudzien_tekst_Click(object sender, EventArgs e)
        {
            miesiac = 12;

            OknoMiesiac WidokMiesiac = new OknoMiesiac();
            WidokMiesiac.Show();
        }

        private void WczytajWydarzeniaOknoGlowne()
        {
            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            for(int i = 1;  i <= 12; i++)
            {
                SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();
                pobranieDat.CommandText = "SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND rok = $rok ORDER BY dzien ASC;";
                pobranieDat.Parameters.AddWithValue("$miesiac", i);
                pobranieDat.Parameters.AddWithValue("$rok", GlowneOkno.rok);

                SQLiteDataReader wynik = pobranieDat.ExecuteReader();
                while(wynik.Read())
                {
                    int dzien = wynik.GetInt16(0);
                    string nazwa = wynik.GetString(1);

                    DodajWydarzenieDoListy(dzien, i, nazwa);
                }
            }
            sqlitePolaczenie.Close();
        }

        private void DodajWydarzenieDoListy(int dzien, int miesiac, string nazwa)
        {
            //utworzenie napisu z wydarzeniem
            WpisWydarzenia wydarzenie = new WpisWydarzenia();

            wydarzenie.UstawTekst(dzien.ToString() + ": " + nazwa);
            wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa;
            wydarzenie.WylaczAkcjeKlikniecia();
            wydarzenie.Width = Styczen_lista.Width - 6;


            switch (miesiac)
            {
                case 1:
                    Styczen_lista.Controls.Add(wydarzenie);
                    break;
                case 2:
                    Luty_lista.Controls.Add(wydarzenie);
                    break;
                case 3:
                    Marzec_lista.Controls.Add(wydarzenie);
                    break;
                case 4:
                    Kwiecien_lista.Controls.Add(wydarzenie);
                    break;
                case 5:
                    Maj_lista.Controls.Add(wydarzenie);
                    break;
                case 6:
                    Czerwiec_lista.Controls.Add(wydarzenie);
                    break;
                case 7:
                    Lipiec_lista.Controls.Add(wydarzenie);
                    break;
                case 8:
                    Sierpien_lista.Controls.Add(wydarzenie);
                    break;
                case 9:
                    Wrzesien_lista.Controls.Add(wydarzenie);
                    break;
                case 10:
                    Pazdziernik_lista.Controls.Add(wydarzenie);
                    break;
                case 11:
                    Listopad_lista.Controls.Add(wydarzenie);
                    break;
                case 12:
                    Grudzien_lista.Controls.Add(wydarzenie);
                    break;
            }
        }
        
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

        private void WczytajWydarzeniaNadchodzace()
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
            pobranieDat.CommandText = "SELECT dzien,nazwa FROM main.Wydarzenia WHERE miesiac = $miesiac AND dzien > $dzien AND rok=  $rok ORDER BY dzien ASC;";
            pobranieDat.Parameters.AddWithValue("$miesiac", GlowneOkno.miesiac + 1);
            pobranieDat.Parameters.AddWithValue("$dzien", GlowneOkno.dzien);
            pobranieDat.Parameters.AddWithValue("$rok", GlowneOkno.rok);

            SQLiteDataReader wynik = pobranieDat.ExecuteReader();
            while (wynik.Read())
               {
                 int dzien = wynik.GetInt16(0);
                 string nazwa = wynik.GetString(1);

                 DodajWydarzenieDoListy(dzien, 0, nazwa, 0);
                }
            
            sqlitePolaczenie.Close();
        }

        private void DodajWydarzenieDoListy(int dzien, int miesiac, string nazwa, int czyWazne)
        {
            if (czyWazne == 0)
            {
                //utworzenie napisu z wydarzeniem
                WpisWydarzenia wydarzenie = new WpisWydarzenia();

                wydarzenie.UstawTekst(dzien.ToString() + ": " + nazwa);
                wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa;
                wydarzenie.Width = Nadchodzace_lista.Width - 6;
                wydarzenie.WylaczAkcjeKlikniecia();
                Nadchodzace_lista.Controls.Add(wydarzenie);
            }
            else if (czyWazne == 1)
            {
                //utworzenie napisu z wydarzeniem
                WpisWydarzenia wydarzenie = new WpisWydarzenia();

                wydarzenie.UstawTekst(dzien.ToString() + "." + miesiac.ToString() + " : " + nazwa);
                wydarzenie.Name = dzien.ToString() + ":" + GlowneOkno.miesiac.ToString() + ":" + GlowneOkno.rok.ToString() + ":" + nazwa;
                wydarzenie.Width = Najwazniejsze_lista.Width - 6;
                wydarzenie.WylaczAkcjeKlikniecia();
                Najwazniejsze_lista.Controls.Add(wydarzenie);
            }
            
        }

        private void WyczyscListyWydarzenNadchodzace()
        {
            Nadchodzace_lista.Controls.Clear();
        }

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

            SQLiteCommand pobranieDat = sqlitePolaczenie.CreateCommand();
            pobranieDat.CommandText = "SELECT dzien,miesiac,nazwa FROM main.Wydarzenia WHERE czyWazne = $czyWazne ORDER BY dzien ASC;";
            pobranieDat.Parameters.AddWithValue("$czyWazne", 1);

            SQLiteDataReader wynik = pobranieDat.ExecuteReader();
            while (wynik.Read())
            {
                int dzien = wynik.GetInt16(0);
                int miesiac = wynik.GetInt16(1);
                string nazwa = wynik.GetString(2);

                DodajWydarzenieDoListy(dzien, miesiac, nazwa, 1);
            }

            sqlitePolaczenie.Close();
        }

        private void WyczyscListyWydarzenWazne()
        {
            Najwazniejsze_lista.Controls.Clear();
        }

        private void GlowneOkno_Resize(object sender, EventArgs e)
        {
            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();

        }

        public void AktualzujWydarzenia()
        {
            WyczyscListyWydarzenMiesiecy();
            WczytajWydarzeniaOknoGlowne();

            WyczyscListyWydarzenNadchodzace();
            WczytajWydarzeniaNadchodzace();

            WyczyscListyWydarzenWazne();
            WczytajWydarzeniaWazne();
        }

        private void Notatki_tekst_Click(object sender, EventArgs e)
        {
            OknoNotatki OknoNotatki = new OknoNotatki();
            OknoNotatki.Show();
        }

        public void OdczytajDane()
        {
            string plik = "notatki.txt";

            try
            {
                StreamReader plikR = new StreamReader(plik);
                Notatki_pole.Text = plikR.ReadToEnd();
                plikR.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                
            }
        }
    }
}
