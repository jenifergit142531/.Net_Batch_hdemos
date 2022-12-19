

class Program
{
    string name;
    int purchaseValue;
    public void ClearanceSale()
    {
        Console.WriteLine("Enter your name :");
        name = Console.ReadLine();
        Console.WriteLine("1.Purchase is less than 1000 2.Purchase is between 1000 to 2000 3.Purchase is above 3000");

        Console.WriteLine("Enter your purchase value :");
        purchaseValue = Convert.ToInt32(Console.ReadLine());
        switch(purchaseValue)
        {
            case 1:
                Console.WriteLine("You get a discount of Rs.100");
                break;
            case 2:
                Console.WriteLine("You get a discount of Rs.200");
                break;
            case 3:
                Console.WriteLine("You get a silver coins FREE");
                break;
            default:
                Console.WriteLine("Not a valid number");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.ClearanceSale();
    }
}
