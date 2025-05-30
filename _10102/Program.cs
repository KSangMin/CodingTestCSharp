int n = int.Parse(Console.ReadLine());

string vote = Console.ReadLine();

int[] cnt = { 0, 0 };
foreach(char c in vote)
{
    if(c == 'A') cnt[0]++;
    else cnt[1]++;
}

if (cnt[0] > cnt[1]) Console.WriteLine("A");
else if (cnt[0] < cnt[1]) Console.WriteLine("B");
else Console.WriteLine("Tie");