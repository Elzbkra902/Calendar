using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace Calendar
{
    public partial class uzytkownik : Form
    {
        public uzytkownik()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4Z4BDQR2iD0Z2NU4w4NH1byRsdgRjci6ZAfCsbtQ",
            BasePath = "https://kalendarz-6c7c5-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient Client;

        private void uzytkownik_Load(object sender, EventArgs e)
        {
            try
            {
                Client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Program napotkał problem z nawiązaniem połączenia");
            }
            listaKalendarzy.Items.Add(Client.Get(@"Kalendarz"));

        }

        private void zapiszZamknij_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrWhiteSpace(listaKalendarzy.Text))
            {
                MessageBox.Show("Wybierz kalendarz");
                return;
            }
            #endregion

            User user = new User()
            {
                ListaKalendarzy = listaKalendarzy.Text,
                ImiePupila = imiePupila.Text
            };
            // SetResponse set = Client.Set(@"Users/" + UserNameTBox.Text, user);
            SetResponse set = Client.Set(@"Kalendarz/" + listaKalendarzy.Text, user);
            
            MessageBox.Show("Pomyślnie wybrano kalendarz");
            
            Form1 kal = new Form1();
            kal.ShowDialog();
            this.Close();
        }

        private void czyNowy_CheckedChanged(object sender, EventArgs e)
        {
            if(czyNowy.Checked==true)
            {
                imiePupila.Visible = true;
                label3.Visible = true;
                zatwierdz.Visible = true;
            }
            else
            {
                imiePupila.Visible = false;
                label3.Visible = false;
                zatwierdz.Visible = false;
            }
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {

            listaKalendarzy.Items.Add(imiePupila.Text);
        }
    }
}
