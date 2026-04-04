const long MOD = 1000000007;
long sum = 0;

using(StreamReader sr = new StreamReader(Console.OpenStandardInput()))
{
    int m = int.Parse(sr.ReadLine()!);

    for (int i = 0; i < m; i++)
    {
        long[] ns = sr.ReadLine()!.Split().Select(long.Parse).ToArray();
        long n = ns[0], s = ns[1];

        sum += (s * Pow(n, MOD - 2)) % MOD;
        sum %= MOD;
    }
}

Console.WriteLine(sum);

long Pow(long a, long e)
{
    long result = 1;
    
    while(e > 0)
    {
        if (e % 2 == 1)
        {
            result = (result * a) % MOD;
        }
        a = (a * a) % MOD;
        e /= 2;
    }

    return result;
}