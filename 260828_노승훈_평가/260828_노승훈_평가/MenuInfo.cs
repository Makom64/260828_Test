public abstract class MenuInfo
{
    public string name { get; private set; }
    protected int price;
    protected MenuSize size;

    public MenuInfo(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public void PrintMenu()
    {
        Console.WriteLine($"{this.name} {this.price}원");
    }
}