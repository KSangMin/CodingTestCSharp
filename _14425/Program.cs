int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();

int N = NM[0], M = NM[1];

HashSet<string> S = new();

for(int i = 0; i < N; i++)
{
    S.Add(Console.ReadLine());
}

int ans = 0;
for(int i = 0; i < M; i++)
{
    string str = Console.ReadLine();
    if (S.Contains(str))
    {
        ans++;
    }
}

Console.WriteLine(ans);