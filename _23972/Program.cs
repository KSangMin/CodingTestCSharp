int[] kn = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

long k = kn[0], n = kn[1];

long ans = -1;

if(n != 1)
{
    ans = n * k / (n - 1);
    if(n * k % (n - 1) != 0)
    {
        ans++;
    }
}

Console.WriteLine(ans);