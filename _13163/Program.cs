int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] name = Console.ReadLine().Split();

    string ans = "god" + string.Join("", name.Skip(1));

    Console.WriteLine(ans);
}