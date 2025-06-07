int n = int.Parse(Console.ReadLine());

int[] times = new int[n + 1], prices = new int[n + 1], dp = new int[n + 1];

for (int i = 1; i <= n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    times[i] = input[0];
    prices[i] = input[1];
}

for(int i = 1; i <= n; i++)
{
    int target = i + times[i] - 1;
    if (target <= n)
    {
        int sum = dp[i - 1] + prices[i];
        dp[target] = Math.Max(dp[target], sum);
    }
    dp[i] = (int)MathF.Max(dp[i], dp[i - 1]);
}

Console.WriteLine(dp[n]);