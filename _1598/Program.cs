int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();

int a = ab[0] - 1, b = ab[1] - 1;
int r1 = a / 4, c1 = a % 4;
int r2 = b / 4, c2 = b % 4;
int ans = Math.Abs(r1 - r2) + Math.Abs(c1 - c2);

Console.WriteLine(ans);