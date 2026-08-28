public class Kiosk
{
    private MenuInfo menu;

    public Kiosk(string name, int price, PriceState priceState, int amount)
    {
        menu = new MenuInfo(name, price, priceState, amount);
    }
}