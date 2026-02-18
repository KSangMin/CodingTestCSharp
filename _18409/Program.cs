char[] key = { 'a', 'i', 'u', 'e', 'o' };

int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

int sum = 0;
for(int i = 0; i < key.Length; i++)
{
    sum += s.Count(c => c == key[i]);
}

Console.WriteLine(sum);