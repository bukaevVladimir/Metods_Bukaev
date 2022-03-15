using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class ClassForTasksByCycles
    {
        public static int FirstDegree (int number, int degree)
        {
            int tmp = 1;

            bool isPositive = number >= 0;

            number = Math.Abs(number);
            for (int i = 1; i <= degree; i++)
            {
                tmp = tmp * number;
            }

            if (!isPositive)
            {
                tmp = 1 / tmp;
            }

            return tmp;
        }
    }
}
