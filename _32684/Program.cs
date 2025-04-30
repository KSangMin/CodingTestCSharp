int[] score = { 13, 7, 5, 3, 3, 2 };
int[] cho = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] han = Console.ReadLine().Split().Select(int.Parse).ToArray();

float choSum = 0f, hanSum = 1.5f;
for(int i = 0; i < cho.Length; i++)
{
    choSum += cho[i] * score[i];
    hanSum += han[i] * score[i];
}

Console.WriteLine(choSum > hanSum ? "cocjr0208" : "ekwoo");