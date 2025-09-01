int[] food = new int[3];
for(int i = 0; i < 3; i++)
{
    food[i] = int.Parse(Console.ReadLine());
}

Array.Sort(food);

Console.WriteLine(food[1]);