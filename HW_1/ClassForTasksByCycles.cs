using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class ClassForTasksByCycles
    {
        public static int FirstDegree(int number, int degree)
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
        public static int DivisibleNumbersByInput(int a2) // 3 задача по циклам
        {
            int k = 1;
            while (Math.Pow(k, 2) < a2)
            {
                k++;
            }
            k = (int)Math.Sqrt(a2);
            return k;


        }

        public static int GreatestDivisorOfANumber(int a4)// 4 задача по циклам
        {
            int v;
            for (v = a4 / 2; v >= 1; v--)
            {
                if (a4 % v == 0)
                {
                    break;
                }
            }
            return v;

        }
    }
}
