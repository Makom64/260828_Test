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
        // 카페메뉴 생성
        CafeMenu[] todayMenu = new CafeMenu[5];
        todayMenu[0] = new Drink("아메리카노", 2000, SaleState.Regular);
        todayMenu[1] = new Drink("카페라때", 2000, SaleState.Regular);
        todayMenu[2] = new Drink("아이스티", 2000, SaleState.Regular);
        todayMenu[3] = new Desert("초코칩 쿠키", 2000, SaleState.Regular);
        todayMenu[4] = new Desert("크림치즈 어니언 베이글", 2000, SaleState.Regular);

        // 메뉴 출력
        for (int i = 0; i < todayMenu.Length; i++)
        {
            Console.Write($"{i + 1}. ");
            todayMenu[i].PrintMenu(todayMenu[i]);
        }
        
        Console.WriteLine("--------------------");
        Console.WriteLine("[장바구니]");
        // 장바구니 생성
        List<CafeMenu> menuCart = new List<CafeMenu>(5);
        
        // 장바구니에 메뉴를 담는다.
        foreach (CafeMenu menu in todayMenu)
        {
            menuCart.Add(menu);
        }
        
        // 장바구니에 담은걸 출력해보기
        for (int i = 0; i < menuCart.Count; i++)
        {
            Console.WriteLine($"{menuCart[i]._name}");
        }
        
        Console.WriteLine("--------------------");
        
        
    }
}