Console.ReadLine();

string s = Console.ReadLine();

long count = 0;
long result = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '2')
    {
        count++;
    }
    else
    {
        result += Calc(count);
        count = 0;
    }
}

result += Calc(count);

Console.WriteLine(result);

long Calc(long n)
{
    long sum = 0;
    for(int i = 1; i <= n; i++)
    {
        sum += i * (n + 1 - i);
    }

    return sum;
}