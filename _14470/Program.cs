int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);
int e = int.Parse(Console.ReadLine()!);

bool f = a < 0;
int t = 0;
while(a < b)
{
    if (f)
    {
        if(a < 0)
        {
            t += c;
            a++;
        }
        else if(a == 0)
        {
            t += d;
            f = false;
        }
    }
    else
    {
        t += e;
        a++;
    }
}

Console.WriteLine(t);