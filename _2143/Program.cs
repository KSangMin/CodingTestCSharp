using System.Runtime.InteropServices;

int t = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[] a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int m = int.Parse(Console.ReadLine()!);
int[] b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Dictionary<long, int> countA = new();
for(int i = 0; i < n; i++)
{
    long sum = 0;
    for(int j = i; j < n; j++)
    {
        sum+= a[j];
        if (countA.ContainsKey(sum))
        {
            countA[sum]++;
        }
        else
        {
            countA[sum] = 1;
        }
    }
}
Dictionary<long, int> countB = new();
for (int i = 0; i < m; i++)
{
    long sum = 0;
    for (int j = i; j < m; j++)
    {
        sum += b[j];
        if (countB.ContainsKey(sum))
        {
            countB[sum]++;
        }
        else
        {
            countB[sum] = 1;
        }
    }
}

long count = 0;
foreach(long key in countA.Keys)
{
    long target = t - key;
    if (countB.ContainsKey(target))
    {
        count += (long)countA[key] * countB[target];
    }
}

Console.WriteLine(count);