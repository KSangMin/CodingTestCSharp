using System.Text;

using StreamReader sr = new(Console.OpenStandardInput());

int t = int.Parse(sr.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    int[] nk = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int n = nk[0], k = nk[1];
    int[] time = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    List<int>[] parent = new List<int>[n + 1];
    for(int j = 0; j <= n; j++)
    {
        parent[j] = new List<int>();
    }

    for (int j = 0; j < k; j++)
    {
        int[] xy = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        parent[xy[1]].Add(xy[0]);
    }

    int w = int.Parse(sr.ReadLine()!);
    long[] dp = new long[n + 1];
    Array.Fill(dp, -1);

    sb.AppendLine(Calc(parent, time, dp, w).ToString());
}

Console.Write(sb.ToString());

long Calc(List<int>[] parent, int[] time, long[] dp, int cur)
{
    if(dp[cur] != -1)
    {
        return dp[cur];
    }

    if (parent[cur].Count <= 0)
    {
        return dp[cur] = time[cur - 1];
    }

    long max = 0;
    foreach (int p in parent[cur])
    {
        max = Math.Max(max, Calc(parent, time, dp, p));
    }

    return dp[cur] = max + time[cur - 1];
}