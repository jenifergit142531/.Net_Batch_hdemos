
class Payscale
{
    //abstract method (this is empty and has no definition)
    public virtual void salary(int basesalary)
    {
        Console.WriteLine("Base class invoked");
    }


    //concrete method(has some definition)
    public void Policy()
    {
        Console.WriteLine("Payscale policy varies with departments and subject to changes");
    }

}

class HR : Payscale
{
  public override void salary(int bs)
    {

        Console.WriteLine("HR Salary" + bs*5000);
    }
}
class Sales : Payscale
{
    public override void salary(int bs)
    {
        Console.WriteLine("Sales Salary" + bs * 2500);
    }
}

class SE : Payscale
{
    public override void salary(int bs)
    {
        Console.WriteLine("Software Engineer Salary" + bs);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        HR ob1 = new HR();
        ob1.salary(40000);

        Sales ob2 = new Sales();
        ob2.salary(40000);

        SE ob3 = new SE();
        ob3.salary(75000);

        Payscale ps = new Payscale();
        ps.salary(12);

        ob1.Policy();


    }
}
