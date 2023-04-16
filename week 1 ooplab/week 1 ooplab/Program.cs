using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_ooplab
{
    class Program
    {
       static bool flag = true;
       static string[] currentlocation = new string[1000];
        static string []  desiredlocation = new string [1000] ;
        static int schedule = 0;
         static int input_count = 0;


        static void Main(string[] args)
        { 
            readDataofflights();
            
            string path = "C:\\Users\\DELL\\Documents\\week 1 file handing\\login.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int option = 0;
            while (option < 3)
            {
                readData(path, names, passwords);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Username");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string p = Console.ReadLine();
                    signin(n, p, names, passwords);
                    if (flag == false)
                    {
                        while (true)
                        {
                            Console.Clear();
                            writeheader();
                            submenuaftermenu("Option");
                            int admin = admininterface();

                            if (admin == 1)
                            {

                                Console.Clear();
                                writeheader();
                                submenuaftermenu("Flight");
                                flightadd();
                               storedata();
                                Console.ReadKey();

                            }
                            if (admin == 2)
                            {

                                Console.Clear();
                                writeheader();
                                submenuaftermenu("Flight");
                                flightview();
                                Console.ReadKey();
                                
                            }
                            if (admin == 3)
                            {
                                Console.Clear();
                                writeheader();
                                submenuaftermenu("Flight");
                                flightdelete();
                                storedata();
                                Console.ReadKey();
                            }
                            if (admin == 4)
                            {
                                Console.Clear();
                                writeheader();
                                submenuaftermenu("Flight");
                                flightupdate();
                                storedata();
                                Console.ReadKey();
                            }
                        }

                    }

                }

                else if (option == 2)
                {
                    Console.WriteLine("Enter username");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string p = Console.ReadLine();
                    Signup(path, n, p);
                }

            }
            //while (option < 3);

            //Console.Read();

        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Sign In");
            Console.WriteLine("2.Sign Up");
            Console.WriteLine("Enter the option");
            option= int.Parse(Console.ReadLine());
           
            return option;
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

        static void readData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    passwords[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();

            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

        

        static void Signup(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }

        static void signin(string n, string p, string[] names, string[] passwords)
        {
            
            for (int idx = 0; idx < 5; idx++)
            {
                if (n == names[idx] && p == passwords[idx])
                {
                    Console.WriteLine("Valid User");
                    flag = false;

                }
            }
            if (flag == true)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }

        static int admininterface()
        {
            Console.WriteLine("1.Add new flight");
            Console.WriteLine("2.View allflight");
            Console.WriteLine("3.Delete a flight");
            Console.WriteLine("4.Update a flight");
            Console.WriteLine("Enter the option : ");
            int optionadmin = int.Parse(Console.ReadLine());

            return optionadmin;
        }
        static void writeheader()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                                                            *" );
            Console.WriteLine("*               AIRPORT MANAGEMENT SYSTEM                    *" );
            Console.WriteLine("*                                                            *");
            Console.WriteLine("**************************************************************");
        }

        static void submenuaftermenu(string submenu)
        {
            string menu = submenu + "MENU";
            Console.WriteLine(menu);
            Console.WriteLine("----------------------------------");
        }
        
        static void flightadd()
        {
            Console.WriteLine("How many flight scehdules you want to add");
            schedule = int.Parse(Console.ReadLine());
            int x = 0;
            while (x != schedule)
        
            {
                Console.WriteLine("Enter the current location of flight");
                currentlocation[input_count] = Console.ReadLine();
                Console.WriteLine("Enter the desired location of flight");
                desiredlocation[input_count] = Console.ReadLine();
                input_count++;
                x++;
            }
        }

        static void flightdelete()
        {
            Console.WriteLine("Enter which  flight scehdule you want to delete");
            int schedule = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < input_count; idx++)
            {
                if (schedule == idx + 1)
                {
                    Console.WriteLine("Your current location of flight");
                   Console.WriteLine (currentlocation[idx]) ;
                    Console.WriteLine("Your desired location of flight");
                    Console.WriteLine(desiredlocation[idx]);

                    Console.WriteLine("Now the current location of flight");
                    currentlocation[idx] = "###";
                    Console.WriteLine(currentlocation[idx]);
                    Console.WriteLine("Now the desired location of flight");
                    desiredlocation[idx] ="###";
                    Console.WriteLine(currentlocation[idx]);

                }
            }
        }
        static void flightview()
        {
            Console.WriteLine("Flight scehdules you want to view");
           
            for (int idx = 0; idx < input_count; idx++)
            {
                Console.WriteLine(idx+1 + " " + currentlocation[idx] + "  to  " + desiredlocation[idx]);
                
            }
        }

        static void flightupdate()
        {
            Console.WriteLine("Enter which  flight scehdule you want to update");
            int schedule = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < input_count; idx++)
            {
                if (schedule == idx + 1)
                {
                    Console.WriteLine("Your current location of flight");
                    Console.WriteLine(currentlocation[idx]);
                    Console.WriteLine("Your desired location of flight");
                    Console.WriteLine(desiredlocation[idx]);

                    Console.WriteLine("Now the current location of flight");
                    currentlocation[idx] = Console.ReadLine();
                    Console.WriteLine("Now the desired location of flight");
                    desiredlocation[idx] = Console.ReadLine();
                    Console.WriteLine( currentlocation[idx] + "  to  " + desiredlocation[idx]);

                }
            }
        }

       
            static void storedata()
            {
              string path = "C:\\Users\\DELL\\Documents\\week 1 file handing\\flights.txt";
              StreamWriter file = new StreamWriter(path);
            int idx = 0;
           while (idx < input_count)
            {
                file.WriteLine(currentlocation[idx] + "," + desiredlocation[idx]);
                idx++;
            }
                file.Flush();
                file.Close();
            }

        static void readDataofflights()
        {
            
            string path = "C:\\Users\\DELL\\Documents\\week 1 file handing\\flights.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    currentlocation[input_count] = parseData(record, 1);
                    desiredlocation[input_count] = parseData(record, 2);
                    input_count++;
                  
                }
                fileVariable.Close();

            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }







    }
}
