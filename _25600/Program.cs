int n = int.Parse(Console.ReadLine()!);

int max = 0;
for(int i = 0; i < n; i++)
{
    int[] adg = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int a = adg[0], d = adg[1], g = adg[2];

    int sum =  a * (d + g);
    if(a == d + g)
    {
        sum *= 2;
    }

    max = Math.Max(max, sum);
}

Console.WriteLine(max);