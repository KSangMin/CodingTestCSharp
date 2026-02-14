using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < n; i++)
{
    int angle = int.Parse(Console.ReadLine()!);

    int ans = (int)Math.Round((angle % 180) / 10f, MidpointRounding.AwayFromZero);
    if(ans == 0)
    {
        ans = 18;
    }
    sb.AppendLine($"{ans:D2}");
}

Console.Write(sb.ToString());