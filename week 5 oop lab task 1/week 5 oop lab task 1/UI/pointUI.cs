using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_task_1.UI
{
    public class pointUI
    {
        public static MyPoint takeinput()
        {
            Console.WriteLine("Enter the x coordinates : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y coordinates : ");
            int y = int.Parse(Console.ReadLine());

            MyPoint p = new MyPoint(x, y);
            return p;
        }
    }
}
