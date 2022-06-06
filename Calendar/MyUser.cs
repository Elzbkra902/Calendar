using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class MyUser
    {

        public string Mail { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        private static string error="Program napotkał problem z logowaniem";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }
            
            if (user1.Login != user2.Login)
            {
                error = "Użytkownik nie istnieje";
                return false;
            }
            else if (user1.Haslo != user2.Haslo)
            {
                error = "Hasło jest niepoprawne lub użytkownik nie istnieje";
                return false;
            }
            return true;
        }

    }
}
