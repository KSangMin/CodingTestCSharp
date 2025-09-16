List<int> sum = new() { 0, 1 };
int min = 1;

while (true)
{
    int n = int.Parse(Console.ReadLine()!);

    if(n == 0)
    {
        break;
    }

    if(n > min)
    {
        for(int i = min + 1; i <= n; i++)
        {
            sum.Add(sum[i - 1] + i);
        }
        min = n;
    }

    Console.WriteLine(sum[n]);
}