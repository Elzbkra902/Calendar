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
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4Z4BDQR2iD0Z2NU4w4NH1byRsdgRjci6ZAfCsbtQ",
            BasePath = "https://kalendarz-6c7c5-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient Client;

        private void logowanie_Load(object sender, EventArgs e)
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
            Rejestracja reg = new Rejestracja();
            reg.ShowDialog();
        }

        private void LogInBUT_Click(object sender, EventArgs e)
        {
            #region Warunki formularza
            if (string.IsNullOrWhiteSpace(UserNameTBox.Text) &&
                string.IsNullOrWhiteSpace(PassTBox.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola formularza");
                return;
            }
            #endregion
            FirebaseResponse res = Client.Get(@"Users/" + UserNameTBox.Text);
            MyUser ResUser = res.ResultAs<MyUser>();
            
            MyUser CurUser = new MyUser()
            {
                Login = UserNameTBox.Text,
                Haslo = PassTBox.Text
            };

            if(MyUser.IsEqual(ResUser,CurUser))
            {
                Form1 kal = new Form1();
                kal.ShowDialog();
                this.Close();
            }
            else
            {
                MyUser.ShowError();
            }
        }

        private void ZamknjiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pokaz_Click(object sender, EventArgs e)
        {
            if (PassTBox.PasswordChar == '*')
            {
                ukryj.BringToFront();
                PassTBox.PasswordChar = '\0';
            }
        }

        private void ukryj_Click(object sender, EventArgs e)
        {
            if (PassTBox.PasswordChar == '\0')
            {
                pokaz.BringToFront();
                PassTBox.PasswordChar = '*';
            }
        }
    }
}
