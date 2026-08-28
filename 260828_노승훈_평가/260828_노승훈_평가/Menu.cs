public struct Menu
{
    public string Name { get; }
    public int Price { get; }
    public PriceState PriceState { get; }
    public int Amount { get; }
    public Sort Sort { get; }

    public Menu(string name, int price, PriceState priceState, int amount, Sort sort)
    {
        Name = name;
        Price = price;
        PriceState = priceState;
        Amount = amount;
        Sort = sort;
    }
}