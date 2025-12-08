string[] s = Console.ReadLine()!.Split(',');

long ans = 0;
foreach (string range in s)
{
    long[] ab = range.Split('-').Select(long.Parse).ToArray();

    for (long i = ab[0]; i <= ab[1]; i++)
    {
        string num = i.ToString();

        bool isInValid = false;
        for (int length = 1; length <= num.Length / 2; length++)
        {
            string before = num.Substring(0, length);

            isInValid = true;
            for (int start = length; start < num.Length; start += length)
            {
                if(start + length > num.Length)
                {
                    isInValid = false;
                    break;
                }

                string now = num.Substring(start, length);
                if (before != now)
                {
                    isInValid = false;
                    break;
                }
                before = now;
            }

            if (isInValid)
            {
                break;
            }
        }

        if (isInValid)
        {
            ans += i;
        }
    }
}

Console.WriteLine(ans);