using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week_2_pd_business_application_list
{
    class Program
    {
        static void Main(string[] args)
        { 
            int option ;
            List  <admin>  flights = new List<admin> ();
            readDataofflights(flights);
            do
            {
                Console.Clear();
                option = optionmenu();
                Console.Clear();
                if (option == 1)
                {
                    flights.Add(takeinput());
                    storedata(flights);
                    Console.ReadKey();
                    
                }
                else if (option == 2)
                {
                    viewflights(flights);
                }
                else if (option == 3)
                {
                    updaterecord( flights);
                    storedata(flights);
                }
                else if (option == 4)
                {
                    deleterecord(flights);
                    storedata(flights);
                }
                else if (option == 5)
                {
                    break;
                }

            }
            while (option < 5);
            Console.Read();
           
        }
        static int optionmenu()
        {
            int option = 0;
            Console.WriteLine("1. to add flight record");
            Console.WriteLine("2. to view flight record");
            Console.WriteLine("3. to update flight record");
            Console.WriteLine("4. to delete flight record");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());
            return option;

        }

        static admin takeinput()
        {
            admin f = new admin();
            Console.WriteLine("Enter the current location : ");
            f.currentlocation = Console.ReadLine();
            Console.WriteLine("Enter the desired location : ");
            f.desiredlocation= Console.ReadLine();

            return f;

        }

        static void viewflights( List <admin> flights)
        {
            Console.Clear();
            for (int idx = 0; idx < flights.Count; idx++)
            {
                Console.WriteLine("Flight schdeule is {0} to {1}", flights[idx].currentlocation, flights[idx].desiredlocation);
            }
           
          Console.ReadKey();
        }

        static void updaterecord(List<admin> flights)
        {
            Console.WriteLine("Enter the index number of flight you want to change");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your current location : ");
            flights[index].currentlocation = Console.ReadLine();
            Console.WriteLine("Enter your desried location : ");
            flights[index].desiredlocation = Console.ReadLine();
            Console.ReadKey();
        }
        static void deleterecord(List<admin> flights)
        {
            Console.WriteLine("Enter the index number of flight you want to change");
            int index = int.Parse(Console.ReadLine());
            flights.RemoveAt(index);
            Console.ReadKey();
        }

        static void storedata(List<admin> flights)
        {
            string path = "C:\\OOP 2nd Semester\\week 2 pd business application list\\flights.txt";
            StreamWriter file = new StreamWriter(path);
            int idx = 0;
            while (idx < flights.Count)
            {
                file.WriteLine(flights[idx].currentlocation + "," + flights[idx].desiredlocation);
                idx++;
            }
            file.Flush();
            file.Close();
        }

        static void readDataofflights(List<admin> flights)
        {

            string path = "C:\\OOP 2nd Semester\\week 2 pd business application list\\flights.txt";
            if (File.Exists(path))
            {
                
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    admin obj = new admin();
                    obj.currentlocation = parseData(record, 1);
                    obj.desiredlocation = parseData(record, 2);
                     flights.Add(obj);

                }
                fileVariable.Close();

            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }

            }
            return item;
        }




    }
}
