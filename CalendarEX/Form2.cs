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
                    miesiacNazwa = "Styczeń";
                    break; 
                case 2:
                    miesiacNazwa = "Luty";
                    break;
            }

            PodzialTytul_tekst.Text = miesiacNazwa;
        }
    }
}
