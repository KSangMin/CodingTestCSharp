int[] score = { 6, 3, 2, 1, 2 };

int[] aScore = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int[] bScore = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int a = 0, b = 0;
for (int i = 0; i < 5; i++)
{
    a += aScore[i] * score[i];
    b += bScore[i] * score[i];
}

Console.WriteLine($"{a} {b}");