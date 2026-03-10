List<(int to, int weight)>[] graph;

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    int n = int.Parse(sr.ReadLine()!);

    graph = new List<(int, int)>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        graph[i] = new();
    }

    for (int i = 0; i < n; i++)
    {
        int[] edge = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        for (int j = 1; j < edge.Length - 1; j += 2)
        {
            int parent = edge[0], child = edge[j], weight = edge[j + 1];

            graph[parent].Add((child, weight));
        }
    }
}

var first = bfs(graph, 1);
var second = bfs(graph, first.node);

Console.WriteLine(second.dist);

(int node, int dist) bfs(List<(int to, int weight)>[] graph, int from)
{
    int[] dists = new int[graph.Length];
    Array.Fill(dists, -1);

    Queue<int> q = new();
    q.Enqueue(from);
    dists[from] = 0;

    int node = from;
    int max = 0;
    while (q.Count > 0)
    {
        int cur = q.Dequeue();

        foreach (var (to, weight) in graph[cur])
        {
            if (dists[to] == -1)
            {
                dists[to] = dists[cur] + weight;
                q.Enqueue(to);

                if (dists[to] > max)
                {
                    max = dists[to];
                    node = to;
                }
            }
        }
    }

    return (node, max);
}