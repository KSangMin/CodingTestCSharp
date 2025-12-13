int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

int n = 138;
char[][] grid = new char[n][];
for (int i = 0; i < n; i++)
{
    grid[i] = Console.ReadLine()!.ToCharArray();
}

int ans = 0;
while (true)
{
    int count = CountRolls(grid);
    if (count == 0)
    {
        break;
    }

    ans += count;
}

Console.WriteLine(ans);

int CountRolls(char[][] grid)
{
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (grid[i][j] == '@')
            {
                int atCount = 0;
                for (int d = 0; d < 8; d++)
                {
                    int nX = i + dx[d];
                    int nY = j + dy[d];

                    if (nX >= 0 && nX < n
                        && nY >= 0 && nY < n
                        && grid[nX][nY] == '@')
                    {
                        atCount++;
                    }

                    if (atCount >= 4)
                    {
                        break;
                    }
                }

                if (atCount < 4)
                {
                    grid[i][j] = '.';
                    count++;
                }
            }
        }
    }

    return count;
}