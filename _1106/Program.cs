int[] cn = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int c = cn[0], n = cn[1];
List<(int cost, int people)> city = new();
int maxPeople = 0;
for (int i = 0; i < n; i++)
{
    int[] cp = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    city.Add((cp[0], cp[1]));
    maxPeople = Math.Max(maxPeople, cp[1]);
}

int[] dp = new int[c + maxPeople + 1];
Array.Fill(dp,  int.MaxValue);
dp[0] = 0;

for (int i = 0; i < n; i++)
{
    for(int j = 1; j < dp.Length; j++)
    {
        dp[j] = Math.Min(dp[j], dp[Math.Max(0, j - city[i].people)] + city[i].cost);
    }
}

Console.WriteLine(dp[c]);