using System.Text;

Solution();

void Solution()
{
    int n = int.Parse(Console.ReadLine()!);
    char[,] map = new char[n, n * 2];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n * 2; j++)
        {
            map[i, j] = ' ';
        }
    }

    PrintStar(map, 0, n - 1, n);

    StringBuilder sb = new();
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n * 2; j++)
        {
            sb.Append(map[i, j]);
        }
        sb.AppendLine();
    }

    Console.Write(sb.ToString());
}

void PrintStar(char[,] map, int x, int y, int n)
{
    if(n == 3)
    {
        map[x, y] = '*';
        map[x + 1, y - 1] = '*';
        map[x + 1, y + 1] = '*';
        for(int i = y - 2; i <= y + 2; i++)
        {
            map[x + 2, i] = '*';
        }
    }
    else
    {
        int half = n / 2;
        PrintStar(map, x, y, half);
        PrintStar(map, x + half, y - half, half);
        PrintStar(map, x + half, y + half, half);
    }
}