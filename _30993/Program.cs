int[] NABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = NABC[0], A = NABC[1], B = NABC[2], C = NABC[3];

long sum = factorial(N) / factorial(A) / factorial(B) / factorial(C);
Console.WriteLine(sum);

long factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}