using System.Text;

int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
int[] dy = { 1, 0, -1, 1, -1, 1, 0, -1 };

while (true)
{
    int[] rc = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int r = rc[0], c = rc[1];

    if (r == 0 && c == 0) break;

    char[,] grid = new char[r, c];
    int[,] points = new int[r, c];

    for (int i = 0; i < r; i++)
    {
        string line = Console.ReadLine();
        for (int j = 0; j < c; j++)
        {
            grid[i, j] = line[j];
        }
    }

    for (int i = 0; i < r; i++)
    {
        for(int j = 0; j < c; j++)
        {
            if (grid[i, j] == '*')
            {
                for(int d = 0; d < 8; d++)
                {
                    int ni = i + dx[d], nj = j + dy[d];
                    if (0 <= ni && ni < r && 0 <= nj && nj < c)
                    {
                        points[ni, nj]++;
                    }
                }
            }
        }
    }

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (grid[i, j] == '*') sb.Append('*');
            else sb.Append(points[i, j]);
        }
        sb.AppendLine();
    }
    Console.Write(sb.ToString());
}