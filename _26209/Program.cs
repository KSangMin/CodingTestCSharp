int[] bits = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

Console.WriteLine(bits.Contains(9) ? "F" : "S");