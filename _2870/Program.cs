int n = int.Parse(Console.ReadLine()!);

List<string> nums = new();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;

    int sid = -1, length = 0;
    for(int j = 0; j < s.Length; j++)
    {
        char cur = s[j];
        if ('0' <= cur && cur <= '9')
        {
            if(length == 0)
            {
                sid = j;
            }
            length++;
        }
        else if(length > 0)
        {
            string result = s.Substring(sid, length).TrimStart('0');
            nums.Add(result == "" ? "0" : result);
            length = 0;
        }
    }

    if(length > 0)
    {
        string result = s.Substring(sid, length).TrimStart('0');
        nums.Add(result == "" ? "0" : result);
    }
}

Console.WriteLine(string.Join("\n"
    , nums.OrderBy(x => x.Length).ThenBy(x => x).ToList()));