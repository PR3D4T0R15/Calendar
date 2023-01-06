using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CalendarEX
{
    public partial class OknoNoweWydarzenie : Form
    {
        public OknoNoweWydarzenie()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
           
        }

        public void UstawDomyslnaDate(int dzien, int miesiac, int rok)
        {
            Data_dzien.Text = dzien.ToString();
            Data_rok.Text = rok.ToString();
            Data_miesiac.SelectedIndex = miesiac - 1;
        }
    }
}
