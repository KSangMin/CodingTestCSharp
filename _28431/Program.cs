List<int> nums = new();

for(int i = 0; i < 5; i++)
{
    int n = int.Parse(Console.ReadLine());

    if(!nums.Contains(n))
    {
        nums.Add(n);
    }
    else
    {
        nums.Remove(n);
    }
}

Console.WriteLine(nums[0]);