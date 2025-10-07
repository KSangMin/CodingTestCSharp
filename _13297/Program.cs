using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;
    sb.AppendLine(s.Length.ToString());
}

Console.Write(sb.ToString());