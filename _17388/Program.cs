namespace _17388
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] score = new int[input.Length];
            
            for(int i = 0; i < input.Length; i++)
            {
                score[i] = int.Parse(input[i]);
            }

            if (score.Sum() >= 100) Console.WriteLine("OK");
            else
            {
                int min = score.Min();

                if (min == score[0]) Console.WriteLine("Soongsil");
                else if (min == score[1]) Console.WriteLine("Korea");
                else Console.WriteLine("Hanyang");
            }
        }
    }
}
