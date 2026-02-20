using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine()!;
    sb.AppendLine(Math.Min(s.Count(c => c == 'a'), s.Count(c => c == 'b')).ToString());
}

Console.Write(sb.ToString());