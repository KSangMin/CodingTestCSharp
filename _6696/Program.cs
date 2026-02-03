using System.Text;

StringBuilder sb = new();

while (true)
{
    double[] xy = Console.ReadLine()!.Split().Select(double.Parse).ToArray();
    if (xy[0] == 0f && xy[1] == 0f)
    {
        break;
    }

    double sqrtDist = xy[0] * xy[0] + xy[1] * xy[1];
    int mul = (int)Math.Ceiling(sqrtDist * Math.PI / 100d);
    sb.AppendLine($"The property will be flooded in hour {mul}.");
}

Console.Write(sb.ToString());