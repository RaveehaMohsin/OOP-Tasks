using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_UAMS_lab_task_4
{
    public class Student
    {
        public string name;
        public int age;
        public float fscmarks;
        public float ecatmarks;
        public List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
        public List<Subject> subjects = new List<Subject>();
        public DegreeProgram enroll;

        public Student()
        {

        }
        public Student(string name, int age, float fscm, float ecatm, List<DegreeProgram> degreePrograms)
        {
            this.name = name;
            this.age = age;
            this.fscmarks = fscm;
            this.ecatmarks = ecatm;
            this.degreePrograms = degreePrograms;
        }

        public float calculatemerit()
        {

            float merit = ((fscmarks * 60.0F) / 100.0F) + ((ecatmarks * 40.0F) / 100.0F);
            return merit;

        }



    }
}


