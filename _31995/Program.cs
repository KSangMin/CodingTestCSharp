int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Console.WriteLine(n > 1 && m > 1 ? (n - 1) * (m - 1) * 2 : 0);