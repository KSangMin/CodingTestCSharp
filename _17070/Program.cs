int n = int.Parse(Console.ReadLine()!);

List<List<int>> graph = new();

for (int i = 0; i < n; i++)
{
    graph.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
}

int count = 0;

Dfs(0, 1, 0);

Console.WriteLine(count);

void Dfs(int y, int x, int dir)
{
    if (x < 0 || x >= n || y < 0 || y >= n || graph[y][x] == 1)
    {
        return;
    }
    if(dir == 2 && (graph[y][x - 1] == 1 || graph[y - 1][x] == 1))
    {
        return;
    }

    if (y == n - 1 && x == n - 1)
    {
        count++;
        return;
    }

    if (dir == 0 || dir == 2)
    {
        Dfs(y, x + 1, 0);
    }
    if (dir == 1 || dir == 2)
    {
        Dfs(y + 1, x, 1);
    }
    Dfs(y + 1, x + 1, 2);
}