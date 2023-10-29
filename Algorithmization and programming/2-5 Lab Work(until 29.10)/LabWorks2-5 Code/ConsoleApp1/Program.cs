void FirstSolution()
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
void SecondSolution()
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
void Third_firstSolution()
{
    double x, n, mult = 1;

    Console.WriteLine("Программа для вычисления значения формулы:");
    Console.WriteLine(" n ");
    Console.WriteLine(" П (x+i)/i");
    Console.WriteLine("i=2");
    Console.WriteLine("Введите значение x");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение n");
    n = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= n; i++)
    {
        mult *= (x + i) / i;
    }

    Console.WriteLine("Значение формулы для x = " + x + " и n = " + n + " равняется " + mult);
}

void Third_secondSolution()
{
    double a, b, n, lenght;
    double x = -4, result = 0;

    Console.WriteLine("Программа для вычисления значений функций (x^3)(e^2x) и (e^x)(sin x) в n равномерно распределенных в диапазоне а<=x<=b точках");
    Console.WriteLine("Введите a");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n");
    n = Convert.ToInt32(Console.ReadLine());

    lenght = b - a;
    Console.WriteLine("Результаты для (x^3)(e^2x)");
    for (int i = 0; i < n; i++)
    {
        result = Math.Pow(x, 3) * Math.Pow(Math.E, 2 * x);
        Console.WriteLine("x = " + x + ": " + result);
        x += lenght / n;
    }

    x = -4;
    Console.WriteLine("Результаты для (e^x)(sin x)");
    for (int i = 0; i < n; i++)
    {
        result = Math.Pow(Math.E, x) * Math.Sin(x);
        Console.WriteLine("x = " + x + ": " + result);
        x += lenght / n;
    }
}
void FourthSoultion()
{
    double x, a, z = 0, step = 0;

    Console.WriteLine("Программа для табуляции функций в зависимости от значений переменных x и a");
    Console.WriteLine("    |    a(e^(x+2a)+e^(-(x-3a))),    если  0,1 <= x < 0,5");
    Console.WriteLine("z = |    sin x,                      если  x = 0,5, a = 2; 2,1");
    Console.WriteLine("    |    a + a cos(x+3a),            если  0,5 < x <= 1,5, шаг dx=a/10");

    Console.WriteLine("Введите a");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите x");
    x = Convert.ToDouble(Console.ReadLine());

    if ((0.1 <= x) & (x < 0.5))
    {
        step = a / 10;
        for (double i = x; i < 0.5; i = i + step)
        {
            x = Math.Round(i, 5);
            z = a * (Math.Pow(Math.E, x + 2 * a) + Math.Pow(Math.E, -(x - 3 * a)));
            Console.WriteLine("При x = " + x + " z = a(e^(x+2a)+e^(-(x-3a))) = " + z);
        }
    }
    else if ((x == 0.5) & ((a == 2) | (a == 2.1)))
    {
        z = Math.Sin(x);
        Console.WriteLine("При x = " + x + " z = sin x = " + z);
    }
    else if ((0.5 < x) & (x <= 1.5))
    {
        step = a / 10;
        for (double i = x; i <= 1.5; i = i + step)
        {
            x = Math.Round(i, 5);
            z = Math.Round(a + a * Math.Cos(x + 3 * a), 8);
            Console.WriteLine("При x = " + x + " z = a + a cos(x+3a) = " + z);
        }
    }
}
