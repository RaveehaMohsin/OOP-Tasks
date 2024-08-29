using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS_lab_task_4
{
    class Program
    {
        static List<DegreeProgram> programlist = new List<DegreeProgram>();
        static List<Student> studentlist = new List<Student>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    if (programlist.Count > 0)
                    {
                        Student s = addstudent();
                        studentlist.Add(s);
                    }
                }

                if (option == 2)
                {
                    DegreeProgram d = adddegree();
                    programlist.Add(d);
                }
                if (option == 3)
                {
                    generatemeritlist();
                    Console.ReadKey();
                }

                if (option == 8)
                {
                    break;
                }

            }
            while (option < 9);
            Console.Read();
        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View registered students");
            Console.WriteLine("5.View Students of a specific program");
            Console.WriteLine("6.Register Subjects for a specific student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter your option:");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static DegreeProgram adddegree()
        {
            List<Subject> subjects = new List<Subject>();
            Console.WriteLine("Enter the degree title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the degree duration");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats in this degree program");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects you want to add in this degree program");
            int sub = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < sub; idx++)
            {
                Subject s = addsubject();
                subjects.Add(s);
            }
            DegreeProgram obj = new DegreeProgram(title, duration, seats, subjects);
            return obj;

        }

        static Student addstudent()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fsc marks");
            float fscm = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ecat marks");
            float ecatm = float.Parse(Console.ReadLine());
            for (int idx = 0; idx < programlist.Count; idx++)
            {
                Console.WriteLine(programlist[idx].degreetitle);
            }
            Console.WriteLine("Enter how many prefernces you want to add");
            int prefernce = int.Parse(Console.ReadLine());
            List<DegreeProgram> prefernces = new List<DegreeProgram>();
            for (int idx = 0; idx < prefernce; idx++)
            {
                DegreeProgram d = new DegreeProgram();
                string degreename = Console.ReadLine();
                d.degreetitle = degreename;
                prefernces.Add(d);

            }

            Student s = new Student(name, age, fscm, ecatm, prefernces);
            return s;
        }

        static Subject addsubject()
        {
            Console.WriteLine("Enter the subject code:");
            string sc = Console.ReadLine();
            Console.WriteLine("Enter the subject type");
            string st = Console.ReadLine();
            Console.WriteLine("Enter the subject credit hours");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fees");
            int fees = int.Parse(Console.ReadLine());

            Subject s = new Subject(sc, st, ch, fees);
            return s;
        }

        static void generatemeritlist()
        {
            Student s = new Student();
            float merit = s.calculatemerit();
            for (int idx = 0; idx < studentlist.Count; idx ++)
            {
                if (merit > 80)
                {
                    Console.WriteLine(studentlist[idx].name + " got admission in " );
                }
                else
                {
                    Console.WriteLine(studentlist[idx].name + " did not get admission");
                }
            }
        }

    }
}