

void Task1_3()
{
    int[,] a = new int[4, 4] {{1, 2, 3, 4},
                          {5, 6, 7, 8},
                          {9, 10, 11, 12},
                          {13, 14, 15, 16}};
    int sum = 0;

    for (int k = 0; k < 4; k++)
    {
        int m = k;

        for (int i = 0; i < (4 - k); i++)
        {
            int n = a[i, m++];
            Console.WriteLine($"n = {n}");
            sum += n;
        }
        Console.WriteLine($"sum = {sum}");
    }
    Console.WriteLine($"sum = {sum}");


    sum = 0;

    for (int k = 1; k < 4; k++)
    {
        int m = k;

        for (int i = 0; i < (4 - k); i++)
        {
            int n = a[m++, i];
            Console.WriteLine($"n = {n}");
            sum += n;
        }
        Console.WriteLine($"sum = {sum}");
    }
}

void Task1_6() {
    int[,] a = new int[4, 7] {{1, 123, 3323, 43344, 432234, 4334, 43452},
                          {5, 6, 2, 8, 323, 232, 3434},
                          {9, 10, 3, 12, 3434, 3443, 32234},
                          {13, 14, 4, 16, 334, 3434, 34,}};
    int[] array_min = new int[4];
    int n = 0;
    for(int i = 0; i<4; i++)
    {
        int min = 999;
        for(int j = 0; j<7; j++)
        {
            if (a[i, j] < min)
                min = a[i, j];
        }
        array_min[n] = min;
        Console.Write($"{n} ");
        n++;
    }

}

void Task1_12()
{
    int[,] a = new int[6, 7] {{1, 1, 1, 1, 1, 1, 1},
                              {2, 2, 2, 2, 2, 2, 2},
                              {3, 3, 3, 3, 3, 3, 3},
                              {4, 4, 4, 10, 4, 4, 4},
                              {5, 5, 5, 5, 5, 5, 5},
                              {6, 6, 6, 6, 6, 6, 6}};
    int max = 0;
    int m = 0;
    int n = 0;
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (a[i, j] > max)
            {
                max = a[i, j];
                m = i;
                n = j;
            }
        }
    }
    for (int i = 0; i < 6; i++)
    {
        if (i != m)
            for (int j = 0; j < 7; j++)
            {
                if (j != n)
                    Console.Write($"{a[i, j]} ");
                else if (j == n)
                    Console.Write($" ");
            }
        Console.WriteLine();
    }
}

void Task1_13()
{
    int[,] a = new int[5, 5] {{1, 1, 1, 0, 1},
                              {2, 10, 2, 0, 2},
                              {3, 3, 3, 0, 3},
                              {4, 4, 4, 0, 4},
                              {5, 5, 5, 0, 5}};
    int[] array = new int[5];
    int max = 0;
    int m = 0;
    for (int i = 0; i < 5; i++)
    {
        if (a[i, i] > max)
        {
            max = a[i, i];
            m = i;
        }
    }

    for (int i = 0; i < 5; i++)
    {
        array[i] = a[i, m];
    }

    for (int i = 0; i < 5; i++){
        for (int j = 0; j < 5; j++)
        {
            if((j != m) && (j != 3))
                Console.Write($"{a[i, j]} ");
            else if(j == 3){
                Console.Write($"{array[i]} ");
            }
            else Console.Write($"0 ");
        }
        Console.WriteLine();
    }
}
void Task1_17()
{
    Console.WriteLine("Введите размер матрицы М Х Н");
    Console.WriteLine("Введите M");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите N");
    int n = int.Parse(Console.ReadLine());

    double[,] list = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            list[i, j] = double.Parse(Console.ReadLine());

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{list[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine("---------- ответ");

    double mn = 10 ^ 20;
    int position_mn = 0;
    double variable = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            if (list[i, j] <= mn)
            {
                mn = list[i, j];
                position_mn = j;
            }
        if (position_mn != 0)
        {
            if (position_mn != n)
            {
                for (int j = position_mn; j < n - 1; j++)
                    list[i, j] = list[i, j + 1];
            }
            for (int j = n - 1; j >= 1; j--)
                list[i, j] = list[i, j - 1];
            list[i, 0] = mn;
        }
        mn = 10 ^ 20; position_mn = 0;

    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{list[i, j]} ");
        Console.WriteLine();
    }
}

void Task1_29()
{
    int c = 1000000, ind = 0;
    int[,] a = new int[5, 7] { { 4, 76, 1, 88, 12, 13, -1 },
                            { 32, 23, 65, 43, 17, -7, 66 },
                            { -90, 87, 55, 11, 10, 9, 8 },
                            { 91, 67, -18, 68, 24, 61, -84 },
                            { -13, -4, -6, -19, 57, 3, 73 } };
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            a[i, j] = int.Parse(Console.ReadLine());
        }
    }

    for (int j = 0; j < 7; j++)
    {
        if (Math.Abs(a[1, j]) <= c)
        {
            c = Math.Abs(a[1, j]);
            ind = j;
        }
    }
    if (ind != 6)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = ind + 1; j < 6; j++)
            {
                a[i, j] = a[i, j + 1];
            }
        }
    }
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Tast1_31()
{
    Console.WriteLine("Введите вектор B: ");
    double[] B = new double[5];
    for (int i = 0; i < 5; i++)
        B[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("матрица 5 Х 8");
    double[,] list = new double[5, 8];

    for (int i = 0; i < 5; i++){
        for (int j = 0; j < 7; j++)
            list[i, j] = double.Parse(Console.ReadLine());
        Console.WriteLine("/n");
    }

    for (int i = 0; i < 5; i++){
        for (int j = 0; j < 8; j++)
            Console.Write($"{list[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine("--------------");

    double mn = 10 ^ 20;
    int position = 0;
    for (int j = 0; j < 7; j++)
        if (list[5 - 1, j] <= mn)
        {
            mn = list[5 - 1, j];
            position = j;
        }


    if (position == 7)
        Console.WriteLine("ОШИБКА");
    else if (position != 7)
    {
        if (position != 6)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 7; j >= 0; j--)
                    if (j > position + 1)
                        list[i, j] = list[i, j - 1];
                    else if (j == position + 1)
                        list[i, j] = B[i];
        }
        else if (position == 6)
            for (int i = 0; i < 5;)
                list[i, 7] = B[i];


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
                Console.Write($"{list[i, j]} ");
            Console.WriteLine();
        }
    }
}

