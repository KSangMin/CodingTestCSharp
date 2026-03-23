const int DN = 4;
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

int[] rct = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int r = rct[0], c = rct[1], t = rct[2];
int[,] room = new int[r, c];
List<(int y, int x)> circulator = new();
for (int i = 0; i < r; i++)
{
    int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    for (int j = 0; j < c; j++)
    {
        room[i, j] = input[j];
        if (input[j] == -1)
        {
            circulator.Add((i, j));
        }
    }
}

for (int i = 0; i < t; i++)
{
    SpreadDust(room);
    CirculateAir(room, circulator);
}

int sum = 0;
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        if (room[i, j] > 0)
        {
            sum += room[i, j];
        }
    }
}

Console.WriteLine(sum);

void SpreadDust(int[,] room)
{
    int r = room.GetLength(0);
    int c = room.GetLength(1);
    int[,] temp = new int[r, c];

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (room[i, j] <= 0)
            {
                continue;
            }

            int oneFifth = room[i, j] / 5;
            for (int k = 0; k < DN; k++)
            {
                int ny = i + dy[k];
                int nx = j + dx[k];

                if (0 <= nx && nx < c
                    && 0 <= ny && ny < r
                    && room[ny, nx] >= 0)
                {
                    room[i, j] -= oneFifth;
                    temp[ny, nx] += oneFifth;
                }
            }
        }
    }

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            room[i, j] += temp[i, j];
        }
    }
}

void CirculateAir(int[,] room, List<(int y, int x)> circulator)
{
    Circulate(room, circulator[0].y, circulator[0].x, true);
    Circulate(room, circulator[1].y, circulator[1].x, false);
}

void Circulate(int[,] room, int y, int x, bool clockWise)
{
    int[] way;
    if (clockWise)
    {
        way = new[] { 2, 3, 0, 1, 2 };
    }
    else
    {
        way = new[] { 2, 1, 0, 3, 2 };
    }

    int cY = y;
    int cX = x;
    for (int i = 0; i < way.Length; i++)
    {
        int dir = way[i];

        while (true)
        {
            int nX = cX + dx[dir];
            int nY = cY + dy[dir];

            if (0 > nX || nX >= room.GetLength(1)
            || 0 > nY || nY >= room.GetLength(0))
            {
                break;
            }
            else if(nX == x && nY == y)
            {
                room[cY, cX] = 0;
                break;
            }

            if (cX == x && cY == y)
            {
                room[nY, nX] = 0;
            }
            else
            {
                room[cY, cX] = room[nY, nX];
            }

            cX = nX;
            cY = nY;

            if (i % 2 == 1 && cY == y)
            {
                break;
            }
        }
    }
}