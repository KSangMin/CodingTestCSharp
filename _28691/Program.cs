Dictionary<char, string> names = new()
    { 
        { 'M', "MatKor" }
        , { 'W', "WiCys" }
        , { 'C', "CyKor" }
        , { 'A', "AlKor" }
        , { '$', "$clear" }
    };

char c = char.Parse(Console.ReadLine());

Console.WriteLine(names[c]);