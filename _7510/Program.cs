int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(abc);
    int a = abc[0], b = abc[1], c = abc[2];

    Console.WriteLine($"Scenario #{i}:");
    Console.WriteLine(a * a + b * b == c * c ? "yes\n" : "no\n");
}