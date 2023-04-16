using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //task12();
            //task13();
            //task14();
            string path = "C:\\OOP 2nd Semester\\week 1\\signup";
            string[] names = new string[5];
            string[] passwords = new string[5];

            while (option > 3)
            {
                Console.Clear();
                int option = option();
                Console.Clear();

                if (option == 1)
                {
     
                    Console.WriteLine("Enter your name");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string p = Console.ReadLine();

                }
                else if (option ==2)
                {
                    Console.WriteLine("Enter new name ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string p = Console.ReadLine();
                }
            }
        }

        static void Task1()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }

        static void task2()
        {
            Console.Write("Hello World");
            Console.Write("Hello World");
            Console.ReadKey();
        }
        static void task3()
        {
            int variable = 8;
            char character = 'r';
            string words = "Raveeha Mohsin";
            float number = 9.0F;

            Console.WriteLine("Interger is : {0}", variable);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("String is :{0}", words);
            Console.WriteLine("Float is : {0}", number);

            Console.ReadKey();

        }

        static void task4()
        {
            string input = Console.ReadLine();
            Console.WriteLine("You have inputted : {0}", input);
            Console.ReadKey();
        }

        static void task5()
        {
            string word = Console.ReadLine();
            int number = int.Parse(word);
            Console.WriteLine("You have inputted : {0}", number);
            Console.ReadKey();
        }

        static void task6()
        {
            float area = 0;
            Console.WriteLine("Enter the Length : ");
            string len = Console.ReadLine();
            float length = float.Parse(len);
            area = length * length;
            Console.WriteLine("Area is : {0}", area);
            Console.ReadKey();
        }

        static void task7()
        {
            Console.WriteLine("Enter your marks: ");
            string marks = Console.ReadLine();
            int final = int.Parse(marks);
            if (final > 50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }

            Console.ReadKey();


        }

        static void task8()
        {
            for (int idx = 0; idx < 5; idx++)
            {
                Console.WriteLine("Welcome Raveeha");
            }

            Console.ReadKey();
        }

        static void task9()
        {
            int sum = 0;
            int number = 0;
            Console.WriteLine("Enter number : ");
            string num = Console.ReadLine();
            number = int.Parse(num);
            while (number != -1)
            {
                sum = sum + number;
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.ReadKey();
        }

        static void task10()
        {
            int[] array = new int[3];
            Console.WriteLine("Enter the numbers :");
            for (int idx = 0; idx < 3; idx++)
            {
                array[idx] = int.Parse(Console.ReadLine());
            }
            int largest = -12;
            for (int idx = 0; idx < 3; idx++)
            {
                if (array[idx] > largest)
                {
                    largest = array[idx];
                }
            }

            Console.WriteLine("Largest number is : {0}", largest);

            Console.ReadKey();
        }
        static void task11()
        {
            Console.WriteLine("Enter lilly's current age");
            string age = Console.ReadLine();
            int lillyage = int.Parse(age);
            Console.WriteLine("Enter price of washing machine");
            string price = Console.ReadLine();
            float wmprice = float.Parse(price);
            Console.WriteLine("Enter toy's price ");
            string tprice = Console.ReadLine();
            int toyprice = int.Parse(tprice);
            int finaltoyprice = 0;
            int moneycount = 0;
            int brother = 0;
            float result = 0;
            float differenceinmoney = 0;
            int adding = 10;

            for (int idx = 1; idx <= lillyage; idx++)
            {
                if (idx % 2 != 0)
                {
                    finaltoyprice = finaltoyprice + toyprice;

                }
                else if (idx % 2 == 0)
                {

                    moneycount = moneycount + adding;
                    adding = adding + 10;
                }
            }


            if (lillyage % 2 == 0)
            {
                brother = lillyage - (lillyage / 2);
            }
            else if (lillyage % 2 != 0)
            {
                brother = (lillyage - ((lillyage + 1) / 2));
            }

            result = finaltoyprice + moneycount - brother;

            differenceinmoney = result - wmprice;


            if (result > wmprice)
            {
                Console.WriteLine("Yes ! you can buy it");
                Console.WriteLine(differenceinmoney);

            }
            else
            {
                differenceinmoney = -1 * (differenceinmoney);
                Console.WriteLine("No ! you can't buy it");
                Console.WriteLine("{0} is more needed ", differenceinmoney);

            }


            Console.ReadKey();


        }

        static int add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        static void task12()
        {
            int n1;
            int n2;
            Console.WriteLine("Enter the number : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int total = add(n1, n2);
            Console.WriteLine("Sum is : {0}", total);
            Console.ReadKey();

        }

        static void task13()
        {
            string path = "C:\\OOP 2nd Semester\\week 1\\testing.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("Does not exists");
            }

            Console.ReadKey();


        }

        static void task14()
        {
            string path = "C:\\OOP 2nd Semester\\week 1\\testing1.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("Hello World");
            filevariable.Flush();
            filevariable.Close();
            Console.ReadKey();
        }

        static int option()
        {
            Console.WriteLine("1.Sign In");
            Console.WriteLine("2.Sign Up");
            string opt = Console.ReadLine();
            int option = int.Parse(opt);
            return option;
        }

        static string parseData(string record,int field)
        {
            int commacount = 1;
            string item = "";
            for (int idx = 0; idx < record.Length(); idx++ )
            {
                if (record[idx] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + record[idx];
                }
            }
            return item;
        }

        static void signup(string path, string n , string p)
        {
            
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p)
            file.Flush();
            file.Close();

        }

        static void signin (string n , string p)
        {

        }
    }
}
