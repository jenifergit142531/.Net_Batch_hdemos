class BrowsingHistory
{
    string topics;
    int durationInHours;
    public BrowsingHistory()
    {
        topics = "Politics";
        durationInHours = 2;

        Console.WriteLine("Search on trading / politics");
    }

    ~BrowsingHistory()
    {
        Console.WriteLine("Delete my search history");
    }
}

class Program
{
    public static void invoke()
    {
        BrowsingHistory history = new BrowsingHistory();
    }
    public static void Main(string[] args)
    {
        invoke();
        GC.Collect();
        Console.ReadLine();

    }
}
