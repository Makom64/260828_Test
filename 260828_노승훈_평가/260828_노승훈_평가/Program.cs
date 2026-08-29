using System;

public class Program
{
    public static void Main(string[] args)
    {
        const string BURGER_STORE = "매콤리아";
        
        // 배열로 메뉴 만들어보기
        MenuInfo[] todayMenu = new MenuInfo[6];
        todayMenu[0] = new Burger("매콤 버거", 5000);
        todayMenu[1] = new Burger("매콤 치즈 버거", 5500);
        todayMenu[2] = new Side("감자튀김 L", 2000, MenuSize.Large);
        todayMenu[3] = new Side("감자튀김 S",2000, MenuSize.Small);
        todayMenu[4] = new Drink("매콤 콜라 S", 2000, MenuSize.Small);
        todayMenu[5] = new Drink("매콤 사이다 L", 2000, MenuSize.Large);

        for (int i = 0; i < todayMenu.Length; i++)
        {
            Console.Write($"{i+1}. ");
            todayMenu[i].PrintMenu();
        }
        
        // 장바구니 만들기
        List<MenuInfo> cart = new List<MenuInfo>();
        cart.Add(todayMenu[0]); // 매콤 버거
        cart.Add(todayMenu[3]); // 감튀s
        cart.Add(todayMenu[5]); // 사이다L
        cart.Add(todayMenu[3]); // 감튀s
        cart.Add(todayMenu[1]); // 치즈 버거
        
        // 장바구니에 담긴 것들 출력해보기
        foreach (MenuInfo m in cart)
        {
            Console.WriteLine($"{m.name}");
        }

        Console.WriteLine($"{cart.Count}");
    }
}