int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();

int a = abc[0], b = abc[1], c = abc[2];

Console.WriteLine(b / a * 3 * c);