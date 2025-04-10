Dictionary<string, int> seminar = new();

for(int i = 0; i < 7; i++)
{
    string[] input = Console.ReadLine().Split();

    seminar[input[0]] = int.Parse(input[1]);
}

string ans = seminar.MaxBy(d => d.Value).Key;

Console.WriteLine(ans);