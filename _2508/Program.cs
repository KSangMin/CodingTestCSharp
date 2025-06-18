int t = int.Parse(Console.ReadLine()!);

for(int i = 0; i < t; i++)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input)) input = Console.ReadLine();
    int[] rc = input.Split().Select(int.Parse).ToArray();
    int r = rc[0], c = rc[1];
    string[] box = new string[r];

    for(int j = 0; j < r; j++)
    {
        string row = Console.ReadLine()!;
        for (int k = 0; k < c; k++)
        {
            box[j] = row;
        }
    }

    int count = 0;
    for (int j = 0; j < r; j++)
    {
        for (int k = 0; k < c; k++)
        {
            if (box[j][k] == 'o')
            {
                //가로 사탕
                if (0 < k && k < c - 1 && box[j][k - 1] == '>' && box[j][k + 1] == '<')
                {
                    count++;
                    continue;
                }
                //세로 사탕
                if (0 < j && j < r - 1 && box[j - 1][k] == 'v' && box[j + 1][k] == '^')
                {
                    count++;
                    continue;
                }
            }
        }
    }

    Console.WriteLine(count);
}   