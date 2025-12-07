int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

int i = 0, count = 0;
while(i < s.Length - 3)
{
    if(s.Substring(i, 4) == "pPAp")
    {
        i += 3;
        count++;
    }
    i++;
}

Console.WriteLine(count);