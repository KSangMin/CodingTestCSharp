const int d = 4;
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

int[] nm = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nm[0], m = nm[1], cheeseCount = 0;
bool[,] map = new bool[n, m];
for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    for (int j = 0; j < m; j++)
    {
        if (row[j] == 1)
        {
            cheeseCount++;
            map[i, j] = true;
        }

    }
}

int time = 0;
while (cheeseCount > 0)
{
    time++;
    MeltCheese(ref map);
}
Console.WriteLine(time);

void MeltCheese(ref bool[,] map)
{
    List<(int y, int x)> target = new();

    int[,] aired = GetCheeseAirCountList(map);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (map[i, j] && aired[i, j] >= 2)
            {
                target.Add((i, j));
                cheeseCount--;
            }
        }
    }

    foreach ((int y, int x) in target)
    {
        map[y, x] = false;
    }
}

int[,] GetCheeseAirCountList(bool[,] map)
{
    int n = map.GetLength(0), m = map.GetLength(1);
    bool[,] visited = new bool[n, m];
    int[,] aired = new int[n, m];

    Queue<(int y, int x)> q = new();
    q.Enqueue((0, 0));
    visited[0,0] = true;

    while(q.Count > 0)
    {
        (int y, int x) = q.Dequeue();
        for (int i = 0; i < d; i++)
        {
            int ny = y + dy[i];
            int nx = x + dx[i];

            if (0 <= ny && ny < n 
                && 0 <= nx && nx < m 
                && !visited[ny, nx])
            {
                if (map[ny, nx])
                {
                    aired[ny, nx]++;
                }
                else
                {
                    visited[ny, nx] = true;
                    q.Enqueue((ny, nx));
                }
            }
        }
    }

    return aired;
}