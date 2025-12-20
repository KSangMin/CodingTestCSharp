int sum = 0;
Dictionary<int, int> count = new();

for(int i = 0; i < 10; i++)
{
    int num = int.Parse(Console.ReadLine()!);
    sum += num;

    if(count.ContainsKey(num))
    {
        count[num]++;
    }
    else
    {
        count[num] = 1;
    }
}

Console.WriteLine(sum / 10);
Console.WriteLine(count.MaxBy(kv => kv.Value).Key);
