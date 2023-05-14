using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_dl
{
    public class ProductCRUD
    {
        public static void adduser(Product p , List<Product> products)
        {
            products.Add(p);
        }
        public static void viewproduct(List<Product> products)
        {
            for (int idx = 0; idx < products.Count; idx ++)
            {
                Console.WriteLine("Name of product : " + products[idx].nameofproduct + " Category of product : " + products[idx].productcategory + " Price of Prdouct : " + products[idx].productprice + " Quantity of Product : " + products[idx].availablestock + " Minimum Stock : " + products[idx].minstockquantity);
            }
        }

        public static void highestprice(List<Product> products)
        {
            float largest = 0;
            string large1 = " ";
            for(int idx = 0; idx < products.Count; idx++)
            {
                if (largest < products[idx].productprice)
                {
                    largest = products[idx].productprice;
                    large1 = products[idx].nameofproduct;
                }

            }
            Console.WriteLine("The highest price is of the product " + large1 + " with the price " + largest);
        }

        public static void salestax(List<Product> products)
        {
            
            for (int idx = 0; idx < products.Count; idx++)
            {
                double tax = 0;
                if (products[idx].productcategory == "grocery")
                {
                    tax  = (products[idx].productprice * 0.1) + products[idx].productprice;
                }
                else if (products[idx].productcategory == "fruit")
                {
                    tax = (products[idx].productprice * 0.5) + products[idx].productprice;
                }
                else
                {
                    tax = (products[idx].productprice * 0.15) + products[idx].productprice;
                }

                Console.WriteLine("Sales tax on the product " + products[idx].nameofproduct + " is " + tax);

            }

        }

        public static void productstoorder(List<Product> products)
        {
            for (int idx = 0; idx < products.Count; idx++)
            {
                if (products[idx].availablestock <= products[idx].minstockquantity)
                {
                    Console.WriteLine("Product " + products[idx].nameofproduct + " is ON THE ORDER LIST");
                }
                else
                {
                    Console.WriteLine(" Enough stock of the Product " + products[idx].nameofproduct);
                }
            }
        }


    }

}
