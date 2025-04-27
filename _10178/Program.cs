int test = int.Parse(Console.ReadLine());

for(int i = 0; i< test; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int c = input[0], v = input[1];

    int child = c / v, dad = c % v;

    Console.WriteLine($"You get {child} piece(s) and your dad gets {dad} piece(s).");
}