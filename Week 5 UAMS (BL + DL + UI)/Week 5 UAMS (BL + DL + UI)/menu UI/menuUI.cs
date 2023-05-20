using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS__BL___DL___UI_.menu_UI
{
    public class menuUI
    {
        public static int menu()
        {
            int option;
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Add degree program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View registered students");
            Console.WriteLine("5. View students of a specific program");
            Console.WriteLine("6. Register subjects for a specific student");
            Console.WriteLine("7. Calculates fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }


    }
}
