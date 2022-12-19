using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6
{
    internal class TaskParallel
    {
        public TaskParallel()
        {
            Console.WriteLine("Empty constructor");
        }
        public static void TaskParallelism()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            Parallel.Invoke(Method3, Method2, Method1);
            st.Stop();
            Console.WriteLine($"Time taken to exectute is {st.ElapsedMilliseconds} milliseconds");
        }
        public static void Method1()
        {
            Console.WriteLine($"Method 1 is completed by thread ={Thread.CurrentThread.ManagedThreadId}");
        }
        public static void Method2()
        {
            Console.WriteLine($"Method 2 is completed by thread ={Thread.CurrentThread.ManagedThreadId}");

        }
        public static void Method3()
        {
            Console.WriteLine($"Method 3 is completed by thread ={Thread.CurrentThread.ManagedThreadId}");

        }
    }
}
