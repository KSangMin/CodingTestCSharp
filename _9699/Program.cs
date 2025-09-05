int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] rice = Console.ReadLine().Split().Select(int.Parse).ToArray();

    Console.WriteLine($"Case #{i + 1}: {rice.Max()}");
}