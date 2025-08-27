int n = int.Parse(Console.ReadLine());
JH jh = new JH(n);
SM sm = new SM(n);
int[] changes = Console.ReadLine().Split().Select(int.Parse).ToArray();

foreach (int change in changes)
{
    jh.Trade(change);
    sm.Trade(change);
}

int jhTotal = jh.GetWorth(changes.Last());
int smTotal = sm.GetWorth(changes.Last());
if (jhTotal > smTotal)
{
    Console.WriteLine("BNP");
}
else if (jhTotal < smTotal)
{
    Console.WriteLine("TIMING");
}
else
{
    Console.WriteLine("SAMESAME");
}

public class Person
{
    protected int money;
    protected int stock;

    public Person(int money)
    {
        this.money = money;
    }

    public virtual void Trade(int price)
    {

    }

    public void BuyAll(int price)
    {
        if (money >= price)
        {
            stock += money / price;
            money %= price;
        }
    }

    public int GetWorth(int price)
    {
        return money + stock * price;
    }
}

public class JH : Person
{
    public JH(int money) : base(money) { }
    public override void Trade(int price)
    {
        BuyAll(price);
    }
}

public class SM : Person
{
    private bool asc;
    private int day;
    private int beforePrice;

    public SM(int money) : base(money) { }
    public override void Trade(int price)
    {
        if (asc)
        {
            if (beforePrice < price)
            {
                if (++day >= 3) SellAll(price);
            }
            else if (beforePrice > price)
            {
                asc = false;
                day = 1;
            }
            else day = 1;
        }
        else
        {
            if (beforePrice > price)
            {
                if (++day >= 3) BuyAll(price);
            }
            else if (beforePrice < price)
            {
                asc = true;
                day = 1;
            }
            else day = 1;
        }

        beforePrice = price;
    }

    public void SellAll(int price)
    {
        money += stock * price;
        stock = 0;
    }
}