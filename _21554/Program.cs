using System.Text;

int n = int.Parse(Console.ReadLine()!);
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int count = 0;
StringBuilder sb = new();
for(int i = 1; i <= n; i++)
{
    if (arr[i - 1] == i)
    {
        continue;
    }

    int targetIndex = Array.IndexOf(arr, i);
    Swap(arr, i - 1, targetIndex);
    sb.AppendLine($"{i} {targetIndex + 1}");

    if(count++ > 100)
    {
        Console.WriteLine(-1);
        return;
    }
}

Console.WriteLine(count);
Console.Write(sb.ToString());

void Swap(int[] arr, int a, int b)
{
    for (int i = 0; i <= (b - a) / 2; i++)
    {
        (arr[a + i], arr[b - i]) = (arr[b - i], arr[a + i]);
    }
}