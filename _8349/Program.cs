int n = int.Parse(Console.ReadLine()!);

List<int> dp = new() { 0, 1, 2 };

for (int i = 3; i <= n; i++)
{
    dp.Add((dp[i - 2] + dp[i - 1]) % 10);
}

Console.WriteLine(dp[n]);