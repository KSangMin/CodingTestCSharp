const int MAX = 2400001;

List<(int dest, int weight)>[] graph;
int n, u, v;

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    int[] ne = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    n = ne[0];
    int e = ne[1];
    graph = new List<(int dest, int weight)>[n + 1];
    for(int i = 1; i <= n; i++)
    {
        graph[i] = new();
    }

    for(int i = 0; i < e; i++)
    {
        int[] abc = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int a = abc[0], b = abc[1], c = abc[2];
        graph[a].Add((b, c));
        graph[b].Add((a, c));
    }

    int[] uv = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    u = uv[0];
    v = uv[1];
}

int[] start = Dijkstra(graph, 1);
int[] first = Dijkstra(graph, u);
int[] second = Dijkstra(graph, v);

long u_v = start[u] + first[v] + second[n];
long v_u = start[v] + second[u] + first[n];

long ans = Math.Min(u_v, v_u);

Console.WriteLine(ans >= MAX ? -1 : ans);

int[] Dijkstra(List<(int dest, int weight)>[] graph, int x)
{
    int[] dists = new int[graph.GetLength(0)];
    Array.Fill(dists, MAX);
    dists[x] = 0;

    PriorityQueue<int, int> q = new();
    q.Enqueue(x, dists[x]);

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
                q.Enqueue(next, dists[next]);
            }
        }
    }

    return dists;
}