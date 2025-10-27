int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);

if(a > b && b > c && c > d)
{
    Console.WriteLine("Fish Diving");
}
else if(a < b && b < c && c < d)
{
    Console.WriteLine("Fish Rising");
}
else if(a == b && b == c && c == d)
{
    Console.WriteLine("Fish At Constant Depth");
}
else
{
    Console.WriteLine("No Fish");
}