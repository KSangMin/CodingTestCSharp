string[] aString = Console.ReadLine().Split();
string[] cString = Console.ReadLine().Split();
int[] a = { int.Parse(aString[0]), int.Parse(aString[1]), int.Parse(aString[2]) };
int[] c = { int.Parse(cString[0]), int.Parse(cString[1]), int.Parse(cString[2]) };

int[] b = { c[0] - a[2], c[1] / a[1], c[2] - a[0] };

Console.WriteLine($"{b[0]} {b[1]} {b[2]}");