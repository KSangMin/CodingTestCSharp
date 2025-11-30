string s = Console.ReadLine()!;

int count = 0;
int ironBarCount = 0;

for(int i = 0; i < s.Length; i++)
{
    char c = s[i];

    if (c == '(')
    {
        if(s[i + 1] != ')')
        {
            count++;
            ironBarCount++;
        }
    }
    else
    {
        if (s[i - 1] == '(')
        {
            count += ironBarCount;
        }
        else
        {
            ironBarCount--;
        }
    }
}

Console.WriteLine(count);