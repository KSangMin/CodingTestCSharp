int[] ve = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int v = ve[0], e = ve[1];

List<(int start, int end, int weight)> graph = new();

for (int i = 0; i < e; i++)
{
    int[] edge = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int a = edge[0], b = edge[1], c = edge[2];

    graph.Add((a, b, c));
}

graph = graph.OrderBy(x => x.weight).ToList();
int[] parent = new int[v + 1];
for(int i = 1; i <= v; i++)
{
    parent[i] = i;
}

long total = 0;
foreach((int start, int end, int weight) in graph)
{
    if(FindRoot(parent, start) != FindRoot(parent, end))
    {
        Union(parent, start, end);
        total += weight;
    }
}

Console.WriteLine(total);

void Union(int[] parent, int a, int b)
{
    int rootA = FindRoot(parent, a);
    int rootB = FindRoot(parent, b);
    if (rootA != rootB)
    {
        parent[rootB] = rootA;
    }
}

int FindRoot(int[] parent, int node)
{
    if (parent[node] == node)
    {
        return node;
    }
    return parent[node] = FindRoot(parent, parent[node]);
}