int count = 0;

for(int i = 0; i < 8; i++)
{
    string s = Console.ReadLine();

    for(int j = 0; j < s.Length; j++)
    {
        if((i + j) % 2 == 0 && s[j] == 'F')
        {
            count++;
        }
    }
}

Console.WriteLine(count);