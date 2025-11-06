int n = int.Parse(Console.ReadLine()!);
int[] pages = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int ans = 0;
foreach(int page in pages)
{
    ans += page / 2 + page % 2;
}

Console.WriteLine(ans);