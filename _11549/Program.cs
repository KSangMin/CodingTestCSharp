int n = int.Parse(Console.ReadLine()!);

int[] ans = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Console.WriteLine(ans.Count(s => s == n));