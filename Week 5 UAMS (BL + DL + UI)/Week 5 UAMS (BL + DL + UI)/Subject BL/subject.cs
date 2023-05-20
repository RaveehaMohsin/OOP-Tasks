using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS__BL___DL___UI_.Subject_BL
{
    public class subject
    {

        public string subjectcode;
        public string subjecttype;
        public int credithours;
        public int subjectfees;

        public subject()
        {

        }
        public subject(string code, string type, int ch, int fees)
        {
            this.subjectcode = code;
            this.subjecttype = type;
            this.credithours = ch;
            this.subjectfees = fees;
        }
    }
}
