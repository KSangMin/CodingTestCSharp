using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;

    sb.AppendLine(s.Last() == '.' ? s : s + '.');
}

Console.Write(sb.ToString());