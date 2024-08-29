using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop__Business_Application__with__BL__DL___UI_.Muser_BL;

namespace week_5_oop__Business_Application__with__BL__DL___UI_.Muser_UI
{
    public class muserUI
    {
        public static Muser takeinput()
        {

            Console.WriteLine("Enter your current location");
            string cl = Console.ReadLine();
            Console.WriteLine("Enter your desired location");
            string dl = Console.ReadLine();
            if (cl != null && dl != null)
            {
                Muser f = new Muser(cl, dl);
                return f;
            }
            return null;

        }
    }
}
