int[] nmk = Console.ReadLine().Split().Select(int.Parse).ToArray();

long n = nmk[0], m = nmk[1], k = nmk[2];

if(n + m - 1 <= k)
{
    int[] row = new int[m];
    for(int i = 0; i < m; i++)
    {
        row[i] = i + 1;
    }

    Console.WriteLine("YES");
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine(string.Join(" ", row.Select(x => x + i)));
    }
}
else Console.WriteLine("NO");