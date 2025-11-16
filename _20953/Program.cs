using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    int[] ab = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    long sum = ab[0] + ab[1];
    sb.AppendLine($"{sum * sum * (sum - 1) / 2}");
}

Console.Write(sb.ToString());