const int D = 4;
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

//입력
int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

int[,] map = new int[n, m];
List<(int y, int x)> wallCand = new();
List<(int y, int x)> virus = new();
for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    for (int j = 0; j < m; j++)
    {
        map[i, j] = row[j];

        if (map[i, j] == 0)
        {
            wallCand.Add((i, j));
        }
        else if (map[i, j] == 2)
        {
            virus.Add((i, j));
        }
    }
}

//계산
int max = 0;
for (int i = 0; i < wallCand.Count - 2; i++)
{
    for (int j = i + 1; j < wallCand.Count - 1; j++)
    {
        for (int k = j + 1; k < wallCand.Count; k++)
        {
            int[,] blocked = (int[,])map.Clone();

            blocked[wallCand[i].y, wallCand[i].x] = 1;
            blocked[wallCand[j].y, wallCand[j].x] = 1;
            blocked[wallCand[k].y, wallCand[k].x] = 1;

            max = Math.Max(max, BFS(blocked, virus));
        }
    }
}

//출력
Console.WriteLine(max);

//BFS
int BFS(int[,] map, List<(int y, int x)> virus)
{
    int rows = map.GetLength(0);
    int cols = map.GetLength(1);

    Queue<(int y, int x)> q = new();
    foreach (var v in virus)
    {
        q.Enqueue(v);
    }

    while (q.Count > 0)
    {
        var p = q.Dequeue();

        for (int i = 0; i < D; i++)
        {
            int ny = p.y + dy[i];
            int nx = p.x + dx[i];

            if (0 <= ny && ny < rows
                && 0 <= nx && nx < cols
                && map[ny, nx] == 0)
            {
                map[ny, nx] = 2;
                q.Enqueue((ny, nx));
            }
        }
    }

    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (map[i, j] == 0)
            {
                count++;
            }
        }
    }

    return count;
}