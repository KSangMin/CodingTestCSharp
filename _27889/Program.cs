string code = Console.ReadLine();

Dictionary<string, string> names = new()
{
    {"NLCS",  "North London Collegiate School"},
    {"BHA", "Branksome Hall Asia"},
    {"KIS", "Korea International School"},
    {"SJA", "St. Johnsbury Academy"}
};

Console.WriteLine(names[code]);