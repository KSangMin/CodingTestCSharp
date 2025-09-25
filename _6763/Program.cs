int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

if(m > n)
{
    int diff = m - n;
    int fine = 0;
    if(diff <= 20)
    {
        fine = 100;
    }
    else if (diff <= 30)
    {
        fine = 270;
    }
    else
    {
        fine = 500;
    }
    Console.WriteLine($"You are speeding and your fine is ${fine}.");
}
else
{
    Console.WriteLine("Congratulations, you are within the speed limit!");
}