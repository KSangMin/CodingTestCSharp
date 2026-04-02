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
                result[i, j] %= MOD;
            }
        }
    }

    return result;
}

long[,] MatPow(long[,] a, long e)
{
    long[,] unit = { { 1, 0 }, { 0, 1 } };
    long[,] baseMat = a;
    
    while(e > 0)
    {
        if (e % 2 == 1)
        {
            unit = MatMul(unit, baseMat);
        }
        baseMat = MatMul(baseMat, baseMat);
        e /= 2;
    }

    return unit;
}