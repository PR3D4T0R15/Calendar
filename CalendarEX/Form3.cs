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
    public partial class OknoNotatki : Form
    {
        private string plik = "notatki.txt";
        public OknoNotatki()
        {
            InitializeComponent();
        }

        private void OknoNotatki_Load(object sender, EventArgs e)
        {
            OdczytajDane();
        }

        private void Przyciski_zapisz_Click(object sender, EventArgs e)
        {
            ZapiszDane();
            this.Hide();
            GlowneOkno.uchwytGlowneOkno.WczytajNotatki();
        }

        private void Przyciski_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ZapiszDane()
        {
            string tekst = PanelNotatek.Text;

            StreamWriter plikW = new StreamWriter(plik);

            plikW.Write(tekst);

            plikW.Close();
        }

        private void OdczytajDane()
        {
            try
            {
                StreamReader plikR = new StreamReader(plik);
                PanelNotatek.Text = plikR.ReadToEnd();
                plikR.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                StreamWriter plikW = new StreamWriter(plik);
                plikW.WriteLine("Nowy plik z notatkami!");
                plikW.Close();

                StreamReader plikR = new StreamReader(plik);
                PanelNotatek.Text = plikR.ReadToEnd();
                plikR.Close();
            }
        }

        
    }
}
