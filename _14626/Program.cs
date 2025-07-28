string input = Console.ReadLine();

for(int i = 0; i < 10; i++)
{
    if(Check(i) == 0)
    {
        Console.WriteLine(i);
        return;
    }
}

int Check(int num)
{
    int sum = 0;
    for (int i = 0; i < 12; i++)
    {
        if (input[i] != '*')
        {
            int digit = input[i] - '0';
            sum += i % 2 == 0 ? digit : digit * 3;
        }
        else
        {
            sum += i % 2 == 0 ? num : num * 3;
        }
    }

    return (input[12] - '0' + sum) % 10;
}