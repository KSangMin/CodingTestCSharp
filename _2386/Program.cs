while (true)
{
    string input = Console.ReadLine();

    if (input[0] == '#')
    {
        break;
    }

    char target = input[0];
    string sentence = input.Substring(2);
    int count = 0;
    foreach (char c in sentence)
    {
        if (c == target || c - 'A' + 'a' == target)
        {
            count++;
        }
    }

    Console.WriteLine($"{target} {count}");
}