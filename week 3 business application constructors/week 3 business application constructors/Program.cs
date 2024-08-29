using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_business_application_constructors
{
    class Program
    {
        public class Muser
        {
            public Muser ()
            {

            }
            public Muser(string currentlocation, string desiredlocation)
            {
                this.currentlocation = currentlocation;
                this.desiredlocation = desiredlocation;
            }
            public Muser takeinput()
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

            public void viewflights(List<Muser> flights)
            {
                for (int idx = 0; idx < flights.Count; idx ++)
                {
                    Console.WriteLine("Your flight Schedule is from {0} to {1}", flights[idx].currentlocation, flights[idx].desiredlocation);

                }
                
            }
            public Muser updateflights(List<Muser> flights)
            {
                int index;
                Console.WriteLine("Enter the index of flight you want to change");
                index = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your new current location");
                flights[index].currentlocation = Console.ReadLine();
                Console.WriteLine("Enter your new desired location");
                flights[index].desiredlocation = Console.ReadLine();

                Muser update = new Muser(flights[index].currentlocation, flights[index].desiredlocation);
                return update;
            }

            public void deleterecord(List<Muser> flights)
            {
                int index;
                Console.WriteLine("Enter the index of flight you want to delete");
                index = int.Parse(Console.ReadLine());
                flights.RemoveAt(index);
            }

            public int optmenu()
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

            public string currentlocation;
            public string desiredlocation;
        }
        static void Main(string[] args)
        {
            int option;
            List<Muser> flights = new List<Muser>();      
            do
            {
                Muser f = new Muser();
                Console.Clear();
                option = f.optmenu();
                Console.Clear();
                if (option == 1)
                {
                    Muser user = f.takeinput();
                    flights.Add(user);
                    
                }
                else if (option == 2)
                {
                    f.viewflights(flights);
                    Console.ReadKey();
                }
                else if (option == 3 )
                {
                    Muser update = f.updateflights(flights);  

                }
                else if (option == 4)
                {
                    f.deleterecord(flights);
                }
                else if (option == 5)
                {
                    break;
                }

            }
            while (option < 6);
            Console.Read();

            Console.ReadKey();
        }
    }
}
