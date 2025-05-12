int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = nm[0], m  = nm[1];
if ((n >= 3 || m >= 3) && (n % 3 == 0 || m % 3 == 0))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}