using System.Text;

StringBuilder sb = new();

while (true)
{
    int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    if (nums[0] == -1)
    {
        break;
    }

    bool[] check = new bool[101];

    for (int i = 0; i < nums.Length - 1; i++)
    {
        check[nums[i]] = true;
    }

    int count = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] <= 50 && check[nums[i] * 2])
        {
            count++;
        }
    }

    sb.AppendLine(count.ToString());
}

Console.Write(sb.ToString());