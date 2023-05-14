using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_sorting
{
    class Program
    {
        class student
        {
            public string name;
            public int roll;
            public int fscmarks;

            public student(string name , int roll , int fscmarks)
            {
                this.name = name;
                this.roll = roll;
                this.fscmarks = fscmarks;
            }

        }
        static void Main(string[] args)
        {
            student s1 = new student("Raveeha", 11, 123);
            student s2 = new student("tayyaba", 12, 126);
            student s3 = new student("hadia", 10, 121);

            List<student> studentlist = new List<student>() { s1, s2, s3 };
            List<student> sortedlist = studentlist.OrderBy(o => o.name).ToList();
            Console.WriteLine("Name      RollNo     FscMarks");
            foreach(student s in sortedlist)
            {
                Console.WriteLine("{0}      {1}     {2}", s.name, s.roll, s.fscmarks); 
            }

            Console.Read();


        }
    }
}
