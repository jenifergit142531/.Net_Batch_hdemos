using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class FirstThread
    {
        public static void Work1()
        {
            for(int i=0; i<=10;i++)
            {
                Console.WriteLine("Thread 1");
            }
        }
    }
}
