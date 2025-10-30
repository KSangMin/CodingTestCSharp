using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine()!);

    long mul = n * n;
    sb.AppendLine(mul.ToString());
}

Console.Write(sb.ToString());