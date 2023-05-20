using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;

namespace Week_5_UAMS__BL___DL___UI_.degreeProgram_BL
{
    public class degreeProgram
    {
        public string degreeName;
        public int degreeDuration;
        public int seats;
        public List<subject> subjects;

        public degreeProgram()
        {

        }
        public degreeProgram(string name, int duration, int seats)
        {
            this.degreeName = name;
            this.degreeDuration = duration;
            this.seats = seats;
            subjects = new List<subject>();
        }

        public int calculatecredithours()
        {
            int count = 0;
            for (int idx = 0; idx < subjects.Count; idx++)
            {
                count = count + subjects[idx].credithours;
            }
            return count;
        }

        public bool addsubject(subject s)
        {
            int ch = calculatecredithours();
            if (ch + s.credithours <= 20)
            {
                subjects.Add(s);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool isSubjectexists(subject sub)
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
