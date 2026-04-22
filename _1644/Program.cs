int n = int.Parse(Console.ReadLine()!);

bool[] isPrime = new bool[n + 1];
Array.Fill(isPrime, true);
isPrime[0] = isPrime[1] = false;
for (int i = 2; i * i <= n; i++)
{
    if (isPrime[i])
    {
        for (int j = i * 2; j <= n; j += i)
        {
            isPrime[j] = false;
        }
    }
}

List<int> prime = new();
for (int i = 0; i <= n; i++)
{
    if (isPrime[i])
    {
        prime.Add(i);
    }
}

int sum = 2;
int count = 0;
int left = 0;
int right = 0;

while (left <= right && left < prime.Count && right < prime.Count)
{
    if (sum > n)
    {
        left++;
        sum -= prime[left - 1];
    }
    else
    {
        if (sum == n)
        {
            count++;
        }

        right++;
        if (right < prime.Count)
        {
            sum += prime[right];
        }
    }
}

Console.WriteLine(count);