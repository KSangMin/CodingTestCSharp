int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (input[0] != 0)
{
    int d = input[0], m = input[1], y = input[2];

    int ans = 0;
    month[1] = DateTime.IsLeapYear(y) ? 29 : 28;
    if(y % 4 == 0 && (y % 100 != 0 || y % 400 == 0)) month[1] = 29;
    else month[1] = 28;

    for(int i = 0; i < m - 1; i++)
    {
        ans += month[i];
    }
    ans += d;

    Console.WriteLine(ans);

    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
}