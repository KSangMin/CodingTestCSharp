int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nm[0], m = nm[1];

int[,] map = new int[n, m];

for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine().Select(c => c - '0').ToArray();
    for (int j = 0; j < m; j++)
    {
        map[i, j] = row[j];
    }
}

int max = 1;
for(int range = 1; range <= n; range++)
{
    for (int y = 0; y < n - range; y++)
    {
        for (int x = 0; x < m - range; x++)
        {
            max = (int)MathF.Max(max, FindArea(map, x, y, range));

            if (max >= GetArea(range)) break;
        }

        if (max >= GetArea(range)) break;
    }
}

Console.WriteLine(max);

int FindArea(int[,] map, int x, int y, int range)
{
    int start = map[y, x]
        , r = map[y + range, x]
        , d = map[y, x + range]
        , dr = map[y + range, x + range];
    if(start == r && start == d && start == dr)
    {
        return GetArea(range);
    }

    return 0;
}

int GetArea(int a) => (a + 1) * (a + 1);