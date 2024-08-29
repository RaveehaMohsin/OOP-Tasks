using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_challenge_3
{
    public class Program
    {
        public class customer
        {
            public string customername;
            public string customeraddress;
            public string customercontact;
            public List<product> customerproducts = new List<product>();
            public customer()
            {

            }
            public customer(string name, string add, string contact, List<product> customerproducts)
            {
                this.customername = name;
                this.customeraddress = add;
                this.customercontact = contact;
                this.customerproducts = customerproducts;
            }
            public customer addinfo()
            {
                
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your contact");
                string contact = Console.ReadLine();
                Console.WriteLine("Available Products in the shop");
                for (int idx = 0; idx < products.Count; idx++)
                {
                    Console.WriteLine(products[idx].pname);
                }

                Console.WriteLine("How many products you want to add?");
                int count = int.Parse(Console.ReadLine());
                for (int idx = 0; idx < count; idx++)
                {
                    Console.WriteLine("Enter the product name : ");
                    string pname = Console.ReadLine();
                    for (int x = 0; x < products.Count; x++)
                    {
                        if (products[x].pname == pname)
                        {
                            product p = products[x];
                            customerproducts.Add(p);
                        }
                    }
                }

                customer c = new customer(name, address, contact, customerproducts);
                return c;
            }

            public void viewallcustomerproducts()
            {

                for (int idx = 0; idx < customerproducts.Count; idx++)
                {
                    Console.WriteLine("Name of product: " + customerproducts[idx].pname + " Category of Product: " + customerproducts[idx].pcategory + " Price of Product:" + customerproducts[idx].pprice);
                }
            }

            public void calcuatetax()
            {
                float tax = 0;
                Console.WriteLine("Tax on every product is 5%");

                for (int idx = 0; idx < customerproducts.Count; idx++)
                {
                    float tax1 = (customerproducts[idx].pprice * 5) / 100.0F;
                    tax = tax + tax1;
                }
                Console.WriteLine("Tax on your products is " + tax);
            }




        }

        public class product
        {
            public product()
            {

            }
            public product(string pname, string pcategory, int pprice)
            {
                this.pname = pname;
                this.pcategory = pcategory;
                this.pprice = pprice;
            }

            public product addproduct()
            {
                Console.WriteLine("Enter the name of the product");
                string pname = Console.ReadLine();
                Console.WriteLine("Enter the category of the product");
                string pcategory = Console.ReadLine();
                Console.WriteLine("Enter the product price");
                int pprice = int.Parse(Console.ReadLine());

                product p = new product(pname, pcategory, pprice);
                return p;
            }
            public void viewallproducts()
            {
                Console.WriteLine("The store has following products");
                for (int idx = 0; idx < products.Count; idx++)
                {
                    Console.WriteLine("Name of product: " + products[idx].pname + " Category of Product: " + products[idx].pcategory + " Price of Product:" + products[idx].pprice);
                }
            }
            public string pname;
            public string pcategory;
            public int pprice;
        }
        static List<product> products = new List<product>();
        static void Main(string[] args)
        {
            int option;
            
            product p = new product();
            customer c = new customer();
            

            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    p = p.addproduct();
                    products.Add(p);
                    Console.ReadKey();

                }
                if (option == 2)
                {
                    p.viewallproducts();
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    c.addinfo();
                    Console.ReadKey();

                }
                if (option ==4)
                {
                    c.viewallcustomerproducts();
                    Console.ReadKey();
                }
                if (option == 5)
                {
                     c.calcuatetax();
                    
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    break;
                }

            }
            while (option < 6);
            Console.Read();

        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Add a product");
            Console.WriteLine("2.View all the products");
            Console.WriteLine("3.Buy/add product to cart");
            Console.WriteLine("4.Get all products");
            Console.WriteLine("5.Calculate Tax on Products");
            Console.WriteLine("6.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
