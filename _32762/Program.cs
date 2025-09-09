int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = nm[0], m = nm[1];

for (int i = 0; i < n; i++)
{
    Console.ReadLine();
}

int sum = 0;
for (int i = 0; i < m; i++)
{
    string[] tp = Console.ReadLine().Split();
    sum += int.Parse(tp[1]);
}

Console.WriteLine($"{sum / (float)n:F4}");