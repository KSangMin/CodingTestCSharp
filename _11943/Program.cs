int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine(MathF.Min(first[0] + second[1], second[0] + first[1]));