int[] NAB = Console.ReadLine().Split().Select(int.Parse).ToArray();

int N = NAB[0], A = NAB[1], B = NAB[2];

if(N <= B)
{
    if(A< B)
    {
        Console.WriteLine("Bus");
    }
    else if (A>B)
    {
        Console.WriteLine("Subway");
    }
    else
    {
        Console.WriteLine("Anything");
    }
}
else
{
    Console.WriteLine("Bus");
}