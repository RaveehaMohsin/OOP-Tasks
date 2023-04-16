using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            students s1 = new students();
            s1.name = "Raveeha";
            s1.rollno = 149;
            s1.cgpa = 3.8F;
            Console.WriteLine("Name = {0} , Roll No = {1} , CGPA = {2}", s1.name, s1.rollno, s1.cgpa);
            Console.ReadKey();
            students s2 = new students();
            s2.name = "Tayyaba";
            s2.rollno = 134;
            s2.cgpa = 3.8F;
            Console.WriteLine("Name = {0} , Roll No = {1} , CGPA = {2}", s2.name, s2.rollno, s2.cgpa);
            Console.ReadKey();

            students s3 = new students();
            s3.name = "Fatima";
            s3.rollno = 152;
            s3.cgpa = 3.8F;
            Console.WriteLine("Name = {0} , Roll No = {1} , CGPA = {2}", s3.name, s3.rollno, s3.cgpa);
            Console.ReadKey();

            students s4 = new students();
            Console.WriteLine("Enter your name : ");
            s4.name =  Console.ReadLine();
            Console.WriteLine("Enter your rollno : ");
            s4.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your cgpa : ");
            s4.cgpa = float.Parse (Console.ReadLine());
            Console.WriteLine("Name = {0} , Roll No = {1} , CGPA = {2}", s4.name, s4.rollno, s4.cgpa);
            Console.ReadKey();




        }
    }
}
