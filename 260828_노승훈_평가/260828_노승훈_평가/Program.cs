using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 기본 기능 생성 후
        // 기능 하나씩 늘려나가보기
        const string STORE = "매콤 카페";
        Console.WriteLine("--------------------");
        Console.WriteLine($"{STORE} 키오스크");
        Console.WriteLine("--------------------");
        Console.WriteLine("[메뉴판]");
        // 카페메뉴 생성
        CafeMenu[] todayMenu = new CafeMenu[5];
        todayMenu[0] = new Drink("아메리카노", 2000, SaleState.Regular);
        todayMenu[1] = new Drink("매콤 라때", 2000, SaleState.Regular);
        todayMenu[2] = new Drink("아이스티", 2000, SaleState.Regular);
        todayMenu[3] = new Desert("매콤 초코칩 쿠키", 2000, SaleState.Regular);
        todayMenu[4] = new Desert("매콤치즈 어니언 베이글", 2000, SaleState.Regular);

        // 장바구니 생성
        List<CafeMenu> menuCart = new List<CafeMenu>(5);
        
        // 메뉴 출력
        for (int i = 0; i < todayMenu.Length; i++)
        {
            Console.Write($"{i + 1}. ");
            todayMenu[i].PrintMenu(todayMenu[i]);
        }
        Console.WriteLine("--------------------");
        
        // 장바구니에 메뉴를 담고 안내한다.
        foreach (CafeMenu menu in todayMenu)
        {
            menuCart.Add(menu);
            Console.WriteLine($"{menu._name}을(를) 담았습니다.");
        }
        Console.WriteLine("--------------------");
        
        // 장바구니에 담은걸 출력해보기
        Console.WriteLine("[장바구니]");
        for (int i = 0; i < menuCart.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuCart[i]._name}");
        }
        Console.WriteLine("--------------------");
        
        // 장바구니를 비우면서 출력하기
        menuCart.Remove(todayMenu[0]); // 아메리카노
        menuCart.Remove(todayMenu[3]); // 쿠키
        menuCart.Remove(todayMenu[4]); // 베이글
        Console.WriteLine($"{todayMenu[0]._name}을(를) 제외했습니다.");
        Console.WriteLine($"{todayMenu[3]._name}을(를) 제외했습니다.");
        Console.WriteLine($"{todayMenu[4]._name}을(를) 제외했습니다.");
        Console.WriteLine("--------------------");
        
        // 장바구니가 잘 비었다면 출력해보기
        if (menuCart.Count != 0)
        {
            for (int i = 0; i < menuCart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuCart[i]._name}");
            }
        }
        else
        {
            Console.WriteLine("장바구니가 비어있습니다.");
        }
        Console.WriteLine("--------------------");
        
        // 이번엔 한번에 없앤다.
        menuCart.Clear();
        Console.WriteLine("장바구니를 비웠습니다.");
        Console.WriteLine("--------------------");
        
        // 장바구니가 잘 비었다면 출력해보기
        if (menuCart.Count != 0)
        {
            for (int i = 0; i < menuCart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuCart[i]._name}");
            }
        }
        else
        {
            Console.WriteLine("장바구니가 비어있습니다.");
        }
        Console.WriteLine("--------------------");
        
        // 이번엔 중복해서 담아보기
        // + 가격도 더하고 출력하기
        int totalPrice = 0;
        menuCart.Add(todayMenu[0]); // 커피
        Console.WriteLine($"{todayMenu[0]._name}을(를) 담았습니다.");
        totalPrice += todayMenu[0]._price;
        menuCart.Add(todayMenu[0]);
        Console.WriteLine($"{todayMenu[0]._name}을(를) 담았습니다.");
        totalPrice += todayMenu[0]._price;
        menuCart.Add(todayMenu[4]); // 베이글
        Console.WriteLine($"{todayMenu[4]._name}을(를) 담았습니다.");
        totalPrice += todayMenu[4]._price;
        menuCart.Add(todayMenu[4]);
        Console.WriteLine($"{todayMenu[4]._name}을(를) 담았습니다.");
        totalPrice += todayMenu[4]._price;
        // 인터페이스로 만들 것:
        
        
    }
}