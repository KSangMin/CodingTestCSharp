int[] nm = Console.ReadLine ()!.Split().Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

int[] parent = new int[n];
for (int i = 0; i < n; i++)
{
    parent[i] = i;
}

for (int i = 0; i < m; i++ )
{
    int[] sd = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int sRoot = FindRoot(parent, sd[0]);
    int eRoot = FindRoot(parent, sd[1]);

    if (sRoot == eRoot)
    {
        Console.WriteLine(i + 1);
        return;
    }

    parent[eRoot] = sRoot;
}

Console.WriteLine(0);

int FindRoot(int[] parent, int node)
{
    return parent[node] == node ? node : parent[node] = FindRoot(parent, parent[node]);
}
