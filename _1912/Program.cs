int n = int.Parse(Console.ReadLine());

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] dp = new int[nums.Length];

dp[0] = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    dp[i] = (int)MathF.Max(nums[i], dp[i - 1] + nums[i]);
}

Console.WriteLine(dp.Max());