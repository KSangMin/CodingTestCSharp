int n = int.Parse(Console.ReadLine()!);
int[] dp = Enumerable.Repeat(1, n).ToArray();
List<int> cows = new();
string s;
while ((s = Console.ReadLine()!) != null)
{
    cows.AddRange(s.Split().Select(int.Parse).ToArray());
}

for (int i = 1; i < n; i++)
{
    for (int j = i - 1; j >= 0; j--)
    {
        if (cows[i] > cows[j])
        {
            dp[i] = Math.Max(dp[i], dp[j] + 1);
        }
    }
}

Console.WriteLine(dp.Max());