int n = int.Parse(Console.ReadLine()!);
int len = 2 * n;
int[] arr = new int[len];

for (int i = 0; i < len - 2; i += 2)
{
    arr[i] = 1;
    arr[i + 1] = -1;
}

arr[len - 2] = -1;
arr[len - 1] = 1;

Console.WriteLine(string.Join(' ', arr));