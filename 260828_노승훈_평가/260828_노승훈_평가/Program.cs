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
    }
}