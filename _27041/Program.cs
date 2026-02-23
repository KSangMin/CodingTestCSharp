const int MAX = 40001;

int[] elb = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int e = elb[0], l = elb[1], b = elb[2];
bool[] isCow = new bool[e + 1];
for (int i = 0; i < b; i++)
{
    isCow[int.Parse(Console.ReadLine()!)] = true;
}

int[] dp = Enumerable.Repeat(MAX, e + 1).ToArray();
dp[0] = 0;

for (int i = 1; i <= e; i++)
{
    if (isCow[i])
    {
        continue;
    }

    for (int j = 0; j <= l; j++)
    {
        int target = i - j;
        if (target < 0)
        {
            break;
        }

        if (!isCow[target] && dp[target] != MAX)
        {
            dp[i] = Math.Min(dp[i], dp[target] + 1);
        }
    }
}

Console.WriteLine(dp[e]);