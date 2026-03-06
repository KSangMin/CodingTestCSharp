int[] nk = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];
int[] time = new int[100001];
int[] count = new int[100001];

Queue<int> q = new();
q.Enqueue(n);
count[n] = 1;
while (q.Count > 0)
{
    int cur = q.Dequeue();

    if(cur == k)
    {
        continue;
    }

    int[] next = { cur - 1, cur + 1, cur * 2 };

    foreach(int np in next)
    {
        if(0 <= np && np <= 100000)
        {
            if (time[np] == 0) 
            {
                time[np] = time[cur] + 1;
                count[np] = count[cur];
                q.Enqueue(np);
            }
            else if (time[np] == time[cur] + 1)
            {
                count[np] += count[cur];
            }
        }
    }
}

Console.WriteLine($"{time[k]}\n{count[k]}");