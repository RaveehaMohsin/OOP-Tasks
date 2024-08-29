using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_dl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Customer_DL
{
    public class CustomerCRUD
    {
       public static void generateInvoice(List<Product> customerproducts)
        {
            float bill = 0;
           
            double taxbill = 0;
            
            for (int idx = 0; idx < customerproducts.Count; idx ++)
            {
                double tax = 0;
                Console.WriteLine( customerproducts[idx].nameofproduct );

                Console.WriteLine( "Your price of the product " + customerproducts[idx].nameofproduct + " is "+customerproducts[idx].productprice);
                
                    if (customerproducts[idx].productcategory == "grocery")
                    {
                        tax = (customerproducts[idx].productprice * 0.1) + customerproducts[idx].productprice;
                    }
                    else if (customerproducts[idx].productcategory == "fruit")
                    {
                        tax = (customerproducts[idx].productprice * 0.5) + customerproducts[idx].productprice;
                    }
                    else
                    {
                        tax = (customerproducts[idx].productprice * 0.15) + customerproducts[idx].productprice;
                    }

                    Console.WriteLine("Sales tax on the product" + customerproducts[idx].nameofproduct + " is " + tax);

                
                bill = bill + customerproducts[idx].productprice;
                taxbill = taxbill + tax;
                
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Your total bill is : " + bill);
            Console.WriteLine("______________________________");
            Console.WriteLine("Your total bill with tax is : " + taxbill);
            Console.WriteLine("-------------------------------");

        }


           
        
    }
}
