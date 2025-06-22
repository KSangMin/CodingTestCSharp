int n = int.Parse(Console.ReadLine());

long[] first = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

for (int i = 1; i < n; i++)
{
    long[] next = new long[10];

    next[0] = first[1] % 1000000000;
    for (int j = 1; j <= 8; j++)
    {
        next[j] = (first[j - 1] + first[j + 1]) % 1000000000;
    }
    next[9] = first[8] % 1000000000;
    first = next;
}

Console.WriteLine(first.Sum() % 1000000000);