List<List<char>> scores = new()
{
    new(){'A','B','C','D','E','F','G','H','J','L','M' },
    new(){'A','C','E','F','G','H','I','L','M' },
    new(){'A','C','E','F','G','H','I','L','M' },
    new(){'A','B','C','E','F','G','H','L','M' },
    new(){'A','C','E','F','G','H','L','M' },
    new(){'A','C','E','F','G','H','L','M' },
    new(){'A','C','E','F','G','H','L','M' },
    new(){'A','C','E','F','G','H','L','M' },
    new(){'A','C','E','F','G','H','L','M' },
    new(){'A','B','C','F','G','H','L','M' }
};

int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(scores[n - 1].Count);
Console.WriteLine(string.Join(' ', scores[n - 1]));