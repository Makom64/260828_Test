public class CafeMenu
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
}

public enum SaleState
{
    Regular,
    Discount
}