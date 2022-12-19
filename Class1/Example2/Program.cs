
interface FoodApp
{
    public void FoodMenu();

    //public void billing();
}


class User1 : FoodApp
{
    public void FoodMenu()
    {
        Console.WriteLine("Get me a cup of cofee");
    }
}
class User2 : FoodApp
{
    public void FoodMenu()
    {
        Console.WriteLine("1 Briyani with chicken 65 combo");
    }
}


class Program
{
    public static void Main(string[] args)
    {
        User1 order1 = new User1();
        order1.FoodMenu();

        User2 order2 = new User2();
        order2.FoodMenu();
    }
}
