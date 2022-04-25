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



        String connString = "server=localhost; user id=root; database=db_kalendarz;sslmode=none";
        

        public FormularzZdarzen()
        {
            InitializeComponent();
        }

        private void FormularzZdarzen_Load(object sender, EventArgs e)
        {
            txDate.Text = UserControlDays.static_day + "/" + Form1.static_month + "/" + Form1.static_year;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,czynnosc)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("date", txDate.Text);
            cmd.Parameters.AddWithValue("czynnosc", txCzynnosc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyślnie zapisano zmiany");
            cmd.Dispose();
            conn.Close();
        }
    }
}
