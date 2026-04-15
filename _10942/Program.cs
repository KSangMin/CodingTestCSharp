using System.Text;

int n = int.Parse(Console.ReadLine()!);
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

bool[,] dp = new bool[arr.Length , arr.Length];
for (int i = 0; i < n; i++)
{
    dp[i, i] = true;
}
for (int i = 0; i < n - 1; i++)
{
    dp[i, i + 1] = arr[i] == arr[i + 1];
}
for(int len = 3; len <= n; len++)
{
    for(int i = 0; i <= n - len; i++)
    {
        int j = i + len - 1;
        dp[i, j] = arr[i] == arr[j] && dp[i + 1, j - 1];
    }
}

int m = int.Parse(Console.ReadLine()!);
StringBuilder sb = new();
for (int i = 0; i < m; i++)
{
    int[] q = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int s = q[0], e = q[1];
    sb.AppendLine(dp[s - 1, e - 1] ? "1" : "0");
}

Console.Write(sb.ToString());