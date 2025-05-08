int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int a = input[0], b = input[1], n = input[2];

int sum = a * n;
for(int i = 0; i < n; i++)
{
    sum += b;
    Console.WriteLine(sum);
}