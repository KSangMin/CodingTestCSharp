string s = Console.ReadLine()!;

int left = 0, right = 0;
bool leftFlag = true;
foreach (char c in s)
{
    if (c == '@')
    {
        if (leftFlag)
        {
            left++;
        }
        else
        {
            right++;
        }
    }
    else if(c == '(')
    {
        leftFlag = false;
    }
}

Console.WriteLine($"{left} {right}");