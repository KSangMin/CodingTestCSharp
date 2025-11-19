for(int i = 0; i < 15; i++)
{
    char[] words = Console.ReadLine()!.ToCharArray();

    if(words.Contains('w'))
    {
        Console.WriteLine("chunbae");
        return;
    }
    else if(words.Contains('b'))
    {
        Console.WriteLine("nabi");
        return;
    }
    else if(words.Contains('g'))
    {
        Console.WriteLine("yeongcheol");
        return;
    }
}