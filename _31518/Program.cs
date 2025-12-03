int n = int.Parse(Console.ReadLine()!);

bool flag = true;
for (int i = 0; i < 3; i++)
{
    int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    if (flag)
    {
        flag = nums.Contains(7); 
    }
}

Console.WriteLine(flag ? 777 : 0);