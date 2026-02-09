long threshold = 1000000007;

int[] hx = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int h = hx[0], x = hx[1];

long sum = 0, i = 1;
while(h > 0)
{
    i = (i * x) % threshold;
    sum = (sum + int.Parse(Console.ReadLine()!) * i) % threshold;
    
    h--;
}

Console.WriteLine(sum);