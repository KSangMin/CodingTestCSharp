int[] people = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] xyr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for(int i = 1; i <= people.Length; i++)
{
    if (people[i - 1] == xyr[0])
    {
        Console.WriteLine(i);
        return;
    }
}

Console.WriteLine(0);