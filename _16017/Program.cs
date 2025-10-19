int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);

Console.WriteLine((a == 8 || a == 9) && (d == 8 || d == 9) && (b == c) ? "ignore" : "answer");