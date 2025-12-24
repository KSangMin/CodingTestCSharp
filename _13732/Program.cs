using System.Text;

int[] rc = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int r = rc[0], c = rc[1];

List<List<char>> grid = new();
for (int i = 0; i < r; i++)
{
    grid.Add(Console.ReadLine()!.ToList());
}

int count = 0;
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < r; j++)
    {
        char cur = grid[j][i];
        if (cur == 'a')
        {
            count++;
            grid[j][i] = '.';
        }

        if (count > 0 && 
            (cur == '#' || j == r - 1))
        {
            int target = cur == '#' ? 1 : 0;
            for (int k = target; k < count + target; k++)
            {
                grid[j - k][i] = 'a';
            }

            count = 0;
        }
    }
}

StringBuilder sb = new();
for (int i = 0; i < r; i++)
{
    sb.AppendLine(string.Join("", grid[i]));
}

Console.WriteLine(sb.ToString());