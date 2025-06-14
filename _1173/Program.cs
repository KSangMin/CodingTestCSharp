int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int N = input[0], m = input[1], M = input[2], T = input[3], R = input[4];

if (M - m < T)
{
    Console.WriteLine(-1);
    return;
}

int count = 0, cur = m, ans = 0;
while (count < N)
{
    if (cur + T <= M)
    {
        cur += T;
        count++;
    }
    else cur = (int)MathF.Max(m, cur - R);

    ans++;
}

Console.WriteLine(ans);