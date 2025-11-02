int n = int.Parse(Console.ReadLine()!);
int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int max = 0;
int min = nums[0];
int cur = nums[0];

for (int i = 1; i < n; i++)
{
    if(nums[i] > cur)
    {
        max = Math.Max(max, nums[i] - min);
    }
    else
    {
        min = nums[i];
    }
    cur = nums[i];
}

Console.WriteLine(max);