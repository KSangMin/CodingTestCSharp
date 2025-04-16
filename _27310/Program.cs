string input = Console.ReadLine();

int sum = input.Length;
foreach (char c in input)
{
    switch (c)
    {
        case ':':
            sum++;
            break;
        case '_':
            sum += 5;
            break;
        default:
            break;
    }
}

Console.WriteLine(sum);