bool[] prime = Enumerable.Repeat(true, 246913).ToArray();
int n = -1;

CheckPrime(prime);

while (n != 0)
{
    n = int.Parse(Console.ReadLine());
    if(n == 0) break;

    Console.WriteLine(CountPrime(n));
}

void CheckPrime(bool[] prime)
{
    for(int i = 2; i * i < prime.Length; i++)
    {
        if(!prime[i]) continue;

        for (int j = 1; j * i < prime.Length; j++)
        {
            prime[j * i] = false;
        }
    }
}

int CountPrime(int n)
{
    int count = 0;

    for (int i = n + 1; i <= 2 * n; i++)
    {
        if(prime[i]) count++;
    }

    return count;
}