using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_OOP_lab
{
    class Program
    {
        //class student
        //{
        //public student()
        //{
        //    Console.WriteLine("Default Constructor Called");
        //}
        //public student (student s)
        //{
        //    name = s.name;
        //    matricmarks = s.matricmarks;
        //    fscmarks = s.fscmarks;
        //    ecatmarks = s.ecatmarks;
        //    aggregate = s.aggregate;
        //}

        //public student()
        //  {
        //    name = "Raveeha";
        //    matricmarks = 1061F;
        //    fscmarks = 1022F;
        //    ecatmarks = 140F;
        //    aggregate = 80.0F;
        //  }
        //public student (string n,float mm, float fsc , float ecat, float agg)
        // {
        //     name = n;
        //     matricmarks = mm;
        //     fscmarks = fsc;
        //     ecatmarks = ecat;
        //     aggregate = agg;
        // }

        //public string name;
        //public float matricmarks;
        //public float fscmarks;
        //public float ecatmarks;
        //public float aggregate;

        //}
        class clocktype
        {
            public clocktype()
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
            public clocktype(int h)
            {
                hours = h;
            }
            public clocktype (int h ,int m)
            {
                hours = h;
                minutes = m;
            }
            public clocktype (int h , int m , int s)
            {
                hours = h;
                minutes = m;
                seconds = s;
            }
            public void incrementhours()
            {
                hours++;
            }
            public void incrementminutes()
            {
                minutes++;
            }
            public void incrementseconds()
            {
                seconds++;
            }
            public void printingtime()
            {
                Console.WriteLine(hours + " " + minutes + " " + seconds);
            }
            public bool isequal(int h , int m , int s)
            {
                if (h == hours && m == minutes && s == seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool isequal( clocktype temp)
            {
                if ( hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int elapsedtime()
            {
                int time = ((hours * 60 * 60) + (minutes * 60) + seconds);
                return time;
            }

            public int remainingTime()
            {
                int temp = elapsedtime();
                int  remaining = 86400 - temp;
                return remaining;
            }

            public void insec(int elapsedtime)
            {
               
               hours = (elapsedtime / 3600);
               int temp = (elapsedtime % 3600);
               minutes = (temp / 60); 
              
               seconds = (temp% 60);

            }

            public int convertSec()
            {
                int timeC = 0;
                timeC = (hours * 3600) + (minutes * 60) + seconds;
                return timeC;
            }
            public clocktype differenceTime(clocktype c)
            {
                clocktype n = new clocktype();
                n.hours = c.hours - hours;
                n.minutes = c.minutes - minutes;
                n.seconds = c.seconds - seconds;
                if (n.hours < 0)
                {
                    n.hours = -1 * n.hours;
                }
                if (n.minutes < 0)
                {
                    n.minutes = -1 * n.minutes;
                }
                if (n.seconds < 0)
                {
                    n.seconds = -1 * n.seconds;
                }
                return n;
            }


            public int hours;
            public int minutes;
            public int seconds;
        }



        static void Main(string[] args)
        {
            clocktype empty_time = new clocktype();
            Console.Write("Empty Time : ");
            empty_time.printingtime();

            clocktype hour_time = new clocktype(8);
            Console.Write("Hour Time : ");
            hour_time.printingtime();

            clocktype minutes_time = new clocktype(8, 10);
            Console.Write("Minutes Time : ");
            minutes_time.printingtime();

            clocktype full_time = new clocktype(8, 10, 10);
            Console.Write("Full Time : ");
            full_time.printingtime();

            full_time.incrementseconds();
            Console.Write("Full time (Increment second ) : ");
            full_time.printingtime();

            full_time.incrementminutes();
            Console.Write("Full time (Increment Minute ) : ");
            full_time.printingtime();


            full_time.incrementhours();
            Console.Write("Full time (Increment Hours ) : ");
            full_time.printingtime();

            bool flag = full_time.isequal(9, 11, 11);
            Console.WriteLine("Flag : " + flag);

            clocktype time2 = new clocktype(9, 11, 11);
            flag = full_time.isequal(time2);
            Console.WriteLine("Object Flag : " + flag);

            int timeelapsed = full_time.elapsedtime();
            Console.WriteLine("Time Elapsed in seconds : {0}", timeelapsed);

            full_time.insec(timeelapsed);
            Console.WriteLine("Elapsed time in Hours : {0}   Elapsed Time in Minutes : {1}    Elapsed Time in Seconds : {2}" , full_time.hours, full_time.minutes, full_time.seconds);

            int time = full_time.remainingTime();
            Console.WriteLine("Time Remaining in seconds : {0}", time);

            full_time.insec(time);
            Console.WriteLine("Remaining time in Hours : {0}   Remaining Time in Minutes : {1}    Remaining Time in Seconds : {2}", full_time.hours, full_time.minutes, full_time.seconds);


            clocktype another = new clocktype(10, 8, 5);
            clocktype difference = new clocktype();
            difference = full_time.differenceTime(another);
            int newtime = another.convertSec();
            Console.WriteLine("Time Remaining in seconds : {0}", newtime);
            Console.WriteLine("Time difference is: ");
            difference.printingtime();
            Console.ReadKey();



          

        }

        //static void practiceofconstructors()
        //{
            //student s1 = new student();             //copy constructor
            //s1.name = "Raveeha";
            //student s2 = new student(s1);
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s2.name);
            //Console.ReadKey();

            //student s1 = new student("Raveeha", 1061F, 1022F , 150F, 80F);
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s1.matricmarks);
            //Console.WriteLine(s1.fscmarks);
            //Console.WriteLine(s1.ecatmarks);
            //Console.WriteLine(s1.aggregate);
            //Console.ReadKey();

            //student s2 = new student("Tayyaba", 1035F, 1022F, 45F, 80F) ;
            //Console.WriteLine(s2.name);
            //Console.WriteLine(s2.matricmarks);
            //Console.WriteLine(s2.fscmarks);
            //Console.WriteLine(s2.ecatmarks);
            //Console.WriteLine(s2.aggregate);
            //Console.ReadKey();

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10
            //};
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
        //}

    }
}