//LVL 2
void Task2_7(){
    int[,] a = new int[6, 6] {{1, 1, 1, 1, 1, 10},
                              {2, 88, 2, 1, 2, 7},
                              {3, 3, 3, 1, 3, 5},
                              {4, 4, 4, 99, 4, 99},
                              {5, 5, 5, 1, 5, 5},
                              {5, 5, 5, 1, 5, 6}};
    int b = 0;
    int l = 0;
    for(int i = 0; i < 6; i++ ){
            if(a[i, i] > b){
                b = a[i, i];
                l = i;
            }
        }
    Console.WriteLine($"max = {b}");

    for (int i = 0; i < 6; i++ ){
        Console.WriteLine();
        for(int j = 0; j<6; j++){
            if ((i == l) && (j == l))
                Console.Write($"0 ");
            else if ( (l!=0) && (i==l-1) && (j==l) )
                Console.Write($"0 ");
            else if( (j!=5) && (i==l) && (j==l+1) )
                Console.Write($"0 ");
            else
                Console.Write($"{a[i, j]} ");
        }
    }
}

void Task2_8(){
    int[,] a = new int[6, 6] {{1, 1, 1, 1, 1, 10},
                              {2, 88, 2, 1, 2, 7},
                              {3, 3, 3, 1, 3, 5},
                              {4, 4, 4, 99, 4, 9},
                              {77, 5, 5, 1, 5, 5},
                              {5, 5, 5, 1, 5, 6}};
    int[] b = new int[6];
    for(int i = 0; i<6; i++){
        int max = 0;
        int index_max = 0;
        for(int j = 0; j<6; j++){
            if (a[i, j] > max){
                max = a[i, j];
                index_max = j;
            }
        }
        b[i] = index_max;
    }

    for (int i = 0; i < 6; i++){
        Console.WriteLine();
        for (int j = 0; j < 6; j++){
            if ((j==b[i])&&(i%2==0))
                Console.Write($"{a[i+1, b[i+1]]} ");
            else if((j == b[i]) && (i % 2 == 1))
                Console.Write($"{a[i-1, b[i-1]]} ");
            else Console.Write($"{a[i, j]} ");
        }
    }
}
void Task2_9()
{
    int[,] a = new int[6, 7] {{1, 1, 1, 1, 1, 10, 0},
                              {2, 88, 2, 1, 2, 7, 0},
                              {3, 3, 3, 1, 3, 5, 0},
                              {4, 4, 4, 99, 4, 9, 0},
                              {77, 5, 5, 1, 5, 5, 0},
                              {5, 5, 5, 1, 5, 6, 0}};
    for (int i = 0; i < 6; i++){
        Console.WriteLine();
        for (int j = 6; j >= 0; j--){
            Console.Write($"{a[i, j]} ");
        }
    }
}
