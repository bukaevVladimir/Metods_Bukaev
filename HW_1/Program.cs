using HW_1;

////Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
//// 1 задача 
////Console.Write("Enter the first number: ");
////double a_1 = Convert.ToDouble(Console.ReadLine());
////Console.Write("Enter the second number: ");
////double b_1 = Convert.ToDouble(Console.ReadLine());




//// 2 задача 
//Console.Write("Enter the first number: ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the second number: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double c = ClassHw1.Qweqwe(a, b);
//Console.WriteLine($"Answer: {c}");

//// 3 задача
//Console.Write("Enter the first number: ");
//string r = Console.ReadLine();
//Console.Write("Enter the second number: ");
//string q = Console.ReadLine();

//ClassHw1.Third(ref r, ref q);
//Console.WriteLine($"{r}\n{q}");

//// 4 задача
//Console.Write("Введите число a, не равное нулю: ");
//double a_4 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите число b, не равное нулю: ");
//double b_4 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите число c, не равное нулю: ");
//double c_4 = Convert.ToDouble(Console.ReadLine());

//double x_4 = ClassHw1.LinearEquation(a_4, b_4, c_4);
//Console.WriteLine($"Ответ: {x_4}");

//// 1 задача по if
//Console.Write("Введите первое число: ");
//int a_if = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int b_if = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Homework2.ExecuteIf(a_if, b_if));

//// 2 задача по if
//Console.Write("Введите x: ");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите y: ");
//double y = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Точка лежит в {Homework2.QuarteroCordinates(x, y)} четверти");

//// 5 задача по if
//Console.Write("Введите двузначное число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//string result = ClassHw1.NumbersInLetters(num);
//Console.WriteLine($"{result}");

// Задачи по циклам
// 1 задача
Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести: ");
int degree = Convert.ToInt32(Console.ReadLine());


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

Console.WriteLine(tmp);