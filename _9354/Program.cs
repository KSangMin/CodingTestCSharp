using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] speed = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    char[] dir = Console.ReadLine()!.Split().Select(char.Parse).ToArray();

    long sum = 0;
    for(int j = n - 1; j >= 0; j--)
    {
        sum += dir[j] == 'T' ? speed[j] : -speed[j];
        sum = Math.Max(sum, 0);
    }

    sb.AppendLine(sum.ToString());
}

Console.Write(sb.ToString());