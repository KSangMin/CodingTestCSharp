Console.ReadLine();
int[] people = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool[] check = new bool[101];

int cnt = 0;
for(int i = 0; i < people.Length; i++)
{
    if (check[people[i]] == true) cnt++;
    else check[people[i]] = true;
}

Console.WriteLine(cnt);