const int MOD = 1000000007;
long[,] fib = { { 1, 1 }, { 1, 0 } };

long n = long.Parse(Console.ReadLine()!);

fib = MatPow(fib, n);
Console.WriteLine(fib[0, 1]);

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
                result[i, j] += (a[i, k] * b[k, j]) % MOD;
            }
            result[i, j] %= MOD;
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
                result[i, j] = a[i, j] % MOD;
            }
        }

        return result;
    }

    long[,] half = MatPow(a, e / 2);
    result = MatMul(half, half);

    return e % 2 == 1 ? MatMul(result, a) : result;
}