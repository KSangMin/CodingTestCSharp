List<int> count = new();

for(int i = 0; i < 5; i++)
{
    List<string> input = Console.ReadLine().Split('-').ToList();

    for(int j = 0; j < input.Count; j++)
    {
        if (input[j].Contains("FBI"))
        {
            count.Add(i + 1);
            break;
        }
    }
}

Console.WriteLine(count.Count > 0 ? string.Join(' ', count) : "HE GOT AWAY!");