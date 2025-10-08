int n = int.Parse(Console.ReadLine()!);

string ts = Console.ReadLine()!;

int tCount = ts.Count(c => c == 't');
int sCount = ts.Count(c => c == 's');
int id = 0;
for (int i = 0; i < n - 1; i++)
{
    if(tCount == sCount)
    {
        break;
    }

    char each = ts[i];
    switch(each)
    {
        case 't':
            tCount--;
            break;
        case 's':
            sCount--;
            break;
    }

    id++;
}

Console.WriteLine(ts.Substring(id));
