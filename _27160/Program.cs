int N = int.Parse(Console.ReadLine());
Dictionary<string, int> wordCount = new();

bool Yes = false;
for(int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split();

    if(!wordCount.ContainsKey(input[0]))
    {
        wordCount[input[0]] = int.Parse(input[1]);
    }
    else
    {
        wordCount[input[0]] += int.Parse(input[1]);
    }
}

foreach(var count in wordCount.Values)
{
    if(count == 5)
    {
        Yes = true;
        break;
    }
}

Console.WriteLine(Yes ? "YES" : "NO");