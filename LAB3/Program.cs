using System;
// LVL 1

void lvl1_6()
{
    int[] x = new int[5];
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        x[i] = Convert.ToInt32(Console.ReadLine());
        sum += x[i] * x[i];
    }
    Console.WriteLine($"L = {Math.Pow(sum, 0.5)}");
}


void lvl1_10()
{
    Console.Write("P: ");
    int P = Convert.ToInt32(Console.ReadLine());
    Console.Write("Q: ");
    int Q = Convert.ToInt32(Console.ReadLine());
    int[] x = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        x[i] = Convert.ToInt32(Console.ReadLine());
    }
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        if ((x[i] > P) && (x[i] < Q))
            count++;
        Console.Write($"{x[i]} ");
    }
    Console.Write($"count = {count} ");
}


void lvl1_11()
{
    int[] x = new int[10];
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        x[i] = Convert.ToInt32(Console.ReadLine());
        if (x[i] > 0)
            count++;
    }
    int[] y = new int[count];
    int j = 0;
    for (int i = 0; i < 10; i++)
    {
        if (x[i] > 0)
        {
            y[j] = x[i];
            Console.Write($"{y[j]} ");
            j++;
        }
    }
}


void lvl1_12()
{
    int[] x = new int[8];
    int output = 0;
    int j = 0;
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        x[i] = Convert.ToInt32(Console.ReadLine());
        if (x[i] < 0)
        {
            output = x[i];
            j = i;
        }

    }
    Console.WriteLine($"{output}, {j}");
}

void lvl1_13()
{
    int[] x = new int[10];
    int count_ch = 0;
    int count_not = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        x[i] = Convert.ToInt32(Console.ReadLine());
        if (x[i] % 2 == 0)
            count_ch++;
        else count_not++;
    }

    int[] x_ch = new int[count_ch];
    int j_ch = 0;
    int[] x_not = new int[count_not];
    int j_not = 0;

    for (int i = 0; i < 10; i++)
    {
        if (x[i] % 2 == 0)
        {
            x_ch[j_ch] = x[i];
            j_ch++;
        }
        else
        {
            x_not[j_not] = x[i];
            j_not++;
        }

    }
    Console.WriteLine($"Ch: ");
    for (int i = 0; i < count_ch; i++)
    {
        Console.Write($"{x_ch[i]} ");
    }
    Console.WriteLine($"\nNot: ");
    for (int i = 0; i < count_not; i++)
    {
        Console.Write($"{x_not[i]} ");
    }
}


//Console.WriteLine("lvl1_6");
//lvl1_6();
//Console.WriteLine("lvl1_10");
//lvl1_10();
//Console.WriteLine("lvl1_11");
//lvl1_11();
//Console.WriteLine("lvl1_12");
//lvl1_12();
//Console.WriteLine("lvl1_13");
//lvl1_13();

//LVL 2

void lvl2_5()
{
    int count = 7;
    int[] input = { -9, 8, 23, 0, -7, -5, 1, 98 };
    int ct = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{input[i]} ");
        if (input[i] < 0)
            ct++;
    }
    Console.Write("\n");
    int[] output = new int[ct];
    ct = 0;
    for (int i = 0; i < count; i++)
    {
        if (input[i] < 0)
        {
            output[ct] = input[i];
            Console.Write($"{output[ct]} ");
            ct++;
        }
    }
}

void lvl2_6()
{
    int ct = 5;
    int[] arr = new int[ct];
    int sum = 0;
    Console.Write("Enter P: ");
    int p = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < ct; i++)
    {
        Console.Write($"Enter x{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        sum += arr[i];
    }
    int sr = sum / ct;
    int output = 0;
    double min = 9999999;
    for (int i = 0; i < ct; i++)
    {
        int pr = Math.Abs(arr[i] - sr);
        if (min > pr)
        {
            min = pr;
            output = i;
        }
    }
    int[] arrout = new int[ct + 1];
    int j = 0;
    for (int i = 0; i < ct; i++)
    {
        if (i == output)
        {
            arrout[j] = arr[i];
            j++;
            arrout[j] = p;
            j++;
        }
        else
        {
            arrout[j] = arr[i];
            j++;
        }
    }
    for (int i = 0; i < ct + 1; i++)
        Console.Write($"{arrout[i]} ");
}

//1 9 3 4 5 6 7 0
//среднее от 3 4 5 6 7
void lvl2_9()
{
    int count = 8;
    int[] arr = new int[count];
    int min = 99999999;
    int min_index = 0;
    int max = 0;
    int max_index = 0;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"x{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] < min)
        {
            min = arr[i];
            min_index = i;
        }
        else if (arr[i] > max)
        {
            max = arr[i];
            max_index = i;
        }
    }
    int k = 0;
    int l = 0;
    if (min_index > max_index)
    {
        k = min_index;
        l = max_index;
    }
    else
    {
        k = max_index;
        l = min_index;
    }
    int sum = 0;
    for (int i = l + 1; i < k; i++)
    {
        sum += arr[i];
    }
    Console.Write($"{sum / (k - l - 1)} ");
}


void lvl2_10()
{
    int count = 10;
    int[] arr = new int[count];
    int min = 99999999;
    int ct_min = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"x{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if ((arr[i] > 0) && (arr[i] < min))
        {
            min = arr[i];
            ct_min = 0;
        }
    }

    int[] arr_out = new int[count - ct_min];
    int j = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] != min)
        {
            arr_out[j] = arr[i];
            Console.Write($"{arr_out[j]} ");
            j++;
        }
    }

}

void lvl2_11()
{
    int count = 10;
    int[] arr = new int[count];
    int min = 99999999;
    int min_index = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"x{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] < min)
        {
            min = arr[i];
            min_index = i;
        }
    }
    int[] arrout = new int[count - 1];
    int j = 0;
    for (int i = 0; i < count; i++)
    {
        if (i != min_index)
        {
            arrout[j] = arr[i];
            Console.Write($"{arrout[j]} ");
            j++;
        }
    }
}

void lvl2_13()
{
    int count = 10;
    int[] arr = new int[count];
    int max = 0;
    int max_index = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"x{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if ((arr[i] > max) && (i % 2 == 0))
        {
            max = arr[i];
            max_index = i;
        }
    }
    for (int i = 0; i < count; i++)
    {
        if (i != max_index)
            Console.Write($"{arr[i]} ");
        else Console.Write($"{i} ");
    }
}

void lvl2_15()
{
    int k = 4;
    int n = 6;
    int[] A = new int[n];
    int m = 3;
    int[] B = new int[m];
    Console.WriteLine("A");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"x{i + 1}: ");
        A[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("B");
    for (int i = 0; i < m; i++)
    {
        Console.Write($"x{i + 1}: ");
        B[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        if (i == k - 1)
        {
            Console.Write($"{A[i]} ");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{B[j]} ");
            }
        }
        Console.Write($"{A[i]} ");
    }

}

//Console.WriteLine("LVL2_5");
//lvl2_5();
//Console.WriteLine("LVL2_6");
//lvl2_6();
//Console.WriteLine("LVL2_9");
//lvl2_9();
//Console.WriteLine("LVL2_10");
//lvl2_10();
//Console.WriteLine("LVL2_11");
//lvl2_11();
//Console.WriteLine("LVL2_13");
//lvl2_13();
Console.WriteLine("LVL2_15");
lvl2_15();




