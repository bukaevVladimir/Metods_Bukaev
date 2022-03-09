using HW_1;

// 2 задача 
Console.Write("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = ClassHw1.Qweqwe(a, b);
Console.WriteLine($"Answer: {c}");

// 3 задача
Console.Write("Enter the first number: ");
string r = Console.ReadLine();
Console.Write("Enter the second number: ");
string q = Console.ReadLine();
ClassHw1.Third(ref r, ref q);
Console.WriteLine($"{r}\n{q}");

// 4 задача
Console.Write("Введите число a, не равное нулю: ");
double a_4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b, не равное нулю: ");
double b_4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число c, не равное нулю: ");
double c_4 = Convert.ToDouble(Console.ReadLine());

double x_4 = ClassHw1.LinearEquation(a_4, b_4, c_4);
Console.WriteLine($"Ответ: {x_4}");

// 1 задача по if
Console.Write("Введите первое число: ");
double a_if = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b_if = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ClassHw1.ExecuteIf(a_if, b_if));

