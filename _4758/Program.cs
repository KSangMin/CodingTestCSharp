using System.Text;

StringBuilder sb = new();

while (true)
{
    float[] nums = Console.ReadLine()!.Split().Select(float.Parse).ToArray();

    if (nums.Contains(0))
    {
        break;
    }

    float ss = nums[0];
    float mw = nums[1];
    float ms = nums[2];

    StringBuilder sb2 = new();

    if(ss <= 4.5f && mw >=150 && ms >=200)
    {
        sb2.Append("Wide Receiver ");
    }
    if (ss <= 6.0f && mw >= 300 && ms >= 500)
    {
        sb2.Append("Lineman ");
    }
    if (ss <= 5.0f && mw >= 200 && ms >= 300)
    {
        sb2.Append("Quarterback ");
    }
    if(sb2.Length == 0)
    {
        sb2.Append("No positions");
    }
    sb.AppendLine(sb2.ToString());
}

Console.Write(sb.ToString());