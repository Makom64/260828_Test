public class MenuCart<T> where T : CafeMenu, AddCart
{
    private List<T> menuCart; // 장바구니 배열
    private int AddedMenu; // 더한 메뉴
    
    public MenuCart(int count)
    {
        menuCart = new List<T>(count);
        AddedMenu = count; // 담은 메뉴 = 장바구니 크기
    }

    // CafeMenu(무엇인지 모름)을 배열에 담아주는 메서드
    public void Add(T menu)
    {
        menuCart.Add(menu);
        Console.WriteLine($"{menu._name}을 담았습니다.");
    }

    public void AddtoCart(T menu)
    {
        menuCart.Add(menu);
        Console.WriteLine($"{menu._name}을(를) 담았습니다.");
    }

    public T Get(int number) // 번호를 받는다, 반환형이 T일것
    {
        return menuCart[number];
    }
}