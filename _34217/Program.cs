int[] ab = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] cd = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int a = ab[0], b = ab[1], c = cd[0], d = cd[1];
int h = a + c, y = b + d;

Console.WriteLine(h == y ? "Either" : h > y ? "Yongdap" : "Hanyang Univ.");