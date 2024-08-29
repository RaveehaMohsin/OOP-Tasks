using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop__Business_Application__with__BL__DL___UI_.Muser_BL
{
    public class Muser
    {
        public string currentlocation;
        public string desiredlocation;

        public Muser()
        {

        }
        public Muser(string currentlocation, string desiredlocation)
        {
            this.currentlocation = currentlocation;
            this.desiredlocation = desiredlocation;
        }
    }
}
