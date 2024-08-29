using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_Bl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_UI
{
    public class MuserUI
    {
        public static Muser getusersignup()
        {
            Console.WriteLine("Enter your username : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter the role (admin/customer)");
            string role = Console.ReadLine();

            Muser user = new Muser(name, password, role);
            return user;

        }

        public static Muser getusersignin()
        {
            Console.WriteLine("Enter your username : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Muser user = new Muser(name, password);
            return user;
        }



    }
}
