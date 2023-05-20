using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_BL;
using Week_5_UAMS__BL___DL___UI_.degreeProgram_DL;
using Week_5_UAMS__BL___DL___UI_.Student_BL;
using Week_5_UAMS__BL___DL___UI_.Subject_BL;
using Week_5_UAMS__BL___DL___UI_.subject_DL;

namespace Week_5_UAMS__BL___DL___UI_.Student_DL
{
    public class studentCRUD
    {
        public static List<student> studentlist = new List<student>();
        public static void addintostudentlist(student s )
        {
            studentlist.Add(s);
        }

         public static student studentpresent(string name)
         {
            foreach (student s in studentlist)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
         }


        public static List<student> sortstudentsbymerit()
        {
            List<student> sortedstudentlist = new List<student>();
            foreach (student s in studentlist)
            {
                s.calculatemerit();
            }
            sortedstudentlist = studentlist.OrderByDescending(o => o.merit).ToList();
            return sortedstudentlist;

        }

        public static void giveadmission(List<student> sortedstudentlist)
        {
            foreach (student s in sortedstudentlist)
            {
                foreach (degreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }

        }

        

        public static void storeintofile(string path, student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreenames = "";
            for (int idx = 0; idx < s.preferences.Count - 1; idx++)
            {
                degreenames = degreenames + s.preferences[idx].degreeName + ";";

            }
            degreenames = degreenames + s.preferences[s.preferences.Count - 1].degreeName;
            f.WriteLine(s.name+ "," + s.age + "," + s.fscmarks + "," + s.ecatmarks + "," + degreenames);
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
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    double fsc = double.Parse(splittedRecord[2]);
                    double ecat = double.Parse(splittedRecord[3]);
                    string[] splittedrecordforpreferences = splittedRecord[4].Split(';');
                    List<degreeProgram> preferences = new List<degreeProgram>();
                    for (int x = 0; x < splittedrecordforpreferences.Length; x++)
                    {
                        degreeProgram d = degreeProgramCRUD.isdegreeexists(splittedrecordforpreferences[x]);
                        if (d != null)
                        {
                            if(!(preferences.Contains(d)))
                            {
                                preferences.Add(d);
                            }
                        }
                    }

                    student s = new student(name, age, fsc, ecat, preferences);
                    studentlist.Add(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
