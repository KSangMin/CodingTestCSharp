using System.Text;

int t = int.Parse(Console.ReadLine()!);

StringBuilder sb = new();
for(int i = 0; i < t; i++)
{
    int[] nl = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int n = nl[0], l = nl[1];
    int[] times = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    Array.Sort(times);

    int count = 0;
    int acc = 0;
    int accSum = 0;
    foreach(int each in times)
    {
        if(acc + each > l)
        {
            break;
        }

        count++;
        acc += each;
        accSum += acc;
    }

    sb.AppendLine($"Case {i + 1}: {count} {acc} {accSum}");
}

Console.Write(sb.ToString());