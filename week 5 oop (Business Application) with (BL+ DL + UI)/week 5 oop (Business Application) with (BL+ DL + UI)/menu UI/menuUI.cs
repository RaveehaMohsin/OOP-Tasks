using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop__Business_Application__with__BL__DL___UI_.menu_UI
{
    public class menuUI
    {
        public static int optmenu()
        {
            int option = 0;
            Console.WriteLine("1. To add flight record");
            Console.WriteLine("2. To view flight record");
            Console.WriteLine("3. To update flight record");
            Console.WriteLine("4. To delete flight record");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
