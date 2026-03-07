int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if (6 <= s.Length && s.Length <= 9) Console.WriteLine("yes");
    else Console.WriteLine("no");
}