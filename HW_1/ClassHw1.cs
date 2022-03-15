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
        
        public static string NumbersInLetters(int num)// 5 задача
        {
            int ten = num / 10;
            int one = num % 10;
            string first = "", second = "";

            if (ten == 1)
            {
                switch (num)
                {
                    case 10: first = "Десять"; break;
                    case 11: first = "Одиннадцать"; break;
                    case 12: first = "Двенадцать"; break;
                    case 13: first = "Тринадцать"; break;
                    case 14: first = "Четырнадцать"; break;
                    case 15: first = "Пятнадцать"; break;
                    case 16: first = "Шестнадцать"; break;
                    case 17: first = "Семнадцать"; break;
                    case 18: first = "Восемнадцать"; break;
                    case 19: first = "Девятнадцать"; break;
                }

                return first;

            }
            if (ten >= 2 && ten < 10)
            {
                switch (ten)
                {
                    case 2: first = "Двадцать"; break;
                    case 3: first = "Тридцать"; break;
                    case 4: first = "Сорок"; break;
                    case 5: first = "Пятьдесят"; break;
                    case 6: first = "Шестьдесят"; break;
                    case 7: first = "Семьдесят"; break;
                    case 8: first = "Восемьдесят"; break;
                    case 9: first = "Девяносто"; break;
                }
                switch (one)
                {
                    case 0: second = " "; break;
                    case 1: second = "один"; break;
                    case 2: second = "два"; break;
                    case 3: second = "три"; break;
                    case 4: second = "четыре"; break;
                    case 5: second = "пять"; break;
                    case 6: second = "шесть"; break;
                    case 7: second = "семь"; break;
                    case 8: second = "восемь"; break;
                    case 9: second = "девять"; break;
                }

                return ($"{first} {second}");

            }
            return "0";

        }
    }
}
