string mobis = Console.ReadLine();

bool isMobis =
    (
        mobis.Contains('M')
        && mobis.Contains('O')
        && mobis.Contains('B')
        && mobis.Contains('I')
        && mobis.Contains('S')
    );

Console.WriteLine(isMobis ? "YES" : "NO");