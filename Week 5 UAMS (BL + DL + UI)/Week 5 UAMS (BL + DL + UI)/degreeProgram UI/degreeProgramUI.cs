using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.student_UI;
using Week_5_UAMS__BL___DL___UI_.subject_UI;

namespace Week_5_UAMS__BL___DL___UI_.degreeProgram_UI
{
    public class degreeProgramUI
    {
        public static degreeProgram takeinputfordegree()
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
                obj.addsubject(subjectUI.takeinputforsubject());
            }
            return obj;

        }
        public static void viewdegreePrograms(List<degreeProgram> programs)
        {
            for (int idx = 0; idx < programs.Count; idx++)
            {
                Console.WriteLine(programs[idx].degreeName);
            }
        }

    }
}
