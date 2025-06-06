int n = int.Parse(Console.ReadLine());
int[] wines = new int[n + 1], dp = new int[n + 1];
for(int i = 1; i <= n; i++)
{
    wines[i] = int.Parse(Console.ReadLine());
}

dp[1] = wines[1];
if(n >= 2)dp[2] = wines[1] + wines[2];
for (int i = 3; i <= n; i++)
{
    dp[i] = (int)MathF.Max(
        MathF.Max(dp[i - 1], wines[i] + dp[i - 2]),
        wines[i] + wines[i - 1] + dp[i - 3]
    );
}

Console.WriteLine(dp[n]);