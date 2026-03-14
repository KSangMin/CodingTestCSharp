using System.Text;

int n, m;
int[,] dist;

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    n = int.Parse(sr.ReadLine()!);
    m = int.Parse(sr.ReadLine()!);
    dist = new int[n + 1, n + 1];

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            dist[i, j] = int.MaxValue;
        }
        dist[i, i] = 0;
    }

    for (int i = 0; i < m; i++)
    {
        int[] bus = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int s = bus[0], d = bus[1], w = bus[2];

        dist[s, d] = Math.Min(dist[s, d], w);
    }
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= n; k++)
        {
            if (dist[j, i] == int.MaxValue || dist[i, k] == int.MaxValue)
            {
                continue;
            }

            int sum = dist[j, i] + dist[i, k];

            dist[j, k] = Math.Min(dist[j, k], sum);
        }
    }
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        if (dist[i, j] == int.MaxValue)
        {
            dist[i, j] = 0;
        }
    }
}

StringBuilder sb = new();
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        sb.Append($"{dist[i, j]} ");
    }
    sb.AppendLine();
}

Console.Write(sb.ToString());