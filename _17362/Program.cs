int n = int.Parse(Console.ReadLine());

int ans = 0;

switch (n % 8)
{
    case 1:
        ans = 1;
        break;
    case 0:
    case 2:
        ans = 2;
        break;
    case 7:
    case 3:
        ans = 3;
        break;
    case 6:
    case 4:
        ans = 4;
        break;
    case 5:
        ans = 5;
        break;
}

Console.WriteLine(ans);