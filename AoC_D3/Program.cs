int n = 200;

long ans = 0;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;

    int toRemove = s.Length - 12;

    Stack<char> battery = new();
    foreach (char c in s)
    {
        while(battery.Count > 0 && toRemove > 0 && battery.Peek() < c)
        {
            battery.Pop();
            toRemove--;
        }
        battery.Push(c);
    }

    while (toRemove > 0)
    {
        battery.Pop();
        toRemove--;
    }

    ans += long.Parse(new string(battery.Reverse().ToArray()));
}

Console.WriteLine(ans);