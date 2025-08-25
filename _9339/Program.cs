int T = int.Parse(Console.ReadLine());

for(int i = 0; i < T; i++)
{
    int K = int.Parse(Console.ReadLine());
    int[] people = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int N = int.Parse(Console.ReadLine());

    int min = 1440, best = 0, count = 0;
    for(int j = 0; j < N; j++)
    {
        int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int person = query[0];

        int score = query[1] * 60 + query[2];

        if (score < 0)
        {
            continue;
        }

        if(people.Contains(person))
        {
            if(score < min)
            {
                min = score;
                best = person;
            }
            if(score <= 360)
            {
                count++;
            }
        }
    }

    Console.WriteLine($"{best} {count}");
}