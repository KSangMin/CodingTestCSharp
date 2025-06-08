int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int A = input[0], B = input[1], X = input[2];

    Console.WriteLine((A * (X - 1)) + B);
}