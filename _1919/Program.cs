string a = Console.ReadLine()!;
string b = Console.ReadLine()!;
int[] aCount = new int[26];
int[] bCount = new int[26];

foreach (char c in a)
{
    aCount[c - 'a']++;
}

foreach (char c in b)
{
    bCount[c - 'a']++;
}

int count = 0;
for(int i = 0; i < aCount.Length; i++)
{
    int diff = Math.Abs(aCount[i] - bCount[i]);
    if(diff > 0)
    {
        count += diff;
    }
}

Console.WriteLine(count);