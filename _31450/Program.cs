int[] mk  = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();

Console.WriteLine(mk[0] % mk[1] == 0 ? "Yes" : "No");