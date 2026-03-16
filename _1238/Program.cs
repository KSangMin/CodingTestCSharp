List<(int dest, int weight)>[] graph;
List<(int dest, int weight)>[] rGraph;
int x;

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    int[] nmx = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
    int n = nmx[0], m = nmx[1];
    x = nmx[2];

    graph = new List<(int, int)>[n + 1];
    rGraph = new List<(int, int)>[n + 1];

    for (int i = 1; i <= n; i++)
    {
        graph[i] = new();
        rGraph[i] = new();
    }

    for (int i = 0; i < m; i++)
    {
        int[] sdt = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
        int s = sdt[0], d = sdt[1], t = sdt[2];
        graph[s].Add((d, t));
        rGraph[d].Add((s, t));
    }
}

int max = 0;
int[] homeDist = Dijkstra(graph, x);
int[] toXDist = Dijkstra(rGraph, x);
for (int i = 1; i < homeDist.Length; i++)
{
    if (homeDist[i] == int.MaxValue || toXDist[i] == int.MaxValue)
    {
        continue;
    }

    max = Math.Max(max, homeDist[i] + toXDist[i]);
}

Console.WriteLine(max);

int[] Dijkstra(List<(int dest, int weight)>[] graph, int x)
{
    int[] dists = new int[graph.GetLength(0)];
    Array.Fill(dists, int.MaxValue);
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

        foreach((int next, int weight) in graph[cur])
        {
            if (weight == int.MaxValue || weight == 0)
            {
                continue;
            }

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