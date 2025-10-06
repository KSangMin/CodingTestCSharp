int[] abc  = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int a = abc[0], b = abc[1], c = abc[2];

if(a == b && b == c)
{
    Console.WriteLine("2");
}
else
{
    int max = Math.Max(a, Math.Max(b, c));
    if(a == max && a * a == b * b + c * c)
    {
        Console.WriteLine("1");
    }
    else if(b == max && b * b == a * a + c * c)
    {
        Console.WriteLine("1");
    }
    else if(c == max && c * c == b * b + a * a)
    {
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("0");
    }
}
