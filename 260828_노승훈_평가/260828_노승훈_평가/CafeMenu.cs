public class CafeMenu
{
    private string _name;
    private int _price;
    private PriceState _priceState =  PriceState.Regular;
    private int _amount;
    
    public enum PriceState : byte // 가격 상태
    {
        Regular, // 정가
        Discount, // 할인
        SoldOut // 품절
    }

    public CafeMenu(string name, int price, PriceState priceState, int amount)
    {
        _name = name;
        _price = price;
        _priceState = priceState;
        _amount = amount;
    }
    
}