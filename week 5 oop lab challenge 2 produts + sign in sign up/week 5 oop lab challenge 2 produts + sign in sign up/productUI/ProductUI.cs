using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.productUI
{
    public class ProductUI
    {
        public static Product Addproduct()
        {
            Console.WriteLine("Enter the name of the product : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category of the product : ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter the price of the product : ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity of the available stock : ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum quantity of a stock : ");
            int min = int.Parse(Console.ReadLine());

            Product p = new Product(name, category, price, quantity, min);
            return p;

        }
    }
}
