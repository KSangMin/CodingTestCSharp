using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for (int i = 0; i < t; i++)
{
    int[] mdw = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int m = mdw[0], d = mdw[1], w = mdw[2];

    int row = 0;
    int wid = 0;
    for (int j = 0; j < m; j++)
    {
        row += (wid + d + w - 1) / w;
        wid = (wid + d) % w;
    }

    sb.AppendLine($"Case #{i + 1}: {row}");
}

Console.Write(sb.ToString());