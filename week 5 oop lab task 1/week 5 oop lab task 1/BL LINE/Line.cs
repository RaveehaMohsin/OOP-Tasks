using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_task_1.BL_LINE
{
     public class Line
    {
       public MyPoint begin;
        public MyPoint end;

        public Line()
        {

        }
        public Line(MyPoint begin , MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public MyPoint getbegin()
        {
            return begin;
            
        }
        public void setbegin(MyPoint newbegin)
        {
            begin = newbegin;
        }

        public MyPoint getend()
        {
            return end;
        }
        public void setend(MyPoint newend)
        {
            end = newend;
        }
        public double getlength()
        {
            double distance;
            distance = Math.Sqrt(((end.x - begin.x) * (end.x - begin.x)) + ((end.y - begin.y) * (end.y - begin.y)));
            return distance;
        }
        public double getlengthbegin()
        {
            double distance;
            distance = Math.Sqrt(((begin.x - 0) * (begin.x - 0)) + (( begin.y - 0) * ( begin.y - 0)));
            return distance;

        }
        public double getlengthend()
        {
            double distance;
            distance = Math.Sqrt(((end.x - 0) * (end.x -0)) + ((end.y - 0) * (end.y -0)));
            return distance;
        }
        public double getgradient()
        {
            double m;
            m = (end.y - begin.y) / (end.x - begin.x);
            return m;
        }

    }
}
