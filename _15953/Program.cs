int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int a = ab[0], b = ab[1];

    int sum = 0;

    if (a <= 0) sum += 0;
    else if (a <= 1) sum += 500;
    else if (a <= 3) sum += 300;
    else if (a <= 6) sum += 200;
    else if (a <= 10) sum += 50;
    else if (a <= 15) sum += 30;
    else if (a <= 21) sum += 10;

    if (b <= 0) sum += 0;
    else if (b <= 1) sum += 512;
    else if (b <= 3) sum += 256;
    else if (b <= 7) sum += 128;
    else if (b <= 15) sum += 64;
    else if (b <= 31) sum += 32;

    Console.WriteLine(sum * 10000);
}