public struct MenuInfo
{
    private string _name;
    private int _price;
    private PriceState _priceState;
    private int _amount;

    public MenuInfo(string name, int price, PriceState priceState, int amount)
    {
        _name = name;
        _price = price;
        _priceState = priceState;
        _amount = amount;
    }
}