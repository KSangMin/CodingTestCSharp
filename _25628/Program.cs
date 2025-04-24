int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int bread = input[0], patty = input[1];

Console.WriteLine(MathF.Min(bread / 2, patty));