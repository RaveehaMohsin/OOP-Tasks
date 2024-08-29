using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_task_1.BL_LINE;
using week_5_oop_lab_task_1.UI;

namespace week_5_oop_lab_task_1.UI_LINE
{
    public class lineUI
    {
        public static Line takeinput()
        {
            
            Console.WriteLine("Begin");
            Console.WriteLine("Enter coordinates");
            MyPoint begin = pointUI.takeinput();
            Console.WriteLine("End");
            Console.WriteLine("Enter coordinates");
            MyPoint end = pointUI.takeinput();

            Line  l = new Line(begin, end);
            return l;

        }
        public void takeinputforbegin(Line l)
        {
            
            Console.WriteLine("Begin points Update");
            Console.WriteLine("Enter coordinates");
            MyPoint begin = pointUI.takeinput();

            
            l.setbegin(begin);
   
        }
        public void takeinputforend(Line l)
        {

            Console.WriteLine("End points Update");
            Console.WriteLine("Enter coordinates");
            MyPoint end = pointUI.takeinput();


            l.setend(end);

        }

       
       
        


    }
}