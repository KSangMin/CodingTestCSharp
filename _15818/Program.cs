int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();

int m = NM[1];

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

long ans = nums[0] % m;

for (int i = 1; i < nums.Length; i++)
{
    ans = (ans * (nums[i] % m)) % m;
}

Console.WriteLine(ans);