int N = int.Parse(Console.ReadLine());

HashSet<string> people = new HashSet<string>();
for(int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split();
    if (input[1] == "enter")
    {
        people.Add(input[0]);
    }
    else if (input[1] == "leave")
    {
        people.Remove(input[0]);
    }
}

List<string> sortedPeople = people.ToList();
sortedPeople.Sort();
sortedPeople.Reverse();

Console.WriteLine(String.Join("\n", sortedPeople));