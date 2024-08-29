using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_UAMS_task_1_without_multiple_classes_
{
    public class Student
    {
        public string name;
        public int age;
        public double fscmarks;
        public double ecatmarks;
        public double merit;
        public List<degreeProgram> preferences;
        public List<Subject> regsubjects;
        public degreeProgram regDegree;

        public Student()
        {

        }
        public Student(string name, int age, double fscmarks, double em, List<degreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscmarks;
            this.ecatmarks = em;
            this.preferences = preferences;
            regsubjects = new List<Subject>();
        }

        public void calculatemerit()
        {
            this.merit = (((fscmarks / 1100) * 0.45F) + ((ecatmarks / 1100) * 0.55F)) * 100;
        }


        public int getcrdithours()
        {
            int count = 0;
            for (int idx = 0; idx < regsubjects.Count; idx++)
            {
                count = count + regsubjects[idx].credithours;
            }
            return count;

        }
        public bool regStudentSub(Subject s)
        {
            int ch = getcrdithours();
            if (regDegree != null && regDegree.isSubjectexists(s) && ch + s.credithours <= 9)
            {
                regsubjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }

        }

        public float calculatefee()
        {
           float fees = 0;
            if (regDegree != null)
            {
                for (int idx = 0; idx < regsubjects.Count; idx++)
                {
                    fees = fees + regsubjects[idx].subjectfees;
                }

            }
            return fees;

        }
    }
}
