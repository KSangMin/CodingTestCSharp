int[] rc = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int r = rc[0], c = rc[1];
char[,] map = new char[r, c];
for(int i = 0; i < r; i++)
{
    string s = Console.ReadLine()!;
    for(int j = 0; j < c; j++)
    {
        map[i, j] = s[j];
    }
}

for(int i = 0; i < r; i++)
{
    for(int j = 0; j < c; j++)
    {
        if(map[i, j] == 'o')
        {
            Fight(map, i, j);
        }
    }
}

int lamb = 0, wolf = 0;
for (int i = 0; i < r; i++)
{
    for(int j = 0; j < c; j++)
    {
        if(map[i, j] == 'o')
        {
            lamb++;
        }
        else if(map[i, j] == 'v')
        {
            wolf++;
        }
    }
}

Console.WriteLine($"{lamb} {wolf}");

void Fight(char[,] map, int y, int x)
{
    int[] dx = {1, 0, -1, 0};
    int[] dy = {0, 1, 0, -1};

    Queue<(int y, int x)> q = new();
    int r = map.GetLength(0), c = map.GetLength(1);
    bool[,] visited = new bool[r, c];
    q.Enqueue((y, x));
    visited[y, x] = true;

    List<(int y, int x)> lamb = new();
    lamb.Add((y, x));
    List<(int y, int x)> wolf = new();

    while (q.Count > 0)
    {
        (int cY, int cX) = q.Dequeue();

        for(int i = 0; i < 4; i++)
        {
            int ny = cY + dy[i];
            int nx = cX + dx[i];
            if(0<= ny && ny < r && 0 <= nx && nx < c)
            {
                if(!visited[ny, nx] && map[ny, nx] != '#')
                {
                    visited[ny, nx] = true;
                    q.Enqueue((ny, nx));

                    if(map[ny, nx] == 'o')
                    {
                        lamb.Add((ny, nx));
                    }
                    else if(map[ny, nx] == 'v')
                    {
                        wolf.Add((ny, nx));
                    }
                }
            }
        }
    }

    if(lamb.Count > wolf.Count)
    {
        foreach(var w in wolf)
        {
            map[w.y, w.x] = '.';
        }
    }
    else
    {
        foreach(var l in lamb)
        {
            map[l.y, l.x] = '.';
        }
    }
}