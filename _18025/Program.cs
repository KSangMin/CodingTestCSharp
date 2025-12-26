int n = int.Parse(Console.ReadLine()!);
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int d = 1;
int min = 41;
for(int i = 0; i <= n - 3; i++)
{
    int m = Math.Max(arr[i], arr[i + 2]);

    if(m < min)
    {
        min = m;
        d = i + 1;
    }
}

Console.WriteLine($"{d}\n{min}");