const int MAX = 10000;
//입력
int[] nmr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nmr[0], m = nmr[1], r = nmr[2];
int[] items = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
List<(int d, int w)>[] graph = new List<(int d, int w)>[n + 1];
for(int i = 1; i <= n; i++)
{
    graph[i] = new();
}
for(int i = 0; i < r; i++)
{
    int[] abl = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    graph[abl[0]].Add((abl[1], abl[2]));
    graph[abl[1]].Add((abl[0], abl[2]));
}

//계산
int max = 0;
for(int i = 1; i <= n; i++)
{
    int[] dists = Dijkstra(graph, i);

    int sum = 0;
    for(int j = 1; j <= n; j++)
    {
        if (dists[j] <= m)
        {
            sum += items[j - 1];
        }
    }

    max = Math.Max(sum, max);
}

//출력
Console.WriteLine(max);

//다익스트라
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