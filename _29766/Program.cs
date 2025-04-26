string logo = Console.ReadLine();

int cnt = 0;

for(int i = 0; i <= logo.Length - 4; i++)
{
    if (logo.Substring(i, 4) == "DKSH") cnt++;
}

Console.WriteLine(cnt);