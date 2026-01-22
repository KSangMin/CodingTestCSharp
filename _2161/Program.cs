int n = int.Parse(Console.ReadLine()!);

Queue<int> card = new();

for(int i = 1; i <= n; i++)
{
    card.Enqueue(i);
}

List<int> ans = new();
while(card.Count > 0)
{
    ans.Add(card.Dequeue());
    if(card.Count == 0)
    {
        break;
    }
    card.Enqueue(card.Dequeue());
}

Console.WriteLine(string.Join(" ", ans));