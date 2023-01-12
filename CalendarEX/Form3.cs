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
    public partial class OknoNotatki : Form
    {
        public OknoNotatki()
        {
            InitializeComponent();
        }

        private void Przyciski_zapisz_Click(object sender, EventArgs e)
        {
            string tekst = PanelNotatek.Text;
        }

        private void Przyciski_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
