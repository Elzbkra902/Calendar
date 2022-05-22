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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4Z4BDQR2iD0Z2NU4w4NH1byRsdgRjci6ZAfCsbtQ",
            BasePath = "https://kalendarz-6c7c5-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient Client;

        private void Rejestracja_Load(object sender, EventArgs e)
        {
            try
            {
                Client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Program napotkał problem z nawiązaniem połączenia");
            }
        }

        private void RejestrBtn_Click(object sender, EventArgs e)
        {
            #region Warunki formularza
            if (string.IsNullOrWhiteSpace(UserNameTBox.Text) &&
                string.IsNullOrWhiteSpace(PassTBox.Text) &&
                string.IsNullOrWhiteSpace(mailTBox.Text)) 
                MessageBox.Show("Uzupełnij wszystkie pola formularza");
            #endregion

            MyUser user = new MyUser()
            {
                Login = UserNameTBox.Text,
                Haslo = PassTBox.Text,
                Mail = mailTBox.Text
            };

            SetResponse set = Client.Set(@"Users/"+ UserNameTBox.Text, user);
            MessageBox.Show("Rejestracja przebiegła pomyślnie");

        }
    }
}
