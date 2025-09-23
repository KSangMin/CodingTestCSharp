using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();

sb.Append('1');
for(int i = 2; i <= n; i++)
{
    sb.Append($" {i}");

    if(i % 6 == 0)
    {
        sb.Append(" Go!");
    }
}

if(n % 6 != 0)
{
    sb.Append(" Go!");
}

Console.WriteLine(sb.ToString());