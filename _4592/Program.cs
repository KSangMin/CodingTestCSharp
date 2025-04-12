while (true)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (input[0] == 0) break;

    List<int> ans = new() { input[1] };

    for (int i = 2; i <= input[0]; i++)
    {
        if (input[i - 1] != input[i]) ans.Add(input[i]);
    }

    foreach (int i in ans) Console.Write(i + " ");
    Console.WriteLine("$");
}