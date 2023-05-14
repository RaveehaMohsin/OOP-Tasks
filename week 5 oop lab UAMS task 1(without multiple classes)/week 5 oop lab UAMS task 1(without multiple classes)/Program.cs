using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_UAMS_task_1_without_multiple_classes_
{
    public class Program
    {
        static List<Student> studentlist = new List<Student>();
        static List<degreeProgram> programs = new List<degreeProgram>();

        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if(option == 1)
                {
                    if(programs.Count > 0)
                    {
                        Student s = takeinputforstudent();
                        addintostudentlist(s);
                        Console.ReadKey();
                    }

                }
                else if (option == 2)
                {
                    degreeProgram d = takeinputfordegree();
                    addintodegreelist(d);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    List<Student> sortedstudentlist = new List<Student>();
                    sortedstudentlist = sortstudentsbymerit();
                    giveadmission(sortedstudentlist);
                    printstudent();
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    viewregisteredstudents();
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    string degree;
                    Console.WriteLine("Enter the degree name : ");
                    degree = Console.ReadLine();
                    viewstudentindegree(degree);
                    Console.ReadKey();


                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the student name : ");
                    string name = Console.ReadLine();
                   Student s = studentpresent(name);
                    if(s != null)
                    {
                        viewsubjects(s);
                        registersubjects(s);
                        
                    }
                    Console.ReadKey();



                }
                else if (option == 7)
                {
                    Calculatefee();
                    Console.ReadKey();
                }
                else if (option == 8)
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
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Add degree program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View registered students");
            Console.WriteLine("5. View students of a specific program");
            Console.WriteLine("6. Register subjects for a specific student");
            Console.WriteLine("7. Calculates fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void viewdegreePrograms()
        {
            for (int idx = 0; idx < programs.Count; idx ++)
            {
                Console.WriteLine(programs[idx].degreeName);
            }
        }

        static void viewsubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code    Sub Type");
               foreach(Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.subjectcode + "      " + sub.subjecttype);
                }
            }
        }

        static Student takeinputforstudent()
        {
            List<degreeProgram> preferences = new List<degreeProgram>();
            Console.WriteLine("Enter Student name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student's age " );
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC marks : ");
            double fsc = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student ECAT marks : ");
            double ecat = double.Parse(Console.ReadLine());

            Console.WriteLine("Available degree Programs : ");
            viewdegreePrograms();
            Console.WriteLine("Enter how many prefences you want to add");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count; idx ++)
            {
                string degname = Console.ReadLine();
                bool flag = false;
                foreach(degreeProgram dp in programs)
                {
                    if (degname == dp.degreeName && !(preferences.Contains(dp)))
                    { 
                        preferences.Add(dp);
                        flag = true;
                    }

                }
                if (flag == false )
                {
                    Console.WriteLine("Invalid degree Program!!!");
                    idx--;

                }

            }
            Student s = new Student(name, age, fsc, ecat, preferences);
            return s;


        }

        static Subject takeinputforsubject()
        {
            Console.WriteLine("Enter Subject code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter subject type : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter subject credit hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter suject fees : ");
            int fees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, hours, fees);
            return s;
        }

        static void addintostudentlist(Student s)
        {
            studentlist.Add(s);
        }

        static void addintodegreelist(degreeProgram d)
        {
            programs.Add(d);
        }

        static degreeProgram takeinputfordegree()
        {
          
            Console.WriteLine("Enter the degree title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the degree duration");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats in this degree program");
            int seats = int.Parse(Console.ReadLine());
            degreeProgram obj = new degreeProgram(title, duration, seats);
           
            Console.WriteLine("Enter how many subjects you want to add in this degree program");
            int sub = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < sub; idx++)
            {
                obj.addsubject(takeinputforsubject());
            }
            return obj;

        }

        static Student studentpresent(string name )
        {
            foreach(Student s in studentlist)
            {
                if(name == s.name && s.regDegree!= null)
                {
                    return s;
                }
            }
            return null;
        }

        static void Calculatefee()
        {
            foreach(Student s in studentlist)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.calculatefee() + " fees ");
                }
            }
        }

        static List<Student> sortstudentsbymerit()
        {
            List<Student> sortedstudentlist = new List<Student>();
            foreach(Student s in studentlist)
            {
                s.calculatemerit();
            }
            sortedstudentlist = studentlist.OrderByDescending(o => o.merit).ToList();
            return sortedstudentlist;

        }

        static void giveadmission( List<Student> sortedstudentlist)
        {
            foreach(Student s in sortedstudentlist)
            {
                foreach(degreeProgram d in s.preferences)
                {
                    if(d.seats > 0 && s.regDegree == null)
                    {
                       s.regDegree = d;
                        d.seats --;
                        break;
                    }
                }
            }

        }

        static void printstudent()
        {
            foreach ( Student s in studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " got admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get admission!");
                }
            }
             
        }

        static void viewstudentindegree(string degrename)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach(Student s in studentlist)
            {
                if(s.regDegree != null)
                {
                    if(degrename == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);
                    }
                }
            }
        
        }

        static void viewregisteredstudents()
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (Student s in studentlist)
            {
                if (s.regDegree != null)
                {      
                    
                  Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);
                    
                }
            }

        }

        static void registersubjects(Student s)
        {
            Console.WriteLine("How many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count;idx++)
            {
                Console.WriteLine("Enter the subject code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject sub in s.regDegree.subjects)
                {
                    if(code == sub.subjectcode && !(s.regsubjects.Contains(sub)))
                    {
                        s.regStudentSub(sub);
                        flag = true;
                        break;


                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter valid course");
                    idx--;
                }
            }

        }



    }
}
