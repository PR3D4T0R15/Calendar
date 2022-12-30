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
    public partial class GlowneOkno : Form
    {
        public static int rok = 0;
        public static int miesiac = 0;
        public static DateTime dataTeraz;

        public GlowneOkno()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTeraz = DateTime.Now;
            rok = dataTeraz.Year;

            UstawRok();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void PanelRoku_rokDoPrzodu_Click(object sender, EventArgs e)
        {
            rok++;
            UstawRok();
        }

        private void PanelRoku_rokDoTylu_Click(object sender, EventArgs e)
        {
            rok--;
            UstawRok();
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
    }
}
