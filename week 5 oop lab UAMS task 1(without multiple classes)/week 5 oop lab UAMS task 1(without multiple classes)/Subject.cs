using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_UAMS_task_1_without_multiple_classes_
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
        public Subject(string code , string type , int ch ,int fees)
        {
            this.subjectcode = code;
            this.subjecttype = type;
            this.credithours = ch;
            this.subjectfees = fees;
        }
    }
}
