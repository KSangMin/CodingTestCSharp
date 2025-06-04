int n = int.Parse(Console.ReadLine());

Console.WriteLine(FindFib(n));

long FindFib(int n)
{
    List<long> fibs = new() { 0, 1, 1 };

    for(int i = 3; i <= n; i++)
    {
        fibs.Add(fibs[i - 1] + fibs[i - 2]);
    }

    return fibs[n];
}