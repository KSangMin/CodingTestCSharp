using System.Text;

int n = int.Parse(Console.ReadLine()!);
int[] num = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int min = num[0];
int diff = 0;

StringBuilder sb = new();

for (int i = 0; i < n; i++)
{
    min = Math.Min(min, num[i]);
    diff = Math.Max(diff, num[i] - min);

    sb.Append($"{diff} ");
}

Console.WriteLine(sb.ToString().TrimEnd());
