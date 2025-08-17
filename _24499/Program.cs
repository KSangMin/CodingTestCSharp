int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = NK[0], k = NK[1];
int[] pie = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sum = 0;
for(int i = 0; i < k; i++)
{
    sum += pie[i];
}

int max = sum;
for(int i = 1; i < n; i++)
{
    sum -= pie[i - 1];
    sum += pie[(i + k - 1) % n];
    if (sum > max)
    {
        max = sum;
    }
}

Console.WriteLine(max);