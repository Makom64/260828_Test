public class CafeMenu
{
    private string _name;
    private Sort _sort;
    private int _price;
    private PriceState _priceState;
    private int _amount;
    
    public enum PriceState : byte // 가격 상태
    {
        Regular, // 정가
        Discount, // 할인
        SoldOut // 품절
    }
    
    public enum Sort // 메뉴의 종류
    {
        Drink, // 음료
        Desert, // 디저트
        Merch // 그 외 제품
    }

    public CafeMenu(string name, Sort sort, int price, PriceState priceState, int amount)
    {
        _name = name;
        _sort = sort;
        _price = price;
        _priceState = priceState;
        _amount = amount;
    }
}