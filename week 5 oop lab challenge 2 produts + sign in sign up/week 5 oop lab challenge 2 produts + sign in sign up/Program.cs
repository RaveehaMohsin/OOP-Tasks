using System;
using System.Collections.Generic;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_BL;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_DL;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_UI;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_Bl;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_DL;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_UI;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_dl;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.productUI;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int option = 0;
            int optionadmin = 0;
            int optioncustomer = 0;

            List<Muser> users = new List<Muser>();
            List<Product> products = new List<Product>();
            List<Product> customerproducts = new List<Product>();

            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                Muser user = new Muser();
                Product p = new Product();
                Customer c = new Customer();


                if (option == 1)
                {
                    user = MuserUI.getusersignup();
                    users.Add(user);
                    Console.ReadKey();
                }
                if (option == 2)
                {
                    bool flag;
                    user = MuserUI.getusersignin();
                    flag = MuserCRUD.signin(user, users);
                    if (flag == true)
                    {
                        user = MuserCRUD.GetUSer(user, users);
                    }

                    if (flag == true && user.IsAdmin())
                    {
                        Console.WriteLine("Valid User");
                        Console.WriteLine("Welcome as an Admin");
                        Console.ReadKey();
                        do
                        {
                            Console.Clear();
                            optionadmin = menuadmin();
                            Console.Clear();
                            if (optionadmin == 1)
                            {
                                p = ProductUI.Addproduct();
                                ProductCRUD.adduser(p, products);
                                Console.ReadKey();

                            }
                            else if (optionadmin == 2)
                            {
                                ProductCRUD.viewproduct(products);
                                Console.ReadKey();
                            }
                            else if (optionadmin == 3)
                            {
                                ProductCRUD.highestprice(products);
                                Console.ReadKey();
                            }
                            else if (optionadmin == 4)
                            {
                                ProductCRUD.salestax(products);
                                Console.ReadKey();
                            }
                            else if (optionadmin == 5)
                            {
                                ProductCRUD.productstoorder(products);
                                Console.ReadKey();
                            }
                            else if (optionadmin == 6)
                            {
                                break;
                            }
                        }
                        while (optionadmin < 7);
                        Console.ReadKey();


                    }
                    else if (flag == true && !user.IsAdmin())
                    {
                        Console.WriteLine("Valid User");
                        Console.WriteLine("Welcome as a Customer");
                        Console.ReadKey();
                        do
                        {
                            Console.Clear();
                            optioncustomer = menucustomer();
                            Console.Clear();
                            if (optioncustomer == 1)
                            {
                                ProductCRUD.viewproduct(products);
                                Console.ReadKey();
                            }
                            else if (optioncustomer == 2)
                            {
                                CustomerUI.addtocart(products, customerproducts);                             
                                Console.ReadKey();

                            }
                            else if (optioncustomer == 3)
                            {
                                CustomerCRUD.generateInvoice(customerproducts);
                                Console.ReadKey();
                            }
                            else if (optioncustomer == 4)
                            {
                                break;
                            }

                        }
                        while (optioncustomer < 5);
                        Console.ReadKey();

                    }

                    else if (flag == false)
                    {
                        Console.WriteLine("Invalid User");
                        Console.ReadKey();
                    }
                }
                if (option == 3)
                {
                    break;
                }
            }
            while (option < 4);
            Console.Read();

           
        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Sign In");
            Console.WriteLine("3.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static int menuadmin()
        {
            int option;
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Find product with highest price");
            Console.WriteLine("4. View sales tax of all products");
            Console.WriteLine("5. Products to be ordered");
            Console.WriteLine("6. Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static int menucustomer()
        {
            int option;
            Console.WriteLine("1. View all the products");
            Console.WriteLine("2. Buy the products");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4 .Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
