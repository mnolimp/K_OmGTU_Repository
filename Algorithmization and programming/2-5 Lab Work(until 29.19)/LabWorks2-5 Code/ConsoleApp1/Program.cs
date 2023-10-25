secondSolution();

void firstSolution()
{
    double y, a, b, x1, x2; //y - результат вычислений; a, b, x1, x2 - подаваемые на вход значения переменных

    Console.WriteLine("Программа для вычисления значения формулы:");
    Console.WriteLine("          a^2");
    Console.WriteLine("y = --------------- + ln(a + bx)");
    Console.WriteLine("    (x + 2)e^(-bx)");

    Console.WriteLine("Введите значение a");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение b");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение x1");
    x1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение x2");
    x2 = Convert.ToDouble(Console.ReadLine());

    y = ((a * a) / ((x1 + 2) * Math.Pow(Math.Exp(1), -b * x1))) + Math.Log(a + b * x1);
    Console.WriteLine("y(" + x1 + ") = " + y);

    y = ((a * a) / ((x2 + 2) * Math.Pow(Math.Exp(1), -b * x2))) + Math.Log(a + b * x2);
    Console.WriteLine("y(" + x2 + ") = " + y);
}
void secondSolution()
{
    double y = 0, x = 0, a, b, c;

    Console.WriteLine("Программа для вычисления значения функции y в зависимости от интервала, в котором лежит значение x переменной");
    Console.WriteLine("    |    (sin x)/ (a + e^x)   при  x >= 4");
    Console.WriteLine("y = |    a/x + bx^2 - c       при x <= 1.2");
    Console.WriteLine("    |    (a + bx)/√(x+1)      при x > 1.2");

    Console.WriteLine("Введите x");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите a");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите b");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите c");
    c = Convert.ToDouble(Console.ReadLine());



    if (x <= 1.2)
    {
        y = a / x + b * x * x - c;
    }
    else if ((x > 1.2) & (x < 4))
    {
        y = (a + b * x) / Math.Sqrt(x + 1);
    }
    else if (x >= 4)
    {
        y = (Math.Sin(x)) / (a + Math.Pow(Math.E, x));
    }

    Console.WriteLine("y(" + x + ") = " + y);
}
void thirdSolution()
{

}
void fourthSoultion()
{

}