int[] ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
int a = ABC[0], b = ABC[1], c = ABC[2];

int n = int.Parse(Console.ReadLine());

int max = 0;
for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < 3; j++)
    {
        int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
        sum += a * abc[0] + b * abc[1] + c * abc[2];
    }

    max = Math.Max(max, sum);
}

Console.WriteLine(max);