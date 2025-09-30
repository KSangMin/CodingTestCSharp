long[] ab = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

long a = ab[0], b = ab[1];

Console.WriteLine(a % 2 == 0 || b % 2 == 0 ? 0 : Math.Min(a, b));
