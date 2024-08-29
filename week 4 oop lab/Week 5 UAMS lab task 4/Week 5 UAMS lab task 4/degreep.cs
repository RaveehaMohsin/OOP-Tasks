using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS_lab_task_4
{
    public class DegreeProgram
    {
        public string degreetitle;
        public int degreeduration;
        public int seats;
        public List<Subject> subjects = new List<Subject>();

        public DegreeProgram()
        {

        }
        public DegreeProgram(string dg, int dd, int seats, List<Subject> subjects)
        {
            this.degreetitle = dg;
            this.degreeduration = dd;
            this.seats = seats;
            this.subjects = subjects;
        }
    }
}
