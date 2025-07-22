string[] ab = Console.ReadLine().Split();

string a = ab[0], b = ab[1];

int max = (int)MathF.Max(a.Length, b.Length);
int[] nums = new int[max];

for(int i = max - 1; i >= 0; i--)
{
    int aIdx = i - (max - a.Length);
    int bIdx = i - (max - b.Length);

    if (0 <= aIdx)
    {
        nums[i] += (a[aIdx] - '0');
    }
    if (0 <= bIdx)
    {
        nums[i] += (b[bIdx] - '0');
    }
}

Console.WriteLine(string.Concat(nums));