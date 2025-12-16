int[] s12 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(s12[0] * 2 >= s12[1] ? "E" : "H");