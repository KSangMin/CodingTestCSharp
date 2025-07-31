int n = int.Parse(Console.ReadLine());
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

long sum = 0;
long ans = 0;
for(int i = n - 1; i >= 0; i--)
{
    ans += nums[i] * sum;
    sum += nums[i];
}

Console.WriteLine(ans);