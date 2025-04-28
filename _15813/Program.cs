int n = int.Parse(Console.ReadLine());

string name = Console.ReadLine();

int sum = 0;
foreach(char c in name)
{
    sum += c - 'A' + 1;
}

Console.WriteLine(sum);