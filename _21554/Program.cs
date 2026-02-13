using System.Text;

int n = int.Parse(Console.ReadLine()!);
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

StringBuilder sb = new();
int i = 0;
while (i < 100)
{
    bool isChanged = false;

    for (int j = 0; j < n; j++)
    {
        if (arr[j] == j + 1)
        {
            continue;
        }

        for (int k = j + 1; k < n; k++)
        {
            if (arr[k] == j + 1)
            {
                Swap(arr, j, k);
                sb.AppendLine($"{j + 1} {k + 1}");
                isChanged = true;
                break;
            }
        }

        break;
    }

    if (!isChanged)
    {
        break;
    }
    i++;
}

if (i >= 100)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(i);
    Console.Write(sb.ToString());
}

void Swap(int[] arr, int a, int b)
{
    for (int i = 0; i <= (b - a) / 2; i++)
    {
        (arr[a + i], arr[b - i]) = (arr[b - i], arr[a + i]);
    }
}