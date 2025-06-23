int n = -1;

while (n != 0)
{
    n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    Console.WriteLine(FindPrime(n));
}

int FindPrime(int n)
{
    int count = 0;

    for (int i = n + 1; i <= 2 * n; i++)
    {
        bool isPrime = true;
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime) count++;
    }

    return count;
}