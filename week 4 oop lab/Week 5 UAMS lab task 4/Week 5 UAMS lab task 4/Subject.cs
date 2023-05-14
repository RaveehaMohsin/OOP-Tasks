using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS_lab_task_4
{
    public class Subject
    {
        public string subjectcode;
        public string subjecttype;
        public int credithours;
        public int subjectfees;

        public Subject()
        {

        }
        public Subject(string sc, string st, int ch, int fees)
        {
            this.subjectcode = sc;
            this.subjecttype = st;
            this.credithours = ch;
            this.subjectfees = fees;
        }
    }
}
