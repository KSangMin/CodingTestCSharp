string hint1 = "CHIPMUNKS";
string hint2 = "LIVE";

string[] codes = Console.ReadLine().Split();

string[] ans = new string[codes.Length];
for (int key = 1; key < 26; key++)
{
    bool found1 = false, found2 = false;
    for(int i = 0; i < codes.Length; i++)
    {
        ans[i] = Decode(codes[i], key);
        string clean = new string(ans[i]
                    .Where(c => c >= 'A' && c <= 'Z')
                    .ToArray());

        if (clean == hint1)
        {
            found1 = true;
        }
        else if(clean == hint2)
        {
            found2 = true;
        }
    }

    if (found1 && found2)
    {
        Console.WriteLine(string.Join(" ", ans));
        return;
    }
}

string Decode(string code, int p)
{
    char[] word = code.ToCharArray();

    for (int i = 0; i < word.Length; i++)
    {
        char c = word[i];

        if (c >= 'A' && c <= 'Z')
        {
            word[i] = (char)(c - p);

            if (word[i] < 'A')
            {
                word[i] = (char)(word[i] + 26);
            }
        }
    }

    return new(word);
}