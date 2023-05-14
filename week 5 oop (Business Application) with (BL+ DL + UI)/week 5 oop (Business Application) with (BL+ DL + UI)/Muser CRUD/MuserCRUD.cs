using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop__Business_Application__with__BL__DL___UI_.Muser_BL;

namespace week_5_oop__Business_Application__with__BL__DL___UI_.Muser_CRUD
{
    public static class MuserCRUD
    {
        public static void addtolist(Muser m, List<Muser> flightslists)
        {
            flightslists.Add(m);
        }


        public static void viewflights(List<Muser> flights)
        {
            for (int idx = 0; idx < flights.Count; idx++)
            {
                Console.WriteLine("Your flight Schedule is from {0} to {1}", flights[idx].currentlocation, flights[idx].desiredlocation);

            }

        }

        public static void updateflights(List<Muser> flights)
        {
            int index;
            Console.WriteLine("Enter the index of flight you want to change");
            index = int.Parse(Console.ReadLine());
            index = index - 1;
            Console.WriteLine("Enter your new current location");
            flights[index].currentlocation = Console.ReadLine();
            Console.WriteLine("Enter your new desired location");
            flights[index].desiredlocation = Console.ReadLine();

            
        }

        public  static void deleterecord(List<Muser> flights)
        {
            int index;
            Console.WriteLine("Enter the index of flight you want to delete");
            index = int.Parse(Console.ReadLine());
            index = index - 1;
            flights.RemoveAt(index);
        }
    }
}


  
