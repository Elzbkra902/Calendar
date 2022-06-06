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
                Czynnosc = comboCzynnosc.Text,
                opis = txOpis.Text
            };
            SetResponse resp = await Client.SetAsync("Zdarzenia/"+txDate.Text,dane);
            Dane_Czynosci result = resp.ResultAs<Dane_Czynosci>();

            MessageBox.Show("Dane zostały zapisane w bazie danych");
            this.Close();
        }

        private void ZamknjiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCzynnosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCzynnosc.Text=="Karmienie")
            {
                jakaKarma.Visible = true;
                lblIle.Visible = true;
                lblJaka.Visible = true;
                iloscKarmy.Visible = true;

                lblDawka.Visible = false;
                lblLek.Visible = false;
                lblNowyLek.Visible = false;
                lekLista.Visible = false;
                nowyLek.Visible = false;
                dawkaBox.Visible = false;
                btnDodaj.Visible = false;

                czesanieCzekBox.Visible = false;

                mycieCzekBox.Visible = false;
                szampon.Visible = false;
                szamponNazwa.Visible = false;
                odrzywkaNazwa.Visible = false;
                odzywka.Visible = false;
            }
            if (comboCzynnosc.Text == "Leki")
            {
                lblDawka.Visible = true;
                lblIle.Visible = true;
                lblLek.Visible = true;
                lblNowyLek.Visible = true;
                lekLista.Visible = true;
                nowyLek.Visible = true;
                dawkaBox.Visible = true;
                btnDodaj.Visible = true;

                jakaKarma.Visible = false;
                lblIle.Visible = false;
                lblJaka.Visible = false;
                iloscKarmy.Visible = false;

                czesanieCzekBox.Visible = false;

                mycieCzekBox.Visible = false;
                szampon.Visible = false;
                szamponNazwa.Visible = false;
                odrzywkaNazwa.Visible = false;
                odzywka.Visible = false;
            }
            if (comboCzynnosc.Text == "Czesanie")
            {
                czesanieCzekBox.Visible = true;

                lblDawka.Visible = false;
                lblIle.Visible = false;
                lblLek.Visible = false;
                lblNowyLek.Visible = false;
                lekLista.Visible = false;
                nowyLek.Visible = false;
                dawkaBox.Visible = false;
                btnDodaj.Visible = false;

                jakaKarma.Visible = false;
                lblIle.Visible = false;
                lblJaka.Visible = false;
                iloscKarmy.Visible = false;

                mycieCzekBox.Visible = false;
                szampon.Visible = false;
                szamponNazwa.Visible = false;
                odrzywkaNazwa.Visible = false;
                odzywka.Visible = false;
            }
            if (comboCzynnosc.Text == "Mycie")
            {
                mycieCzekBox.Visible = true;
                szampon.Visible = true;
                szamponNazwa.Visible = true;
                odrzywkaNazwa.Visible = true;
                odzywka.Visible = true;

                lblDawka.Visible = false;
                lblIle.Visible = false;
                lblLek.Visible = false;
                lblNowyLek.Visible = false;
                lekLista.Visible = false;
                nowyLek.Visible = false;
                dawkaBox.Visible = false;
                btnDodaj.Visible = false;

                jakaKarma.Visible = false;
                lblIle.Visible = false;
                lblJaka.Visible = false;
                iloscKarmy.Visible = false;

                czesanieCzekBox.Visible = false;

            }
            if (comboCzynnosc.Text == "Inne")
            {
                lblDawka.Visible = false;
                lblIle.Visible = false;
                lblLek.Visible = false;
                lblNowyLek.Visible = false;
                lekLista.Visible = false;
                nowyLek.Visible = false;
                dawkaBox.Visible = false;
                btnDodaj.Visible = false;

                jakaKarma.Visible = false;
                lblIle.Visible = false;
                lblJaka.Visible = false;
                iloscKarmy.Visible = false;

                czesanieCzekBox.Visible = false;

                mycieCzekBox.Visible = false;
                szampon.Visible = false;
                szamponNazwa.Visible = false;
                odrzywkaNazwa.Visible = false;
                odzywka.Visible = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            lekLista.Items.Add(nowyLek.Text);
        }
    }
}
