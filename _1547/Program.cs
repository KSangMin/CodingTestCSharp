int m = int.Parse(Console.ReadLine());

int cur = 1;
for(int i = 1; i <= m; i++)
{
    int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int a = ab[0], b = ab[1];
    if (a == cur) cur = b;
    else if (b == cur) cur = a;
}

Console.WriteLine(cur);