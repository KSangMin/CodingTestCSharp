int[] abc = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int sum = Math.Abs(abc[0]) + Math.Abs(abc[1]), c = abc[2];

Console.WriteLine(sum <= c && sum % 2 == c % 2 ? "YES" : "NO");