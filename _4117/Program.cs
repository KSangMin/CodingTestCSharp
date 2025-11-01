using System.Text;

StringBuilder sb = new();

while (true)
{
    int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    if(nums[0] == 0)
    {
        break;
    }

    int n = nums[0];
    int t1 = nums[1];
    int t2 = nums[2];
    int diff21 = (t2 - t1 + n) % n;
    int t3 = nums[3];
    int diff32 = (t2 - t3 + n) % n;
    
    sb.AppendLine($"{n * 4 + diff21 + diff32 - 1}");
}

Console.Write(sb.ToString());