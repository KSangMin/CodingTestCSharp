using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int sum = num.Sum();
    int count = 1;
    while(sum <= n)
    {
        count++;
        sum *= 4;
    }

    sb.AppendLine(count.ToString());
}

Console.Write(sb.ToString());