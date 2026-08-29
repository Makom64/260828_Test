public abstract class MenuInfo
{
    protected string name;
    protected int price;
    protected MenuSize size;

    public MenuInfo(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}