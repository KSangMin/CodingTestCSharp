int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = input[0], w = input[1], h  = input[2], l  = input[3];

Console.WriteLine(MathF.Min((w / l) * (h / l), n));