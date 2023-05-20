using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;

namespace Week_5_UAMS__BL___DL___UI_.subject_DL
{
    public class subjectCRUD
    {
        public static List<subject> subjectlist = new List<subject>();

        public static void addSubjectIntoList(subject s)
        {
            subjectlist.Add(s);
        }
       

        public static void storeintofile(string path , subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.subjectcode + "," + s.subjecttype + "," + s.credithours + "," + s.subjectfees);
            f.Flush();
            f.Close();

        }

        public static bool readfromfile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int credit = int.Parse(splittedRecord[2]);
                    int fees = int.Parse(splittedRecord[3]);
                    subject s = new subject(code, type, credit, fees);
                    addSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static subject issubjectexists(string name)
        {
            foreach(subject s in subjectlist)
            {
                if(name == s.subjecttype)
                {
                    return s;
                }
            }
            return null;
        }


        
    }
}
