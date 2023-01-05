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
    public partial class PelnyDzien : UserControl
    {
        public PelnyDzien()
        {
            InitializeComponent();
        }

        public void UstawNumerDnia(int numer)
        {
            NumerDnia.Text = numer.ToString();
        }
    }
}
