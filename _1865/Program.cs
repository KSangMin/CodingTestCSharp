int tc = int.Parse(Console.ReadLine()!);
for (int i = 0; i < tc; i++)
{
    Test();
}

void Test()
{
    int[] nmw = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int n = nmw[0], m = nmw[1], w = nmw[2];
    List<(int dest, int weight)>[] graph = new List<(int dest, int weight)>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        graph[i] = new();
    }

    for (int i = 0; i < m; i++)
    {
        int[] set = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int s = set[0], e = set[1], t = set[2];
        graph[s].Add((e, t));
        graph[e].Add((s, t));
    }

    for (int i = 0; i < w; i++)
    {
        int[] set = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int s = set[0], e = set[1], t = set[2];
        graph[s].Add((e, -t));
    }

    Console.WriteLine(BellmanFord(graph) ? "YES" : "NO");
}

bool BellmanFord(List<(int dest, int weight)>[] graph)
{
    int n = graph.Length;
    int[] dists = new int[n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 1; j < n; j++)
        {
            foreach(var edge in graph[j])
            {
                int sum = dists[j] + edge.weight;
                if (sum < dists[edge.dest])
                {
                    dists[edge.dest] = sum;

                    if(i == n - 1)
                    {
                        return true;
                    }
                }
            }
        }
    }

    return false;
}