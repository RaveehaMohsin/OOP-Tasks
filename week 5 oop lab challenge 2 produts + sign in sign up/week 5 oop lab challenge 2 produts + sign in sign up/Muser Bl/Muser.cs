using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_Bl
{
    public class Muser
    {
        public string username;
        public string password;
        public string role;

        public Muser()
        {

        }
        public Muser(string username , string password)
        {
            this.username = username;
            this.password = password;
        }
        public Muser (string username , string password , string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public bool IsAdmin()
        {
            if (this.role.ToLower() == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
