float[] input = Console.ReadLine().Split().Select(float.Parse).ToArray();

if ((input[0] * (100 - input[1]) / 100) < 100) Console.WriteLine(1);
else Console.WriteLine(0);