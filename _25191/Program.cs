int chicken = int.Parse(Console.ReadLine());
int[] drinks = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine(MathF.Min(chicken, drinks[0] / 2 + drinks[1]));