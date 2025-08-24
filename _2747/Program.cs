int n = int.Parse(Console.ReadLine());

List<int> fib = new List<int>() { 0, 1 };
for(int i = 2; i <= n; i++)
{
    fib.Add(fib[i - 1] + fib[i - 2]);
}
Console.WriteLine(fib[n]);