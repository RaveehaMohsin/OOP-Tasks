using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;
using Week_5_UAMS__BL___DL___UI_.subject_DL;

namespace Week_5_UAMS__BL___DL___UI_.degreeProgram_DL
{
    public  class degreeProgramCRUD
    {
        public static List<degreeProgram> programs = new List<degreeProgram>();


        public static void addintodegreelist(degreeProgram d)
        {
            programs.Add(d);
        }

        public static void storeintofile(string path, degreeProgram d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string subjectnames = "";
            for (int idx = 0; idx < d.subjects.Count -1; idx++)
            {
                subjectnames = subjectnames + d.subjects[idx].subjecttype + ";";

            }
            subjectnames = subjectnames + d.subjects[d.subjects.Count - 1].subjecttype;
            f.WriteLine(d.degreeName + "," + d.degreeDuration + "," + d.seats + "," + subjectnames);
            f.Flush();
            f.Close();

        }

        public static bool readfromfile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreename = splittedRecord[0];
                    int degreeduration = int.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    degreeProgram d = new degreeProgram(degreename, degreeduration, seats);
                    string[] splittedrecordforsubject = splittedRecord[3].Split(';');
                    for (int x = 0; x < splittedrecordforsubject.Length; x++)
                    {
                        subject s = subjectCRUD.issubjectexists(splittedrecordforsubject[x]);
                        if(s != null)
                        {
                            d.addsubject(s);
                        }
                    }
                    addintodegreelist(d);
                    
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static degreeProgram isdegreeexists(string name)
        {
            foreach (degreeProgram d  in programs)
            {
                if (name == d.degreeName)
                {
                    return d;
                }
            }
            return null;
        }
    }
}
