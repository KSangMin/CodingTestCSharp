string s = Console.ReadLine()!;

int numCount = 10, wordCount = 26;
long ans = s[0] == 'd' ? numCount : wordCount;

for(int i = 1; i < s.Length; i++)
{
    int count = s[i] == 'd' ? numCount : wordCount;
    if (s[i - 1] == s[i])
    {
        count--;
    }

    ans *= count;
    ans %= 1000000009;
}

Console.WriteLine(ans);