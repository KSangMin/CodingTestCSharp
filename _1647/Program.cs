using StreamReader sr = new(Console.OpenStandardInput());

int[] nm = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];
List<(int start, int end, int weight)> graph = new();
for(int i = 0; i < m; i++)
{
    int[] edge = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    graph.Add((edge[0], edge[1], edge[2]));
}

graph = graph.OrderBy(x => x.weight).ToList();

int[] parent = new int[n + 1];
for (int i = 1; i <= n; i++)
{
    parent[i] = i;
}
long total = 0;
int count = 0;
foreach((int start, int end, int weight) in graph)
{
    if(count == n - 2)
    {
        break;
    }

    if(FindRoot(parent, start) != FindRoot(parent, end))
    {
        Union(parent, start, end);
        total += weight;
        count++;
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