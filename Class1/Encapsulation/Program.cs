class One
{
    public string name;
    public int age;

    public void show()
    {
        Console.WriteLine("This is a private method");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        One one = new One();
        one.name = "Jeni";
        one.age = 26;
        one.show();
    }
}
