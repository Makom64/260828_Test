public class Drink : MenuInfo
{
    public Drink(string name, int price, MenuSize size) : base(name, price)
    {
        this.name = name;
        this.price = price;

        switch (size)
        {
            case MenuSize.Large:
                this.price += 300;
                break;
            default:
                break;
        }
    }
}