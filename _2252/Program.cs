using System.Text;

int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];
List<int>[] latter = new List<int>[n + 1];
int[] count = new int[n + 1];
for(int i = 1; i <= n; i++)
{
    latter[i] = new();
}

for (int i = 0; i < m; i++)
{
    int[] ab = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    latter[ab[0]].Add(ab[1]);
    count[ab[1]]++;
}

Queue<int> q = new();
for(int i = 1; i <= n; i++)
{
    if (count[i] == 0)
    {
        q.Enqueue(i);
    }
}

StringBuilder sb = new();
while(q.Count > 0)
{
    int cur = q.Dequeue();
    sb.Append($"{cur} ");

    for(int i = 0; i < latter[cur].Count; i++)
    {
        int next = latter[cur][i];
        count[next]--;
        if (count[next] == 0)
        {
            q.Enqueue(next);
        }
    }
}

Console.WriteLine(sb.ToString());