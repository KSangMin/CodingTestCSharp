int n = int.Parse(Console.ReadLine());

while(n != 0)
{
    int min = 1, max = 10;

    string input = Console.ReadLine();
    while (input != "right on")
    {
        if(input == "too high")
        {
            max = Math.Min(max, n - 1);
        }
        else if(input == "too low")
        {
            min = Math.Max(min, n + 1);
        }

        n = int.Parse(Console.ReadLine());
        input = Console.ReadLine();
    }

    if (n < min || max < n) Console.WriteLine("Stan is dishonest");
    else Console.WriteLine("Stan may be honest");

    n = int.Parse(Console.ReadLine());
}