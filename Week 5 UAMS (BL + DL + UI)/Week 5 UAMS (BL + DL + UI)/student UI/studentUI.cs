using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_DL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_UI;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Student_DL;

namespace Week_5_UAMS__BL___DL___UI_.student_UI
{
   public class studentUI
    {
        public static student takeinputforstudent()
        {
            List<degreeProgram> preferences = new List<degreeProgram>();
            Console.WriteLine("Enter Student name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student's age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC marks : ");
            double fsc = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student ECAT marks : ");
            double ecat = double.Parse(Console.ReadLine());

            Console.WriteLine("Available degree Programs : ");
            degreeProgramUI.viewdegreePrograms(degreeProgramCRUD.programs);
            Console.WriteLine("Enter how many prefences you want to add");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count; idx++)
            {
                string degname = Console.ReadLine();
                bool flag = false;
                foreach (degreeProgram dp in degreeProgramCRUD.programs)
                {
                    if (degname == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }

                }
                if (flag == false)
                {
                    Console.WriteLine("Invalid degree Program!!!");
                    idx--;

                }

            }
            student s = new student(name, age, fsc, ecat, preferences);
            return s;


        }

        public static void printstudent()
        {
            foreach (student s in studentCRUD.studentlist)
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

        public static void viewstudentindegree(string degrename)
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (student s in studentCRUD.studentlist)
            {
                if (s.regDegree != null)
                {
                    if (degrename == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);
                    }
                }
            }

        }
        public static void viewregisteredstudents()
        {
            Console.WriteLine("Name    Fsc      Ecat    Age  ");
            foreach (student s in studentCRUD.studentlist)
            {
                if (s.regDegree != null)
                {

                    Console.WriteLine(s.name + "  " + s.fscmarks + "  " + s.ecatmarks + "  " + s.age);

                }
            }

        }
        public static void Calculatefee()
        {
            foreach (student s in studentCRUD.studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.calculatefee() + " fees ");
                }
            }
        }
    }
}
