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
        CafeMenu[] todayMenu = new CafeMenu[5];
        todayMenu[0] = new Drink("아메리카노", 2000, SaleState.Regular);
        todayMenu[1] = new Drink("카페라때", 2000, SaleState.Regular);
        todayMenu[2] = new Drink("아이스티", 2000, SaleState.Regular);
        todayMenu[3] = new Desert("초코칩 쿠키", 2000, SaleState.Regular);
        todayMenu[4] = new Desert("크림치즈 어니언 베이글", 2000, SaleState.Regular);
        
        Console.WriteLine("--------------------");
        Console.WriteLine("[장바구니]");
        Console.WriteLine("--------------------");
        
        
    }
}