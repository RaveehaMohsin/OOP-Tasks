using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_lab_store_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            product[] p = new product[20];
            int count = 0;
            char option;
            int sum;
            do
            {
                option = menu();
                if (option == '1')
                {
                    p[count] = addproduct();
                    count++;
                }
                else if (option == '2')
                {
                    viewproduct( p,  count);
                }
                else if (option == '3')
                {
                    Console.Clear();
                   sum =  totalstoreworth(p , count);
                    Console.WriteLine("Total store worth is {0} ", sum);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            } while (option != '4');
            
                Console.WriteLine("Press any key to continue");
                Console.Read();
            

        }

        static char menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("Press 1 Add Products");
            Console.WriteLine("Press 2 Show Produts");
            Console.WriteLine("Press 3 Total store worth");
            Console.WriteLine("Press 4 Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static product addproduct()
        {
            Console.Clear();
            product p1 = new product();
            Console.WriteLine("Enter ID");
            p1.ID = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter Price");
            p1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category:");
            p1.category = Console.ReadLine();
            Console.WriteLine("Enter Brand Name:");
            p1.brandname= Console.ReadLine();
            Console.WriteLine("Enter Country");
            p1.country = Console.ReadLine();
            Console.ReadKey();

            return p1;

        }

        static void viewproduct(product[] p , int count)
        {
            Console.Clear();
            for(int idx = 0; idx < count; idx ++)
            {
                Console.WriteLine("ID = {0}, Name = {1} , Price = {2} , Category = {3} , BrandName = {4} , Country = {5} ", p[idx].ID, p[idx].name, p[idx].price, p[idx].category, p[idx].brandname, p[idx].country);
            }
            Console.ReadKey();
        }

        static int totalstoreworth(product[] p, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i ++)
            {
               sum = sum + p[i].price;
            }

            return sum;

        }
       
    }
}
