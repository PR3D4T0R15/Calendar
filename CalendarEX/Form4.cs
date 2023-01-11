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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

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
            DodajWpisyTerminarza();
            this.Hide();
            
        }

        public void UstawDomyslnaDate(int dzien, int miesiac, int rok)
        {
            Data_dzien.Text = dzien.ToString();
            Data_rok.Text = rok.ToString();
            Data_miesiac.SelectedIndex = miesiac - 1;
        }

        private void DodajWpisyTerminarza()
        {
            //pobrane dane do zapytania
            string nazwa = NazwaWydarzenia.Text;
            string dzien = Data_dzien.Text;
            string miesiac = Convert.ToString(Data_miesiac.SelectedIndex + 1);
            string rok = Data_rok.Text;
            string czyWazne = "0";
            if (CzyWazneWydarzenie.Checked == true)
            {
                czyWazne = "1";
            }
            
            //obiekt nowego polaczenia do bazy danych
            SQLiteConnection sqlitePolaczenie = new SQLiteConnection("Data Source=dane.sqlite;Version=3;New=False;Compress=True");
            //proba podlaczenia do bazy danych
            try
            {
                sqlitePolaczenie.Open();
            }
            catch { }

            //tworzenie nowego zapytania
            SQLiteCommand wpisanieWydarzenia = sqlitePolaczenie.CreateCommand();
            wpisanieWydarzenia.CommandText = "INSERT INTO main.Wydarzenia (nazwa, dzien, miesiac, rok, czyWazne) VALUES ($nazwa, $dzien, $miesiac, $rok, $czyWazne);";
            wpisanieWydarzenia.Parameters.AddWithValue("$nazwa", nazwa);
            wpisanieWydarzenia.Parameters.AddWithValue("$dzien", dzien);
            wpisanieWydarzenia.Parameters.AddWithValue("$miesiac", miesiac);
            wpisanieWydarzenia.Parameters.AddWithValue("$rok", rok);
            wpisanieWydarzenia.Parameters.AddWithValue("$czyWazne", czyWazne);
            //wykonanie zapytania
            try
            {
                wpisanieWydarzenia.ExecuteNonQuery();
            }
            catch { }

            sqlitePolaczenie.Close();

        }
    }
}
