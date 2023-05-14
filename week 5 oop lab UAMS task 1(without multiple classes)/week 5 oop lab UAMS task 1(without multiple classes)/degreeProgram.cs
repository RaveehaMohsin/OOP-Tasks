using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_UAMS_task_1_without_multiple_classes_
{
    public class degreeProgram
    {
        public string degreeName;
        public int degreeDuration;
        public int seats;
        public List<Subject> subjects;

        public degreeProgram()
        {

        }
        public degreeProgram(string name , int duration , int seats)
        {
            this.degreeName = name;
            this.degreeDuration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public int calculatecredithours()
        {
            int count = 0;
            for (int idx = 0; idx < subjects.Count; idx ++)
            {
                count = count + subjects[idx].credithours;
            }
            return count;
        }

        public bool addsubject(Subject s)
        {
            int ch = calculatecredithours();
            if(ch + s.credithours <= 20)
            {
                subjects.Add(s);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool isSubjectexists(Subject sub)
        {
            for (int idx = 0; idx < subjects.Count; idx++)
            {
                if (subjects[idx].subjectcode == sub.subjectcode)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
