int sum = 0;

List<int> science = new();
List<int> history = new();

for (int i = 0;  i < 4;  i++)
{
    science.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < 2; i++)
{
    history.Add(int.Parse(Console.ReadLine()));
}

sum += science.Sum() + history.Sum();

sum -= science.Min() + history.Min();

Console.WriteLine(sum);