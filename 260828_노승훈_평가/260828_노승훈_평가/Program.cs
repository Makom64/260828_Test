using System;

public class Program
{
    public static void Main(string[] args)
    {
        const string STORE = "매콤정";
        Console.WriteLine("--------------------");
        Console.WriteLine($"{STORE} 키오스크");
        Console.WriteLine("--------------------");
        Console.WriteLine("[메뉴판]");
        CafeMenu[] todayMenu = new CafeMenu[6];
        todayMenu[0] = new CafeMenu( "아메리카노", CafeMenu.Sort.Drink,2000, CafeMenu.PriceState.Regular, 10);
        todayMenu[1] = new CafeMenu( "카페라때", CafeMenu.Sort.Drink,2300, CafeMenu.PriceState.Regular, 10);
        todayMenu[2] = new CafeMenu( "아이스티",CafeMenu.Sort.Drink, 1900, CafeMenu.PriceState.Regular, 10);
        todayMenu[3] = new CafeMenu( "어니언 크림치즈 베이글", CafeMenu.Sort.Desert,3500, CafeMenu.PriceState.Discount, 10);
        todayMenu[4] = new CafeMenu( "초코칩 쿠키", CafeMenu.Sort.Desert,2000, CafeMenu.PriceState.Discount, 20);
        todayMenu[5] = new CafeMenu( "매콤 텀블러", CafeMenu.Sort.Merch,5000, CafeMenu.PriceState.Regular, 5);
        
        Console.WriteLine("--------------------");
        Console.WriteLine("[장바구니]");
        Console.WriteLine("--------------------");
        
        
    }
}