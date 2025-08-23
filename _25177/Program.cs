int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NM[0], M = NM[1];

int[] cur = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] prev = Console.ReadLine().Split().Select(int.Parse).ToArray();

int max = 0;
for(int i = 0; i < Math.Max(N, M); i++)
{
    int curP = 0, prevP = 0;

    if(i < N) curP = cur[i];
    if(i < M) prevP = prev[i];

    max = Math.Max(max, prevP - curP);
}

Console.WriteLine(max);