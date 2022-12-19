using class5;

class Program
{
    public static void Main(string[] args)
    {
        DataParallelism.showLoop();
        /*Creating TPL

        Task t1 = Task.Run(() =>
        {
            TPLDemo.IndianFood();
        });
     */
       // TPLDemo.IndianFood();
        //TPLDemo.ChineseFood();
       // TPLDemo.Continental();
       // Console.WriteLine("Food ready to serve");




        /*foreground thread

        Thread th = new Thread(Threads.child1)
        {
            IsBackground = true
        };
        th.Start();
        Console.WriteLine("Main thread quits");



        /*Synchronous execution
        Console.WriteLine("Sync");
        Threads.child2();
        Threads.child1();

        //Asynchronous execution
        Console.WriteLine("ASync");
        Thread t1 = new Thread(Threads.child1);
        
        Thread t2 = new Thread(Threads.child2);

        t1.Start();
        t1.Join();
        t2.Start();

        */



    }
}