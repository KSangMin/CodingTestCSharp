string[] aInput = Console.ReadLine().Split();
string[] bInput = Console.ReadLine().Split();
string[] cInput = Console.ReadLine().Split();

GetTime(aInput);
GetTime(bInput);
GetTime(cInput);

void GetTime(string[] times)
{
    int h = int.Parse(times[3]) - int.Parse(times[0]);
    int m = int.Parse(times[4]) - int.Parse(times[1]);
    int s = int.Parse(times[5]) - int.Parse(times[2]);
    if (s < 0)
    {
        s += 60;
        m--;
    }
    if (m < 0)
    {
        m += 60;
        h--;
    }
    Console.WriteLine($"{h} {m} {s}");
}