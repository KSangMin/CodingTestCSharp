long[] nb = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
long n = nb[0], b = nb[1];

long[,] mat = new long[n, n];
for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = row[j];
    }
}

mat = MatPow(mat, b);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{mat[i, j]} ");
    }
    Console.WriteLine();
}

long[,] MatMul(long[,] a, long[,] b)
{
    int len = a.GetLength(0);
    long[,] result = new long[len, len];

    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < len; j++)
        {
            for (int k = 0; k < len; k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
            result[i, j] %= 1000;
        }
    }

    return result;
}

long[,] MatPow(long[,] a, long e)
{
    int len = a.GetLength(0);
    long[,] result = new long[len, len];
    if (e == 1)
    {
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                result[i, j] = a[i, j] % 1000;
            }
        }

        return result;
    }

    long[,] half = MatPow(a, e / 2);
    result = MatMul(half, half);

    return e % 2 == 1 ? MatMul(result, a) : result;
}