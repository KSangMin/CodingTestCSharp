int[] hiarc = Console.ReadLine().Split().Select(int.Parse).ToArray();

int h = hiarc[0], i = hiarc[1], a  = hiarc[2], r  = hiarc[3], c  = hiarc[4];

Console.WriteLine((h * i) - (a * r * c));