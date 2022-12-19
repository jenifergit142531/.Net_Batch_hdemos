using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6
{
    //Declare the delegate 
    public delegate void delOne();

    public delegate void delTwo(int i,int j);

    //Generic delegate
    public delegate T delThree<T>(T i, T j);


    internal class DelegateApp
    {

        public static void Show()
        {
            Console.WriteLine("Hello delegate ");
        }

        public static void Add(int a,int b)
        {
            Console.WriteLine("Sum : {0}",a+b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtract : {0}", a - b);
        }
        
        //methods for generic delegate

        public static string concat(string a,string b)
        {
            return a + b;
        }

        public static int price(int rate,int amountperQty)
        {
            return rate * amountperQty;
        }
    }
}
