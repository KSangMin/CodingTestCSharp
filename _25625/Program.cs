int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();

int x = xy[0], y = xy[1];

Console.WriteLine(x > y ? xy.Sum() : y - x);