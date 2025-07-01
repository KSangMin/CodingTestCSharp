int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int a = ab[0], b = ab[1];

    int result = a % 10;
    for(int j = 0; j < b - 1; j++)
    {
        result = result * a % 10;
    }

    Console.WriteLine(result == 0 ? 10 : result);
}