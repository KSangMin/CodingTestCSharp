int n = int.Parse(Console.ReadLine()!);

int[] first = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int[] second = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

bool allOne = true;
for (int i = 0; i < n - 1; i++)
{
    if (first[i] + second[i] == 0
        || (first[i] == 0 && second[i] == 1 && first[i + 1] == 1 && second[i + 1] == 0)
        || (first[i] == 1 && second[i] == 0 && first[i + 1] == 0 && second[i + 1] == 1))
    {
        Console.WriteLine(0);
        return;
    }
    else if (first[i] == 0 || second[i] == 0)
    {
        allOne = false;
    }
}

Console.WriteLine(allOne ? 2 : 1);