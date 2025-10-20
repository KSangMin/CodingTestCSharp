int apple3 = int.Parse(Console.ReadLine()!);
int apple2 = int.Parse(Console.ReadLine()!);
int apple1 = int.Parse(Console.ReadLine()!);
int banana3 = int.Parse(Console.ReadLine()!);
int banana2 = int.Parse(Console.ReadLine()!);
int banana1 = int.Parse(Console.ReadLine()!);

int apple = apple3 * 3 + apple2 * 2 + apple1;
int banana = banana3 * 3 + banana2 * 2 + banana1;

Console.WriteLine(apple > banana ? "A" : apple < banana ? "B" : "T");