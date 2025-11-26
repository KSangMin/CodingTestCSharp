int[] nk = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];

List<int> diff = new();
for (int i = 0; i < n; i++)
{
    int[] ab = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int d = ab[1] - ab[0];
    if (d > 0)
    {
        diff.Add(d);
    }
}

diff.Sort();

int c = n - diff.Count;
if (c >= k)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(diff[k - c - 1]);
}