using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_task_1.BL_LINE;
using week_5_oop_lab_task_1.UI_LINE;

namespace week_5_oop_lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Line l = new Line();
            lineUI l1 = new lineUI();
            MyPoint b = new MyPoint();
            MyPoint e = new MyPoint();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if(option == 1)
                {
                    l = lineUI.takeinput();
                    Console.ReadKey();

                }
                if (option == 2)
                {
                    l1.takeinputforbegin(l);
                    Console.ReadKey();
                }
                if (option == 3)
                {

                    l1.takeinputforend(l);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    Console.WriteLine("Your beginning coordinates are : ");
                    //Console.WriteLine(l.getbegin());
                    Console.WriteLine("X coordinate : ");
                    Console.WriteLine(l.begin.x);
                    Console.WriteLine("y coordinate : ");
                    Console.WriteLine(l.begin.y);
                    Console.ReadKey();
                }
                if(option == 5)
                {   
                    Console.WriteLine("Your end coordinates are : ");
                    //Console.WriteLine(l.getbegin());
                    Console.WriteLine("X coordinate : ");
                    Console.WriteLine(l.end.x);
                    Console.WriteLine("y coordinate : ");
                    Console.WriteLine(l.end.y);
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    double length = 0;
                    Console.WriteLine("The length of your line is :");
                    length = l.getlength();
                    Console.WriteLine(length);
                    Console.ReadKey();
                }
                if (option == 7)
                {
                    double lengthg = 0;
                    Console.WriteLine("The gradient of your line is :");
                    lengthg = l.getgradient();
                    Console.WriteLine(lengthg);
                    Console.ReadKey();
                }
                if (option == 8)
                {
                    double answer;
                    answer = l.getlengthbegin();
                    Console.WriteLine("Distance of begin point with zero coordinate :  ");
                    Console.Write(answer);
                    Console.ReadKey();
                }
                if (option == 9)
                {
                    double answer1;
                    answer1 = l.getlengthend();
                    Console.WriteLine("Distance of end point with zero coordinate :  ");
                    Console.Write(answer1);
                    Console.ReadKey();

                }
                if (option == 10)
                {
                    break;
                }    

            }
            while (option < 10);
            Console.ReadLine();
        }

        static int menu()
        {
            int option;
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the begin point");
            Console.WriteLine("3. Update the end point");
            Console.WriteLine("4. Show the begin Point");
            Console.WriteLine("5. Show the end point");
            Console.WriteLine("6. Get the Length of the line");
            Console.WriteLine("7. Get the Gradient of the Line");
            Console.WriteLine("8. Find the distance of begin point from zero coordinates");
            Console.WriteLine("9. Find the distance of end point from zero coordinates");
            Console.WriteLine("10. Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
