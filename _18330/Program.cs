int n = int.Parse(Console.ReadLine()!);
int k = int.Parse(Console.ReadLine()!);

int next = k + 60;

Console.WriteLine(n <= next ?  n * 1500 : (next * 1500 + (n - next) * 3000));