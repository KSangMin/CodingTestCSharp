int count = 0;

for(int i = 0; i < 6; i++)
{
    char c = Console.ReadLine()![0];
    if(c == 'W')
    {
        count++;
    }
}

switch(count)
{
    case 0:
        Console.WriteLine(-1);
        break;
    case 1:
    case 2:
        Console.WriteLine(3);
        break;
    case 3:
    case 4:
        Console.WriteLine(2);
        break;
    case 5:
    case 6:
        Console.WriteLine(1);
        break;
}