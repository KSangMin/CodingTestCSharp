using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    sb.AppendLine($"${double.Parse(Console.ReadLine()!) * 0.8:F2}");
}

Console.WriteLine(sb.ToString());