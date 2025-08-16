int n = int.Parse(Console.ReadLine());

List<(int start, int end)> intervals = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] ab = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    intervals.Add((ab[0], ab[1]));
}

intervals.Sort((a, b) => a.start.CompareTo(b.start));

int K = int.Parse(Console.ReadLine());

int[] last = new int[K];

bool flag = true;
foreach (var (s, e) in intervals)
{
    for(int j = 0; j < K; j++)
    {
        if (last[j] <= s)
        {
            last[j] = e;
            break;
        }
        else if (j == K - 1) flag = false;
    }

    if (!flag)
    {
        break;
    }
}

Console.WriteLine(flag ? 1 : 0);