int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int m = int.Parse(Console.ReadLine());
    string[] s = new string[m];
    for(int j = 0; j < m; j++)
    {
        s[j] = Console.ReadLine();
    }

    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Scenario #{i + 1}:");
    for (int j = 0; j < n; j++)
    {
        int[] pass = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string ans = "";
        for(int k = 1; k < pass.Length; k++)
        {
            ans += s[pass[k]];
        }
        
        Console.WriteLine(ans);
    }
    Console.WriteLine();
}