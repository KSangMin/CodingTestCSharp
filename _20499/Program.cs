namespace _20499
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");
            int[] kda = input.Select(int.Parse).ToArray();

            if (kda[0] + kda[2] < kda[1] || kda[1] == 0) Console.WriteLine("hasu");
            else Console.WriteLine("gosu");
        }
    }
}
