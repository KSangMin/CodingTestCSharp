using System.Text;

int z = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < z; i++)
{
    int[] wk = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int w = wk[0], k = wk[1];

    int ans = (w / 2) * (k / 2) * 2;
    if (w % 2 == 1)
    {
        ans += k / 2;
    }
    if (k % 2 == 1)
    {
        ans += w / 2;
    }

    sb.AppendLine(ans.ToString());
}

Console.Write(sb.ToString());