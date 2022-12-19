class Person
{
    public void behaviour(string friends)
    {
        Console.WriteLine("Vibe with my friend " + friends);
    }
    public void behaviour(string mentor,string topic)
    {
        Console.WriteLine("To study and practice .Net content with {0} on the {1}", mentor, topic); ;
    }
    public void behaviour(string place,DateTime dt)
    {
        Console.WriteLine("My family and I take a holiday to {0} at {1}", place, dt);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.behaviour("Turkey",DateTime.Now);
        p1.behaviour("Mira");
        p1.behaviour("Jenifer", "Polymorphism");
    }
}
