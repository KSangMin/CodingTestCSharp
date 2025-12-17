List<int> ab = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

List<int> a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();
List<int> b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

HashSet<int> check = new();
foreach(int i in b)
{
    check.Add(i);
}

List<int> ans = new();
foreach(int i in a)
{
    if (!check.Contains(i))
    {
        ans.Add(i);
    }
}

Console.WriteLine(ans.Count);
if (ans.Count > 0)
{
    ans.Sort();
    Console.WriteLine(string.Join(" ", ans));
}