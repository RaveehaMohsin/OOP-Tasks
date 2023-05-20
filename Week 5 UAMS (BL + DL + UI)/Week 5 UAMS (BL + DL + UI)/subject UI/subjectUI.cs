using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;

namespace Week_5_UAMS__BL___DL___UI_.subject_UI
{
    public class subjectUI
    {
        public static subject takeinputforsubject()
        {
            Console.WriteLine("Enter Subject code : ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter subject type : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter subject credit hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter suject fees : ");
            int fees = int.Parse(Console.ReadLine());
            subject s = new subject(code, type, hours, fees);
            return s;
        }

       public static void registersubjects(student s)
        {
            Console.WriteLine("How many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int idx = 0; idx < count; idx++)
            {
                Console.WriteLine("Enter the subject code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (subject sub in s.regDegree.subjects)
                {
                    if (code == sub.subjectcode && !(s.regsubjects.Contains(sub)))
                    {
                        if(s.regStudentSub(sub))
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student can not have more than 9CH");
                            flag = true;
                            break;
                        }
                       


                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid course");
                    idx--;
                }
            }

        }
        public static void viewsubjects(student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code    Sub Type");
                foreach (subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.subjectcode + "      " + sub.subjecttype);
                }
            }
        }
    }
}
