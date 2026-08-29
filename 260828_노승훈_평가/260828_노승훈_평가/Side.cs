public class Side : MenuInfo
{
    public Side(string name, int price, MenuSize size) : base(name, price)
    {
        this.price = price;

        switch (size)
        {
            case MenuSize.Large:
                this.price += 500;
                break;
            default:
                break;
        }
    }
}