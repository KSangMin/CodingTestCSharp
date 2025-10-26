int[] nhv = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int n = nhv[0], h = nhv[1], v = nhv[2];

int H = Math.Max(h, n - h);
int V = Math.Max(v, n - v);
Console.WriteLine(H * V * 4);