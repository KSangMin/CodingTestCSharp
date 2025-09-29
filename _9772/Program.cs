using System.Globalization;
using System.Text;

StringBuilder sb = new();

while (true)
{
    string[] input = Console.ReadLine()!.Split();

    double x = double.Parse(input[0], CultureInfo.InvariantCulture);
    double y = double.Parse(input[1], CultureInfo.InvariantCulture);

    if (x > 0 && y > 0) sb.AppendLine("Q1");
    else if (x > 0 && y < 0) sb.AppendLine("Q4");
    else if (x < 0 && y > 0) sb.AppendLine("Q2");
    else if (x < 0 && y < 0) sb.AppendLine("Q3");
    else sb.AppendLine("AXIS");

    if (x == 0 && y == 0) break;
}

Console.Write(sb.ToString());