void Level1_2()
{
    Console.WriteLine("Level1_2");
    double x;
    double y;
    bool l = false;
    Console.Write("Enter x: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y: ");
    y = Convert.ToDouble(Console.ReadLine());
    if (y >= 0 && y + Math.Abs(x) <= 1)
        l = true;
    else l = false;
    Console.WriteLine(l);
}

void Level1_10()
{
    Console.WriteLine("Level1_10");
    double x, y;
    Console.Write("Enter x: ");
    x = Convert.ToDouble(Console.ReadLine());
    if (x <= -1)
        y = 1;
    else if (x > -1 && x <= 1)
        y = -x;
    else y = -1;
    Console.WriteLine(y);
}
void Level2_1()
{
    Console.WriteLine("Level2_1");
    double n, s = 0;
    Console.Write("Enter num: ");
    n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter height: ");
    for (int i = 1; i <= n; i++)
        s += Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Average height = {s / n}");

}
void Level2_9()
{
    Console.WriteLine("Level2_9");
    double r, n, b = 0;
    Console.Write("Enter num: ");
    n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter results: ");
    for (int i = 1; i <= n; i++)
    {
        r = Convert.ToDouble(Console.ReadLine());
        if (r > b) b = r;
    }
    Console.WriteLine($"Best result = {b}");
}
void Level3_4()
{
    Console.WriteLine("Level3_4");
    double x, y, r1, r2, n = 0;
    Console.Write("Enter inner radius: ");
    r1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter outer radius: ");
    r2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coor");
    Console.Write("Enter x: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter y: ");
    y = Convert.ToDouble(Console.ReadLine());
    while (true)
    {
        if ((y * y + x * x > r1 * r1) && (y * y + x * x < r2 * r2))
            n += 1;
        Console.Write("Enter x: ");
        x = Convert.ToDouble(Console.ReadLine());
        if (x == 1000) break;
        Console.Write("Enter y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"num dots = {n}");
    }
    Console.Write($"num dots = {n}");
}
void Level3_11()
{
    Console.WriteLine("Level3_11");
    double n = 0;
    n = Convert.ToInt64(Console.ReadLine());
    double n1 = 0, a, b, c, d;
    int res = 0;
    for (int i = 1; i <= n; ++i)
    {
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());
        if (a == 2 || b == 2 || c == 2 || d == 2)
            res += 1;
        n1 = n1 + ((a + b + c + d) / 4) / 2;
    }
    Console.WriteLine($"{res} {n1}");
}
void Level3_12()
{
    Console.WriteLine("Level3_12");
    while (true)
    {
        long r;
        r = Convert.ToInt64(Console.ReadLine());
        if (r == -1)
            break;
        Console.WriteLine($"{r * r} {r * r * 3,14} {(Math.Sqrt(3) * r * r) / 4}");
    }
}
void Level3_13()
{
    Console.WriteLine("Level3_13");
    double s = 0;

    while (true)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        if (a == -1)
            break;
        string type = Convert.ToString(Console.ReadLine());
        if (type == "ПР")
            s = a * b;
        if (type == "КЦ")
            s = Math.Abs(Math.PI * a * a - Math.PI * b * b);
        if (type == "РБТ")
            s = a * Math.Sqrt(4 * b * b - a * a) / 4;

        Console.WriteLine($"площадь {type} равняется {s}");
    }
}
// Level1_2();
// Level1_10();
// Level2_1();
// Level2_9();

Level3_13();

