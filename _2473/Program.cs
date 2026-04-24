int n = int.Parse(Console.ReadLine()!);
long[] arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
Array.Sort(arr);

long min = long.MaxValue;
long[] result = new long[3];

for (int i = 0; i < n - 2; i++)
{
    int left = i + 1;
    int right = n - 1;

    while (left < right)
    {
        long sum = arr[i] + arr[left] + arr[right];

        long abs = Math.Abs(sum);
        if (abs < min)
        {
            min = abs;
            result[0] = arr[i];
            result[1] = arr[left];
            result[2] = arr[right];
        }

        if (sum < 0)
        {
            left++;
        }
        else if (sum > 0)
        {
            right--;
        }
        else
        {
            Console.WriteLine($"{result[0]} {result[1]} {result[2]}");
            return;
        }
    }
}

Console.WriteLine($"{result[0]} {result[1]} {result[2]}");