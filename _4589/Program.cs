int n = int.Parse(Console.ReadLine());

Console.WriteLine("Gnomes:");
for (int i = 1; i <= n; i++)
{
    int[] gnomes = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if(isSortedAsc(gnomes) || isSortedDesc(gnomes)) Console.WriteLine("Ordered");
    else Console.WriteLine("Unordered");
}

bool isSortedAsc(int[] arr)
{
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i - 1] > arr[i]) return false;
    }
    return true;
}

bool isSortedDesc(int[] arr)
{
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i - 1] < arr[i]) return false;
    }
    return true;
}