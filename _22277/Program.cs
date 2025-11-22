int n = int.Parse(Console.ReadLine()!);
int[] xy = Console.ReadLine()!.Trim('$').Split('.').Select(int.Parse).ToArray();

int count = 0;
for(int i = 0; i < n; i++)
{
    int[] ab = Console.ReadLine()!.Trim('$').Split('.').Select(int.Parse).ToArray();
    xy[1] += ab[1];
    if(xy[1] >= 100)
    {
        xy[0] += xy[1] / 100;
        xy[1] = xy[1] % 100;
    }

    xy[0] += ab[0];

    if (xy[1] != 0)
    {
        count++;
    }
}

Console.WriteLine(count);