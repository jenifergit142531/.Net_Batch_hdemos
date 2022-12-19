
class CouponException : Exception
{
    public CouponException(string? message) : base(message)
    {
    }
}

class Program
{
    static void CouponCode(int code)
    {
        if(code < 100)
        {
            throw new CouponException("Sorry!! This coupon is not valid");
        }
    }


    public static void Main(string[] args)
    {
        try
        {
            CouponCode(101);

        }
        catch(CouponException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("All good and well");
        }
    }
}
