using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public class ClassHw1 // дз№1
    {
        public static double Qweqwe(double a, double b)  // 2 задача
        {
            return ((5 * a) + Math.Pow(b, 2)) / (b - a);
        }

        public static void Third(ref string s1, ref string s2)
        {
            string s3;
            s3 = s1;
            s1 = s2;
            s2 = s3;
        }

        public static double LinearEquation(double a_4, double b_4, double c_4) //4 задача
            {
                return((c_4 - b_4) / a_4);
            }

        public static double ExecuteIf(double a_if, double b_if)// 1 задача из if
        {
           if(a_if > b_if)
            {
                return a_if + b_if;
            }
           if(a_if == b_if)
            {
                return a_if * b_if;
            }
            return a_if - b_if;
        }
    }
}
