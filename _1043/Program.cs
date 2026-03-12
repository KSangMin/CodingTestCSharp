int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

int[] trues = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
if (trues[0] == 0)
{
    Console.WriteLine(m);
    return;
}
trues = trues[1..];

int[] parent = new int[n + 1];
for (int i = 1; i <= n; i++)
{
    parent[i] = i;
}

foreach(int t in trues)
{
    UnionRoot(trues[0], t);
}

List<int>[] parties = new List<int>[m];
for (int i = 0; i < m; i++)
{
    parties[i] = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();
    parties[i].RemoveAt(0);

    for(int j = 1; j < parties[i].Count; j++)
    {
        UnionRoot(parties[i][0], parties[i][j]);
    }
}

int ans = m;
int trueRoot = FindRoot(trues[0]);
foreach(List<int> party in parties)
{
    foreach(int person in party)
    {
        if(FindRoot(person) == trueRoot)
        {
            ans--;
            break;
        }
    }
}

Console.WriteLine(ans);

int FindRoot(int a)
{
    if (parent[a] == a)
    {
        return a;
    }
    return parent[a] = FindRoot(parent[a]);
}

void UnionRoot(int a, int b)
{
    int rootA = FindRoot(a);
    int rootB = FindRoot(b);

    if (rootA < rootB)
    {
        parent[rootB] = rootA;
    }
    else
    {
        parent[rootA] = rootB;
    }
}