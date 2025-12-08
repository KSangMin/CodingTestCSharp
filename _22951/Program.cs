int[] nk = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int n = nk[0], k = nk[1];

List<Card> circle = new();
for(int i = 0; i < n; i++)
{
    int[] nums = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    for(int j = 0; j < k; j++)
    {
        circle.Add(new Card(i, nums[j]));
    }
}

int target = 0;
while(circle.Count > 1)
{
    int add = circle[target].num;
    circle.RemoveAt(target);

    target = (target + add - 1) % circle.Count;
}

Console.WriteLine($"{circle[0].id + 1} {circle[0].num}");
class Card
{
    public int id;
    public int num;

    public Card(int id, int num)
    {
        this.id = id;
        this.num = num;
    }
}