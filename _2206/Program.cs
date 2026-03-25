const int D = 4;
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

string[] map = new string[n];
for (int i = 0; i < n; i++)
{
    map[i] = Console.ReadLine()!;
}

BFS(n, m , map);

void BFS(int n, int m, string[] map)
{
    int[,,] dist = new int[n, m, 2];
    Queue<(int y, int x, int broken)> q = new();
    q.Enqueue((0, 0, 0));
    dist[0, 0, 0] = 1;
    while (q.Count > 0)
    {
        var cur = q.Dequeue();

        if (cur.x == m - 1 && cur.y == n - 1)
        {
            Console.WriteLine(dist[cur.y, cur.x, cur.broken]);
            return;
        }

        for(int i = 0; i < D; i++)
        {
            int nx = cur.x + dx[i];
            int ny = cur.y + dy[i];

            if (nx < 0 || nx >= m||ny < 0 || ny >= n)
            {
                continue;
            }

            if (map[ny][nx] == '0'
                && dist[ny, nx, cur.broken] == 0)
            {
                dist[ny, nx, cur.broken] = dist[cur.y, cur.x, cur.broken] + 1;
                q.Enqueue((ny, nx, cur.broken));
            }
            else if(map[ny][nx] == '1'
                && cur.broken == 0
                && dist[ny, nx, 1] == 0)
            {
                dist[ny, nx, 1] = dist[cur.y, cur.x, cur.broken] + 1;
                q.Enqueue((ny, nx, 1));
            }
        }
    }

    Console.WriteLine(-1);
}