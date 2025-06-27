int sum = int.Parse(Console.ReadLine());

for(int i = 0; i < 9; i++)
{
    sum -= int.Parse(Console.ReadLine());
}

Console.WriteLine(sum);