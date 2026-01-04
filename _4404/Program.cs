double[] xy = Console.ReadLine()!.Split(' ').Select(double.Parse).ToArray();
double gX = xy[0], gY = xy[1], dX = xy[2], dY = xy[3];

string input;
while ((input = Console.ReadLine()!) != null)
{
    double[] hole = input.Split(' ').Select(double.Parse).ToArray();
    double hX = hole[0], hY = hole[1];

    double gDist = (gX - hX) * (gX - hX) + (gY - hY) * (gY - hY);
    double dDist = (dX - hX) * (dX - hX) + (dY - hY) * (dY - hY);

    if (gDist * 4 <= dDist)
    {
        Console.WriteLine($"The gopher can escape through the hole at ({hX:F3},{hY:F3}).");
        return;
    }
}

Console.WriteLine("The gopher cannot escape.");