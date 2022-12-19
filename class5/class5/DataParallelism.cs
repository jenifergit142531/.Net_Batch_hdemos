using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5
{
    internal class DataParallelism
    {
        public static void showLoop()
        {
            Stopwatch watch = new Stopwatch();
            //Regular for loop
            watch.Start();
            Console.WriteLine("Regular for loop :");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            watch.Stop();
            Console.WriteLine($"Time to execute Regular for loop {watch.ElapsedMilliseconds}");

            //Parallel For Loop
            watch.Start();
            Console.WriteLine("Parallel for loop :");
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            watch.Stop();
            Console.WriteLine($"Time to execute PARALLEL FOR loop {watch.ElapsedMilliseconds}");

            //Parallel For Each Loop
            watch.Start();
            Console.WriteLine("Parallel FOR EACH Loop");
            List<int> list1 = Enumerable.Range(0, 10).ToList();
            Parallel.ForEach(list1, i =>
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            watch.Stop();
            Console.WriteLine($"Time to execute PARALLEL FOR loop {watch.ElapsedMilliseconds}");





        }
    }
}
