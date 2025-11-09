using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < n; i++)
{
    string[] nx = Console.ReadLine()!.Split();
    sb.AppendLine(new string(nx[1][0], int.Parse(nx[0])));
}

Console.Write(sb.ToString());