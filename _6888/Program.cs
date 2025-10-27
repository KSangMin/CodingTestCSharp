using System.Text;

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
while(x <= y)
{
    sb.AppendLine($"All positions change in year {x}");
    x += 60;
}

Console.Write(sb.ToString());