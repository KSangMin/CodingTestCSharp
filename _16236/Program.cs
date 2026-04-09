int n = int.Parse(Console.ReadLine()!);
int[,] map = new int[n, n];
Shark shark = new(0, 0);
List<(int y, int x, int size)> fishes = new();
for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        map[i, j] = row[j];

        if (row[j] == 9)
        {
            shark = new(i, j);
            map[i, j] = 0;
        }
    }
}

int time = 0;
while (true)
{
    var (y, x, d) = shark.FindTarget(map);
    if (y == -1 || x == -1 || d == -1)
    {
        break;
    }

    shark.MoveToTarget(y, x);
    shark.Eat();
    map[y, x] = 0;
    time += d;
}

Console.WriteLine(time);

class Shark
{
    private (int y, int x) _pos;
    public (int y, int x) Pos => _pos;
    private int _size = 2;
    private int _eatenCount = 0;
    const int D = 4;
    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };

    public Shark(int y, int x)
    {
        _pos = (y, x);
    }

    public (int y, int x, int dist) FindTarget(int[,] map)
    {
        List<(int y, int x, int dist)> fishes = new();

        int n = map.GetLength(0);
        bool[,] visited = new bool[n, n];
        Queue<(int y, int x, int dist)> q = new();
        visited[Pos.y, Pos.x] = true;
        q.Enqueue((Pos.y, Pos.x, 0));
        int min = int.MaxValue;

        while (q.Count > 0)
        {
            var cur = q.Dequeue();

            if (cur.dist > min)
            {
                break;
            }

            for (int i = 0; i < D; i++)
            {
                int ny = cur.y + dy[i];
                int nx = cur.x + dx[i];

                if (0 <= ny && ny < n
                    && 0 <= nx && nx < n
                    && !visited[ny, nx]
                    && map[ny, nx] <= _size)
                {
                    int nDist = cur.dist + 1;
                    visited[ny, nx] = true;
                    if (0 < map[ny, nx] && map[ny, nx] < _size && nDist <= min)
                    {
                        min = nDist;
                        fishes.Add((ny, nx, nDist));
                    }

                    if (nDist < min)
                    {
                        q.Enqueue((ny, nx, nDist));
                    }
                }
            }
        }

        fishes = fishes.OrderBy(f => f.y).ThenBy(f => f.x).ToList();

        return fishes.Count > 0 ? fishes[0] : (-1, -1, -1);
    }

    public void MoveToTarget(int y, int x)
    {
        _pos = (y, x);
    }

    public void Eat()
    {
        _eatenCount++;
        if (_eatenCount >= _size)
        {
            _size++;
            _eatenCount = 0;
        }
    }
}