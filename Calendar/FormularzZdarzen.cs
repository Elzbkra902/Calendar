using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Calendar
{
    public partial class FormularzZdarzen : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4Z4BDQR2iD0Z2NU4w4NH1byRsdgRjci6ZAfCsbtQ",
            BasePath = "https://kalendarz-6c7c5-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient Client;

        // String connString = "server=localhost; user id=root; database=db_kalendarz;sslmode=none";
        

        public FormularzZdarzen()
        {
            InitializeComponent();
        }

        private void FormularzZdarzen_Load(object sender, EventArgs e)
        {
            try
            {
                Client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Program napotkał problem z nawiązaniem połączenia");
            }
            // Client = new FireSharp.FirebaseClient(config);
            if(Client != null) // test bazy 
            {
                MessageBox.Show("Nawiązano połączenie z bazą danych");
            }

            txDate.Text = Form1.static_year + "/" + Form1.static_month + "/" +  UserControlDays.static_day;
        }

        private async void btnZapisz_Click(object sender, EventArgs e)
        {
            var dane = new Dane_Czynosci 
            {
                data_czynnosci = txDate.Text,
                Czynnosc = txCzynnosc.Text,
                opis = txOpis.Text
            };
            SetResponse resp = await Client.SetAsync("Zdarzenia/"+txDate.Text,dane);
            Dane_Czynosci result = resp.ResultAs<Dane_Czynosci>();

            MessageBox.Show("Dane zostały zapisane w bazie danych");
            this.Close();
        }
    }
}
