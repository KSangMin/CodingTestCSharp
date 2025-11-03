using System.Text;

int[] fee = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    int t = int.Parse(Console.ReadLine()!);

    if(t <= 1000)
    {
        sb.AppendLine($"{t} {fee[0] * t}");
    }
    else
    {
        sb.AppendLine($"{t} {fee[0] * 1000 + fee[1] * (t - 1000)}");
    }
}

Console.Write(sb.ToString());