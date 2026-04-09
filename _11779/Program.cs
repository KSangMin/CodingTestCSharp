const int MAX = 200000001;
int n, m, start, dest;
List<(int dest, int weight)>[] graph;
using(StreamReader sr = new(Console.OpenStandardInput()))
{
    n = int.Parse(sr.ReadLine()!);
    m = int.Parse(sr.ReadLine()!);
    graph = new List<(int dest, int weight)>[n + 1];
    for(int i = 1; i <= n; i++)
    {
        graph[i] = new();
    }

    for(int i = 0; i < m; i++)
    {
        int[] sdw = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
        graph[sdw[0]].Add((sdw[1], sdw[2]));
    }
    
    int[] sd = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
    start = sd[0];
    dest = sd[1];
}

Dijkstra(graph, start, dest);

void Dijkstra(List<(int dest, int weight)>[] graph, int start, int dest)
{
    int[] dists = new int[graph.GetLength(0)];
    Array.Fill(dists, MAX);
    dists[start] = 0;

    PriorityQueue<int, int> q = new();
    int[] parent = new int[graph.Length];
    q.Enqueue(start, dists[start]);

    while (q.Count > 0)
    {
        q.TryDequeue(out int cur, out int d);

        if (d > dists[cur])
        {
            continue;
        }

        foreach ((int next, int weight) in graph[cur])
        {
            int nD = d + weight;
            if (nD < dists[next])
            {
                dists[next] = nD;
                parent[next] = cur;
                q.Enqueue(next, dists[next]);
            }
        }
    }

    Console.WriteLine(dists[dest]);
    Stack<int> path = new();
    path.Push(dest);
    while (path.Peek() != start)
    {
        path.Push(parent[path.Peek()]);
    }
    Console.WriteLine(path.Count);
    Console.WriteLine(string.Join(' ', path));
}