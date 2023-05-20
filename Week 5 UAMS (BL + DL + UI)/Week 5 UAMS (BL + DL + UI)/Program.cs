using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_DL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_UI;
using Week_5_UAMS__BL___DL___UI_.menu_UI;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Student_DL;
using Week_5_UAMS__BL___DL___UI_.student_UI;
using Week_5_UAMS__BL___DL___UI_.subject_DL;
using Week_5_UAMS__BL___DL___UI_.subject_UI;

namespace Week_5_UAMS__BL___DL___UI_
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            string subjectpath = "D:\\OOP 2nd Semester\\Week 5 UAMS (BL + DL + UI)\\subject.txt";
            string degreepath = "D:\\OOP 2nd Semester\\Week 5 UAMS (BL + DL + UI)\\degree.txt";
            string studentpath = "D:\\OOP 2nd Semester\\Week 5 UAMS (BL + DL + UI)\\student.txt";
            if(subjectCRUD.readfromfile(subjectpath))
            {
                Console.WriteLine("Subject Data Loaded Successfully!");
            }
            if (degreeProgramCRUD.readfromfile(degreepath))
            {
                Console.WriteLine("Degree Data Loaded Successfully!");
            }
            if (studentCRUD.readfromfile(studentpath))
            {
                Console.WriteLine("Student Data Loaded Successfully!");
            }
            int option;
            do
            {
                Console.Clear();
                option = menuUI.menu();
                Console.Clear();
                if (option == 1)
                {
                    if (degreeProgramCRUD.programs.Count > 0)
                    {
                        student s = studentUI.takeinputforstudent();
                        studentCRUD.addintostudentlist(s );
                        studentCRUD.storeintofile(studentpath,s);

                        Console.ReadKey();
                    }

                }
                else if (option == 2)
                {
                    degreeProgram d = degreeProgramUI.takeinputfordegree();
                    degreeProgramCRUD.addintodegreelist(d );
                    degreeProgramCRUD.storeintofile(degreepath, d);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    List<student> sortedstudentlist = new List<student>();
                    sortedstudentlist = studentCRUD.sortstudentsbymerit();
                    studentCRUD.giveadmission(sortedstudentlist);
                    studentUI.printstudent();
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    studentUI.viewregisteredstudents();
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    string degree;
                    Console.WriteLine("Enter the degree name : ");
                    degree = Console.ReadLine();
                   studentUI.viewstudentindegree(degree);
                    Console.ReadKey();

                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter the student name : ");
                    string name = Console.ReadLine();
                    student s = studentCRUD.studentpresent(name);
                    if (s != null)
                    {
                       subjectUI.viewsubjects(s);
                       subjectUI.registersubjects(s);

                    }
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    studentUI.Calculatefee();
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
    }
}
