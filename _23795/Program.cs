int sum = 0;

while (true)
{
    int i = int.Parse(Console.ReadLine());
    if (i == -1) break;
    sum += i;
}

Console.WriteLine(sum);