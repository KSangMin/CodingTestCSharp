int n = int.Parse(Console.ReadLine());

int ans = 0;
for(int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (int.Parse(input.Substring(2, input.Length - 2)) <= 90) ans++;
}

Console.WriteLine(ans);