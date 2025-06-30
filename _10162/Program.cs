int n = int.Parse(Console.ReadLine());

int[] abc = new int[3];

if (n % 10 != 0) Console.WriteLine(-1);
else
{
    abc[0] = n / 300;
    n %= 300;
    abc[1] = n / 60;
    n %= 60;
    abc[2] = n / 10;

    Console.WriteLine($"{abc[0]} {abc[1]} {abc[2]}");
}