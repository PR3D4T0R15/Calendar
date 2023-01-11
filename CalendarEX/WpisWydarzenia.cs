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
    public partial class WpisWydarzenia : UserControl
    {
        public WpisWydarzenia()
        {
            InitializeComponent();
        }

        public void UstawTekst(string tekst)
        {
            WpisWydarzenia_tekst.Text = tekst;
        }
    }
}
