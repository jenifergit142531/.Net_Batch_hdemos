class Program
{
    public static void Divide()
    {
        try
        {
            Console.WriteLine("Enter numerator :");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Denominator :");
            int denominator = Convert.ToInt32(Console.ReadLine());
            int result = numerator / denominator;
            Console.WriteLine("Result is : " + result);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("All good and well");
        }
        

    }
    public static void Main(string[] args)
    {
        Divide();
    }
}
