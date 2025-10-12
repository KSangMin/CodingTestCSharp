int a1 = int.Parse(Console.ReadLine()!);
int a2 = int.Parse(Console.ReadLine()!);
int a3 = int.Parse(Console.ReadLine()!);

int ans = Math.Min(a2 + a3 * 2, Math.Min(a1 + a3, a1 * 2 + a2));

Console.WriteLine(ans * 2);