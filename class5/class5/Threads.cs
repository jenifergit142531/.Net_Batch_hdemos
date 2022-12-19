using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class5
{
    internal class Threads
    {
        public static void child1()
        {
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine("This is child thread 1");
                Thread.Sleep(500);
            }
        }
        public static void child2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("This is child thread 2");
                //Thread.Sleep(500);
            }
        }

    }
}
