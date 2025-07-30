int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NM[0], M = NM[1];

int[] Ks = Console.ReadLine().Split().Select(int.Parse).ToArray();

int ans = 0;
for (int i = 1; i <= N; i++)
{
    for(int j = 0; j < M; j++)
    {
        if (i % Ks[j] == 0)
        {
            ans += i;
            break;
        }
    }
}

Console.WriteLine(ans);