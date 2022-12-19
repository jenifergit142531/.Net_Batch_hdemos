using class4;

class Program
{

    //Main Thread
    public static void Main(string[] args)
    {
        Thread th = Thread.CurrentThread;
        th.Name = "Main thread";
        Console.WriteLine(th.Name);

        Thread t1 = new Thread(FirstThread.Work1);
        t1.Start();





        //  DateTimeAPI.DateTimeInfo();
        // StringBuilderApp.MyBuilderWrite();

        // Binary.MyBinaryWriter();
        // Binary.MyBinaryReader();
        // Text.MyTextWriter();
        // Text.MyTextReader();
        
       // StreamIO.CreateDirectory();
        //StreamIO.MystreamWriter();
        //StreamIO.MystreamReader();
    }
}
