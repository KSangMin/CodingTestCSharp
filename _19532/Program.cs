int[] abcdef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int a = abcdef[0], b = abcdef[1], c = abcdef[2], d = abcdef[3], e = abcdef[4], f = abcdef[5];

int x = (c * e - b * f) / (a * e - b * d);
int y = (a * f - c * d) / (a * e - b * d);

Console.WriteLine($"{x} {y}");