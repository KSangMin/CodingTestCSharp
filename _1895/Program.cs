int[] rc = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int r = rc[0], c = rc[1];
List<List<int>> grid = new();
for(int i = 0; i < r; i++)
{
    grid.Add(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
}
int t = int.Parse(Console.ReadLine()!);

int count = 0;
for (int i = 0; i < r - 2; i++)
{
    for(int j = 0; j < c - 2; j++)
    {
        List<int> filter = new();
        for(int x = 0; x < 3; x++)
        {
            for(int y = 0; y < 3; y++)
            {
                filter.Add(grid[i + x][j + y]);
            }
        }

        filter.Sort();

        if(filter[4] >= t)
        {
            count++;
        }
    }
}

Console.WriteLine(count);