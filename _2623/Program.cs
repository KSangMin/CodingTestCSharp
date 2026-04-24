﻿using System.Text;

int[] nm = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];
List<int>[] latter = new List<int>[n + 1];
int[] count = new int[n + 1];
for (int i = 1; i <= n; i++)
{
    latter[i] = new();
}

for (int i = 0; i < m; i++)
{
    int[] order = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    for(int j = 1; j < order[0]; j++)
    {
        latter[order[j]].Add(order[j + 1]);
        count[order[j + 1]]++;
    }
}

Queue<int> q = new();
for (int i = 1; i <= n; i++)
{
    if (count[i] == 0)
    {
        q.Enqueue(i);
    }
}

List<int> result = new();
while (q.Count > 0)
{
    int cur = q.Dequeue();
    result.Add(cur);

    for (int i = 0; i < latter[cur].Count; i++)
    {
        int next = latter[cur][i];
        count[next]--;
        if (count[next] == 0)
        {
            q.Enqueue(next);
        }
    }
}

Console.WriteLine(result.Count == n ? string.Join("\n", result) : 0);