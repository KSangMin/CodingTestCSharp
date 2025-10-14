int[] had = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] asked = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int ans = 0;
ans += Math.Max(0, asked[0] - had[0]);
ans += Math.Max(0, asked[1] - had[1]);
ans += Math.Max(0, asked[2] - had[2]);

Console.WriteLine(ans);