int[] times = new int[4];

for(int i = 0; i < 4; i++)
{
    times[i] = int.Parse(Console.ReadLine());
}

int sum = times.Sum();
Console.WriteLine(sum / 60);
Console.WriteLine(sum % 60);