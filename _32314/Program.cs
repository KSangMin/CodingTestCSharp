int a = int.Parse(Console.ReadLine()!);
int[] wv = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int w = wv[0], v = wv[1];

Console.WriteLine(a <= w / v ? 1 : 0);