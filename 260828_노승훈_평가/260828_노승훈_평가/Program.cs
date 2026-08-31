using System;

public class Program
{
    public static void Main(string[] args)
    {
        const string BURGER_STORE = "매콤리아";
        
        int selectSize = Convert.ToInt32(Console.ReadLine());
        
        
        // 배열로 메뉴 만들어보기
        List<MenuInfo> todayMenu = new List<MenuInfo>();
        todayMenu[0] = new Burger("매콤 버거", 5000);
        todayMenu[1] = new Burger("매콤 치즈 버거", 5500);
        todayMenu[2] = new Side("감자튀김 S",2000, MenuSize.Small);
        todayMenu[3] = new Side("감자튀김 L", 2000, MenuSize.Large);
        todayMenu[4] = new Drink("매콤 콜라 S", 2000, MenuSize.Small);
        todayMenu[5] = new Drink("매콤 콜라 L", 2000, MenuSize.Large);
        todayMenu[6] = new Drink("매콤 사이다 S", 2000, MenuSize.Small);
        todayMenu[7] = new Drink("매콤 사이다 L", 2000, MenuSize.Large);

        List<MenuInfo> menuList = new List<MenuInfo>();
        menuList[0] = new Burger("매콤 버거", 5000);
        menuList[1] = new Side("감자튀김 S",2000, MenuSize.Small);
        
        
        
        for (int i = 0; i < todayMenu.Count; i++)
        {
            Console.Write($"{i+1}. ");
            todayMenu[i].PrintMenu();
        }

        bool selectMenu = false;
        List<MenuInfo> cart = new List<MenuInfo>();
        Console.WriteLine("담을 메뉴를 번호로 골라주세요.");
        while (!selectMenu)
        {
            int select = Convert.ToInt32(Console.ReadLine());

            cart.Add(todayMenu[select]);
            Console.WriteLine($"{todayMenu[select].name}을 담았습니다.");
            Console.WriteLine("[1] 결제하기, [2]더 담기, [3]장바구니 비우기");
            int select2 = Convert.ToInt32(Console.ReadLine());

            switch (select2)
            {
                case 1:
                    selectMenu = true;
                    break;
                case 2:
                    for (int i = 0; i < todayMenu.Length; i++)
                    {
                        Console.Write($"{i+1}. ");
                        todayMenu[i].PrintMenu();
                    }
                    Console.WriteLine("담을 메뉴를 번호로 골라주세요.");
                    break;
                case 3:
                    cart.Clear();
                    Console.WriteLine("장바구니를 비웠습니다.");
                    for (int i = 0; i < todayMenu.Length; i++)
                    {
                        Console.Write($"{i+1}. ");
                        todayMenu[i].PrintMenu();
                    }
                    Console.WriteLine("담을 메뉴를 번호로 골라주세요.");
                    break;
            }
        }
        for (int i = 0; i < cart.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cart[i].name} {cart[i].price}");
        }

        int totalPrice = 0;

        foreach (MenuInfo menu in cart)
        {
            totalPrice += menu.price;
        }

        Console.WriteLine($"총 금액: {totalPrice}");
        


        /*
        // 장바구니 만들기
        List<MenuInfo> cart = new List<MenuInfo>();
        cart.Add(todayMenu[0]); // 매콤 버거
        cart.Add(todayMenu[3]); // 감튀s
        cart.Add(todayMenu[5]); // 사이다L
        cart.Add(todayMenu[3]); // 감튀s
        cart.Add(todayMenu[1]); // 치즈 버거
        */

        /*
        for (int i = 0; i < cart.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cart[i].name} {cart[i].price}");
        }

        Console.WriteLine($"장바구니: {cart.Count}");

        Console.WriteLine("========");

        cart.Remove(cart[1]);

        for (int i = 0; i < cart.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cart[i].name} {cart[i].price}");
        }

        Console.WriteLine($"장바구니: {cart.Count}");
        */

    }
}