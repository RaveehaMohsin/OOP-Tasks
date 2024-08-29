using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.product_bl
{
    public class Product
    {
        public string nameofproduct;
        public string productcategory;
        public float productprice;
        public int availablestock;
        public int minstockquantity;

        public Product()
        {

        }
        public Product(string name, string category, float price, int availablestock, int min)
        {
            this.nameofproduct = name;
            this.productcategory = category;
            this.productprice = price;
            this.availablestock = availablestock;
            this.minstockquantity = min;
        }
    }
}
