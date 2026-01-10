int[] am = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int a = am[0], m = am[1];

int x = 1;
while ((a * x) % m != 1)
{
    x++;
}

Console.WriteLine(x);