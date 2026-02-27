using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();

sb.AppendLine(new string(' ', n - 1) + '*');
for (int i = 1; i < n; i++)
{
    sb.Append(new string(' ', n - i - 1));
    sb.Append('*');
    sb.Append(new string(' ', 2 * i - 1));
    sb.AppendLine("*");
}

Console.Write(sb.ToString());