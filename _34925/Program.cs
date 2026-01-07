long[] hs = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

Console.WriteLine(Fight(hs[0], hs[1]));

long Fight(long h, long s)
{
    long total = h;

    if (h > 4)
    {
        total = h + s * 3;
    }
    else if (h > 2)
    {
        total = h + s * 2;
    }

    return (total + 1) / 2;
}