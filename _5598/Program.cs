string input = Console.ReadLine();

string ans = "";

foreach(char c in input)
{
    char target = (char)(c - 3);
    if (target < 'A') ans += (char)(target + 26);
    else ans += target;
}

Console.WriteLine(ans);