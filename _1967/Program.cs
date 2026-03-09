int n = int.Parse(Console.ReadLine()!);
if (n == 1)
{
    Console.WriteLine(0);
    return;
}

List<(int to, int weight)>[] graph = new List<(int, int)>[n + 1];
for (int i = 1; i <= n; i++)
{
    graph[i] = new();
}

for (int i = 1; i < n; i++)
{
    int[] edge = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int parent = edge[0], child = edge[1], weight = edge[2];
    graph[parent].Add((child, weight));
    graph[child].Add((parent, weight));
}

var first = bfs(graph, 1);
var second = bfs(graph, first.node);

Console.WriteLine(second.dist);

(int node, int dist) bfs(List<(int to, int weight)>[] graph, int from)
{
    int[] dists = Enumerable.Repeat(-1, graph.Length).ToArray();

    Queue<int> q = new();
    q.Enqueue(from);
    dists[from] = 0;

    int node = from;
    int max = 0;
    while(q.Count > 0)
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