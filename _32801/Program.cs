int[] nab = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int n = nab[0], a = nab[1], b = nab[2];
int fizz = 0, buzz = 0, fizzbuzz = 0;

for(int i = 1; i <= nab[0]; i++)
{
    if(i % a == 0 && i % b == 0)
    {
        fizzbuzz++;
    }
    else if(i % a == 0)
    {
        fizz++;
    }
    else if(i % b == 0)
    {
        buzz++;
    }
}

Console.WriteLine($"{fizz} {buzz} {fizzbuzz}");