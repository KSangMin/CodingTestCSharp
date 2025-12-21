int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

int count = 0;
for(int i = 0; i < n / 2; i++)
{
    if(s[i] != s[n - 1 - i])
    {
        count++;
    }
}

Console.WriteLine(count);