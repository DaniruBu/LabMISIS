static int Fact(int n)
{
    if (n == 1)
        return 1;
    else if (n == 0)
        return 1;
    return n * Fact(n - 1);
}

void lab3_1()
{
    double a = 0.1, b = 1.0, h = 0.1;
    double sum = 0;

    for (double x = a; x <= b; x += h)
    {
        double whattosum = 1;
        for (int i = 0, p = 1; Math.Abs(whattosum) >= 0.0001; i++, p = -p)
        {
            whattosum = p * (Math.Pow(x, 2 * i) / Fact(2 * i));
            sum += whattosum;
        }
        Console.WriteLine($"{Math.Cos(x):f4}: {sum:f4}");
        sum = 0;
    }
}

void lab3_9()
{
    double a = 0.1, b = 0.5, h = 0.05;
    double sum = 0;

    for (double x = a; x <= b; x += h)
    {
        double whattosum = 1;
        for (int i = 0, p = 1; Math.Abs(whattosum) >= 0.0001; i++, p = -p)
        {
            whattosum = p * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
            sum += whattosum;

        }
        Console.WriteLine($"{Math.Atan(x):f4} : {sum:f4}");
        sum = 0;
    }
}
lab3_1();