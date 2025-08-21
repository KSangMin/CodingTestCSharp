int n = int.Parse(Console.ReadLine());

int sum = n / 5;
n %= 5;

if(sum == 0 && n % 2 == 1)
{
    Console.WriteLine(-1);
}
else
{
    if (n == 1)
    {
        sum += 2;
    }
    else if(n == 3)
    {
        sum += 3;
    }
    else
    {
        sum += n / 2;
    }

    Console.WriteLine(sum);
}
