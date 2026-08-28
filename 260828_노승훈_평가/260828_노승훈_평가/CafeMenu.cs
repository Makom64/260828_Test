public abstract class CafeMenu : MenuPrinter, AddCart
{
    public string _name { get; protected set; }
    public int _price { get; protected set; }
    public SaleState _state { get; protected set; }

    public CafeMenu(string name, int price, SaleState state)
    {
        _name = name;
        _price = price;
        _state = state;
    }
    public void PrintMenu(CafeMenu menu)
    {
        string state;
        if (menu._state == SaleState.Regular)
        {
            state = "정가";
            Console.WriteLine($"{menu._name} {menu._price} {state}");
        }
        else if (menu._state == SaleState.Discount)
        {
            state = "할인";
            Console.WriteLine($"{menu._name} {menu._price} {state}");
        }
    }
    public void AddtoCart(CafeMenu menu)
    {
        
    }
}

public enum SaleState
{
    Regular,
    Discount
}