string[] s = Console.ReadLine()!.Split(',');

long ans = 0;
foreach (string range in s)
{
    long[] ab = range.Split('-').Select(long.Parse).ToArray();

    for(long i = ab[0]; i <= ab[1]; i++)
    {
        string num = i.ToString();
        if(num.Length % 2 == 1)
        {
            continue;
        }

        if(num.Substring(0, num.Length / 2)
            == num.Substring(num.Length / 2, num.Length / 2))
        {
            ans += i;
        }
    }
}

Console.WriteLine(ans);