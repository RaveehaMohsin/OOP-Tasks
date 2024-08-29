using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_oop_lab_task_1.Bl
{
           public class MyPoint
        {
            public int x;
            public int y;

            public MyPoint()
            {

            }
            public MyPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int getX()
            {
                return x;
            }
            public void setX(int newx)
            {
                x = newx;
            }

            public int getY()
            {
                return y;
            }

            public void setY(int newy)
            {
                y = newy;
            }

            public void setXY(int newx, int newy)
            {
                x = newx;
                y = newy;
            }

            public double distancewithcords(int givenx, int giveny)
            {
                double distance;
                distance = Math.Sqrt(((givenx - x) * (givenx - x)) + ((giveny - y) * (giveny - y)));
                return distance;
            }

            public double distancewithobject(MyPoint another)
            {
                double distance;
                distance = Math.Sqrt(((another.x - x) * (another.x - x)) + ((another.y - y) * (another.y - y)));
                return distance;

            }
            public double distancewithzero()
            {
                double distance;
                distance = Math.Sqrt(((0 - x) * (0 - x)) + ((0 - y) * (0 - y)));
                return distance;

            }


        }
    
}
