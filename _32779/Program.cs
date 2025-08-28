int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[]AM = Console.ReadLine().Split().Select(int.Parse).ToArray();

    long a = AM[0], m = AM[1];

    Console.WriteLine((a * m * 176 / 100000));
}