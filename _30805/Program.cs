int n = int.Parse(Console.ReadLine()!);
int[] a = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int m = int.Parse(Console.ReadLine()!);
int[] b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

List<int> result = new();
int aIndex = 0, bIndex = 0;

while (true)
{
    List<int> common = a.Skip(aIndex).Intersect(b.Skip(bIndex)).ToList();
    if(common.Count <= 0)
    {
        break;
    }

    int max = common.Max();

    int posA = Array.IndexOf(a, max, aIndex);
    int posB = Array.IndexOf(b, max, bIndex);

    result.Add(max);
    aIndex = posA + 1;
    bIndex = posB + 1;
}

Console.WriteLine(result.Count);
if (result.Count > 0)
{
    Console.WriteLine(string.Join(" ", result));
}