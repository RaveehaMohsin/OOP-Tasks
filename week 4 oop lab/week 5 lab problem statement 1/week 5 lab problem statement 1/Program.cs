using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_lab_problem_statement_1
{
    class Program
    {
        public class student
        {
            public student()
            {

            }
            public student(string name, int rollnumber, float cgpa, int matricmarks, float fscmarks, float ecatmarks , string hometown , bool hostelide , bool takingscholarship)
            {
                this.name = name;
                this.rollnumber = rollnumber;
                this.cgpa = cgpa;
                this.matricmarks = matricmarks;
                this.fscmarks = fscmarks;
                this.ecatmarks = ecatmarks;
                this.hometown = hometown;
                this.hostelide = hostelide;
                this.takingscholarship = takingscholarship;
            }

            public float calculatemerit()
            {
                
                merit = ((fscmarks * 60.0F) / 100.0F) + ((ecatmarks * 40.0F) / 100.0F);
                
                return merit;

            }

            public bool iselegible()
            {
                bool flag = true;
                if (merit > 80.0 && hostelide == true)
                {
                    flag = true;

                }
                else
                {
                    flag = false;
                }

                return flag;

            }

            public student info()
            {

                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter roll : ");
                int rollno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter CGPA : ");
                float cgpa = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Matric Marks : ");
                int mm = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fsc Marks : ");
                int fsc = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ecat Marks : ");
                int ecat = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hometown : ");
                string hometown = Console.ReadLine();
                Console.WriteLine("Enter true/flase for hostelide : ");
                bool hostelide = bool.Parse(Console.ReadLine());
                Console.WriteLine("Enter true/false for taking scholarship : ");
                bool takingscholarship = bool.Parse(Console.ReadLine());

                student s = new student(name, rollno, cgpa, mm, fsc, ecat, hometown, hostelide, takingscholarship);
                return s;

            }

            public int menu()
            {
                int option;
                Console.WriteLine("1.Enter your info ");
                Console.WriteLine("2.Calculate Merit");
                Console.WriteLine("3.Is eligible");
               option = int.Parse(Console.ReadLine());

                return option;
            }
            public string name;
            public int rollnumber;
            public float cgpa;
            public int matricmarks;
            public float fscmarks;
            public float ecatmarks;
            public string hometown;
            public bool hostelide;
            public bool takingscholarship;
            public float merit;

        }
            

        static void Main(string[] args)
        {
            student m = new student();
            List<student> students = new List<student>();
            
            
            int option = 0;
            
            do
            {
                Console.Clear();
                 option = m.menu();
                Console.Clear();

                if (option == 1)
                {
                    m = m.info();
                    students.Add(m);
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    for (int idx = 0; idx < students.Count; idx++)
                    {
                        m.merit = students[idx].calculatemerit();

                        Console.WriteLine("Your merit is : " + m.merit);
                    }
                    //m.merit = m.calculatemerit();
                    //Console.WriteLine("Your merit is : " + m.merit);  can do like this too for a single student

                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    for (int idx = 0; idx < students.Count; idx++)
                    {
                        bool flag = students[idx].iselegible();
                        if (flag == true)
                        {
                            Console.WriteLine("You are eligible for scholarship");
                        }
                        else
                        {
                            Console.WriteLine("You are NOT eligble for scholarship");
                        }
                    }
                    Console.ReadKey();

                }
            }
            while (option < 4);
            Console.Read();



        }
    }
}
