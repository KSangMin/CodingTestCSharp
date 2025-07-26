int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    int a = int.Parse(input);
    int b = int.Parse(input.Reverse().ToArray());
    int c = a + b;

    string result = c.ToString();

    bool isSymm = true;
    for(int j = 0; j < result.Length / 2; j++)
    {
        if (result[j] != result[result.Length - 1 - j])
        {
            isSymm = false;
            break;
        }
    }

    Console.WriteLine(isSymm ? "YES" : "NO");
}