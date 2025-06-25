int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();

int a = ab[0], b = ab[1];
if((a + b) % 2 == 1 || a < b)
{
    Console.WriteLine(-1);
    return;
}

int c = (a + b) / 2, d = a - c;

Console.WriteLine($"{c} {d}");