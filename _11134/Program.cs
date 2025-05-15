int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    int[] cookie = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int n  = cookie[0], c = cookie[1];

    Console.WriteLine((n / c) + ((n % c == 0) ? 0 : 1));
}