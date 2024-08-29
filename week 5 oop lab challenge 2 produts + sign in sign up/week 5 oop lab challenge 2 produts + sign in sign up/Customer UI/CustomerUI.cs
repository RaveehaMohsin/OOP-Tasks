using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_BL;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_UI
{
    public class CustomerUI
    {
        public static void addtocart(List<Product> products,List<Product> customers)
        {
            
            Console.WriteLine("Enter how many products you want to add");
            int n = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < n; idx++)
            {
                Console.WriteLine("Enter the name of your Product");
                string customernameofp = Console.ReadLine();
                for (int x = 0; x < products.Count; x++)
                {
                    if (customernameofp == products[x].nameofproduct)
                    {
                        products[x].availablestock--;
                        Product o = products[x];
                        customers.Add(o);
                    }
                }

            }
            

        }
    }
}
