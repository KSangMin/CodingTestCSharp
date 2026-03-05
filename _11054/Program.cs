int n = int.Parse(Console.ReadLine()!);
int[] num = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] dp = new int[n];
int[] dpReverse = new int[n];
dp[0] = 1;
dpReverse[n - 1] = 1;

for(int i = 1; i < n; i++)
{
    int max = 0;
    for(int j = 0; j < i; j++)
    {
        if (num[j] < num[i])
        {
            max = Math.Max(max, dp[j]);
        }
    }
    dp[i] = max + 1;

    max = 0;
    for(int j = n - 1; j > n - 1 - i; j--)
    {
        if (num[j] < num[n - 1 - i])
        {
            max = Math.Max(max, dpReverse[j]);
        }
    }
    dpReverse[n - 1 - i] = max + 1;
}

int ans = 0;
for(int i = 0; i < n; i++)
{
    ans = Math.Max(ans, dp[i] + dpReverse[i]);
}

Console.WriteLine(ans - 1);