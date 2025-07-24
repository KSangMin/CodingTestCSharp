int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int N = int.Parse(Console.ReadLine());
    int[] childs = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int count = 0;

    while (true)
    {
        bool clear = true;

        for (int j = 0; j < N; j++)
        {
            if (childs[j] % 2 == 1)
            {
                childs[j]++;
            }
        }

        for (int j = 1; j < N; j++)
        {
            if (childs[j] != childs[j - 1])
            {
                clear = false;
            }
        }

        if (clear)
        {
            break;
        }

        count++;

        int[] temp = new int[N];
        for (int j = 0; j < N; j++)
        {
            temp[(j + 1) % N] += childs[j] >> 1;
            childs[j] >>= 1;
        }

        for (int j = 0; j < N; j++)
        {
            childs[j] += temp[j];
        }
    }

    Console.WriteLine(count);
}