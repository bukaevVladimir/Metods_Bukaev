using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    public static class Class1
    {
        public static void solution()
        {
            Console.Write("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = ((5 * a) + Math.Pow(b, 2)) / (b - a);

            Console.WriteLine($"Ответ: {c}");
        }
    }

    public static class Class2
    {
        public static void solution2()
        {
            Console.Write("Введите число a, не равное нулю: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b, не равное нулю: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число c, не равное нулю: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x = (c - b) / a;
            Console.WriteLine($"Ответ: {x}");
        }



    }
}