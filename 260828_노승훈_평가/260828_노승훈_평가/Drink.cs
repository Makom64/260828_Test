public class Drink : MenuInfo
{
    public Drink(string name, int price) : base(name, price)
    {
        this.name = name;
        this.price = price;
    }
}