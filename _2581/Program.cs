int[] primes = {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};

int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

bool[] nums = new bool[m + 1];
nums[0] = true;
nums[1] = true;


for(int i = 0; i < primes.Length; i++)
{
    int prime = primes[i];

    if (prime * prime > m) break;

    for (int j = prime * 2; j <= m; j += prime)
    {
        nums[j] = true;
    }
}

int min = 0;
int sum = 0;
for (int i = n; i <= m; i++)
{
    if (nums[i] == false)
    {
        if (min == 0) min = i;
        sum += i;
    }
}

Console.WriteLine(sum == 0 ? -1 : $"{sum}\n{min}");