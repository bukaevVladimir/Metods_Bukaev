using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class Homework2
    {
        public static int ExecuteIf(int a_if, int b_if)// 1 задача из if
        {
            if (a_if > b_if)
            {
                return a_if + b_if;
            }
            if (a_if == b_if)
            {
                return a_if * b_if;
            }
            return a_if - b_if;
        }
        public static int QuarteroCordinates(double x, double y)//2 задача из if
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            if (x > 0 && y < 0)
            {
                return 2;
            }
            if (x < 0 && y < 0)
            {
                return 3;
            }
            return 4;

        }
    }
}
