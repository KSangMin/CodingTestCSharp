long n = long.Parse(Console.ReadLine()!);

int h = 0;
while (n > h)
{
    h++;
    n -= h;
}

Console.WriteLine(h);