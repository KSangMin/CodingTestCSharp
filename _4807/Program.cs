using System.Text;

int n, order = 0;

StringBuilder sb = new();
while((n = int.Parse(Console.ReadLine()!)) != 0)
{
    int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    order++;
    int count = 0;
    while (count <= 1000)
    {
        bool done = true;
        for(int i = 0; i < n - 1; i++)
        {
            if (arr[i] != arr[i + 1])
            {
                done = false;
                break;
            }
        }

        if (done)
        {
            break;
        }

        count++;

        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            temp[i] = Math.Abs(arr[i] - arr[(i + 1) % n]);
        }
        arr = temp;
    }

    sb.Append($"Case {order}: ");
    sb.AppendLine(count > 1000 ? "not attained" : $"{count} iterations");
}

Console.WriteLine(sb.ToString());