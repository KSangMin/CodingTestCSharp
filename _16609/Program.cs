int n = int.Parse(Console.ReadLine()!);
int[] gas = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Array.Sort(gas);

double minRatio = 1f;
for(int i = 0; i < n; i++)
{
    if(gas[i] > i + 1)
    {
        Console.WriteLine("impossible");
        return;
    }

    minRatio = Math.Min(minRatio, (double)gas[i] / (i + 1));
}

Console.WriteLine(minRatio.ToString());