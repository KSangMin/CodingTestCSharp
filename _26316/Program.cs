using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    int[] cd = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int c = cd[0], d = cd[1];
    string road = Console.ReadLine()!;

    int[] dp = Enumerable.Repeat(50, c).ToArray();
    dp[0] = 0;

    for (int j = 1; j < c; j++)
    {
        if (road[j] == 'X')
        {
            continue;
        }

        for (int k = 0; k <= d; k++)
        {
            int target = j - k - 1;
            if(target < 0)
            {
                break;
            }

            if (road[target] == '.' && dp[target] != 50)
            {
                dp[j] = Math.Min(dp[j], dp[target] + 1);
            }
        }
    }

    sb.AppendLine($"Day #{i + 1}");
    sb.AppendLine($"{c} {d}");
    sb.AppendLine(road);
    sb.AppendLine($"{(dp[c - 1] == 50 ? 0 : dp[c - 1])}\n");
}

Console.Write(sb.ToString());