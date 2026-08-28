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
        Menu[] todayMenu = new Menu[6];
        todayMenu[0] = new Menu("아메리카노",2000,PriceState.Regular,10,Sort.Drink);
        todayMenu[1] = new Menu("아이스티",2300,PriceState.Regular,10,Sort.Drink);
        todayMenu[2] = new Menu("카페 라때",2900,PriceState.Regular,10,Sort.Drink);
        todayMenu[3] = new Menu("크림치즈 어니언 베이글",3900,PriceState.Discount,8,Sort.Desert);
        todayMenu[4] = new Menu("초코칩 쿠키",1500,PriceState.Regular,5,Sort.Drink);
        todayMenu[5] = new Menu("매콤 텀블러",5500,PriceState.Regular,1,Sort.Merch);
        foreach (Menu menu in todayMenu)
        {
            PrintInfo(menu);
        }
        
        Console.WriteLine("--------------------");
        Console.WriteLine("[장바구니]");
        Console.WriteLine("--------------------");
    }
    public static void PrintInfo(Menu m)
    {
        Console.WriteLine($"{m.Name}({m.Sort})  {m.Price}원[{m.PriceState}]  남은 수량: {m.Amount}");
    }
}