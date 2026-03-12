int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

int[] trues = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
trues = trues[1..];

List<int>[] parties = new List<int>[m];
bool[,] graph = new bool[n + 1, n + 1];
for(int i = 0; i < m; i++)
{
    parties[i] = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();
    parties[i].RemoveAt(0);
    for(int j = 0; j < parties[i].Count; j++)
    {
        for(int k = j + 1; k < parties[i].Count; k++)
        {
            graph[parties[i][j], parties[i][k]] = true;
            graph[parties[i][k], parties[i][j]] = true;
        }
    }
}

bool[] knowing = new bool[n + 1];
bool[] check = new bool[n + 1];
Queue<int> q = new();
foreach(int t in trues)
{
    q.Enqueue(t);
}

while(q.Count > 0)
{
    int cur = q.Dequeue();
    if (check[cur])
    {
        continue;
    }

    check[cur] = true;
    knowing[cur] = true;

    for(int i = 1; i <= n; i++)
    {
        if (graph[cur, i])
        {
            q.Enqueue(i);
        }
    }
}

int ans = m;
foreach (List<int> party in parties)
{
    foreach(int person in party)
    {
        if (knowing[person])
        {
            ans--;
            break;
        }
    }
}

Console.WriteLine(ans);