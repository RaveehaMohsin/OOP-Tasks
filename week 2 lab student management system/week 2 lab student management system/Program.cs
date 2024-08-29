using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_lab_student_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] s = new Students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addstudent();
                    count++;
                }
                else if (option == '2')
                {
                    viewstudents(s, count);
                }
                else if (option == '3')
                {
                    topstudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (option != 4);

            Console.WriteLine("Press enter to exit:");
            Console.Read();

        }

        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 To Add a Student");
            Console.WriteLine("Press 2 To View Students");
            Console.WriteLine("Press 3 For three Top Students");
            Console.WriteLine("Press 4 to Exit ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static Students addstudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.WriteLine("Enter your Name : ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter your Roll No : ");
            s1.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your CGPA : ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Department: ");
            s1.department = Console.ReadLine();
            Console.WriteLine("Hostelide (y/n) : ");
            s1.hostelide = char.Parse(Console.ReadLine());
            return s1;

        }

        static void viewstudents(Students[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name = {0} , Roll No = {1} , CGPA = {2} , Department = {3} , Hostelide = {4} ", s[i].name, s[i].rollno, s[i].cgpa, s[i].department, s[i].hostelide);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        static int largest(Students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int i = start; i < end; i++)
            {
                if (large < s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;

        }

        static void topstudent(Students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present");
            }
            else if (count == 1)
            {
                viewstudents(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;

                }
                viewstudents(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;

                }
                viewstudents(s, 3);

            }

        }



    }
}
