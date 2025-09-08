string[] code = Console.ReadLine().Split('|');

int gaCount = 0, daCount = 0;
foreach (string s in code)
{
    int n = isGa(s[0]);
    if (n == 1)
    {
        gaCount++;
    }
    else if (n == 2)
    {
        daCount++;
    }
}

if (gaCount > daCount)
{
    Console.WriteLine("A-minor");
}
else if (gaCount < daCount)
{
    Console.WriteLine("C-major");
}
else
{
    int n = isGa(code.Last().Last());
    if (n == 1)
    {
        Console.WriteLine("A-minor");
    }
    else if (n == 2)
    {
        Console.WriteLine("C-major");
    }
}

int isGa(char c)
{
    if (c == 'A' || c == 'D' || c == 'E')
    {
        return 1;
    }
    else if (c == 'C' || c == 'F' || c == 'G')
    {
        return 2;
    }

    return 0;
}