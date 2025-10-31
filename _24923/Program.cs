string s = Console.ReadLine()!;

Console.WriteLine(s.Substring(s.Length - 3, 3) == "eh?" ? "Canadian!" : "Imposter!");