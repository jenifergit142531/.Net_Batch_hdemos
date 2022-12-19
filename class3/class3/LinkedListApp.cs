using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class LinkedListApp
    {
        public static void showLinkedList()
        {
            LinkedList<string> list1 = new LinkedList<string>();
            list1.AddLast("Jenifer");
            list1.AddFirst("Mira");
            list1.AddLast("Mitra");


            LinkedListNode<string> node = list1.Find("Mitra");
            list1.AddBefore(node, "Jack");
            list1.AddAfter(node, "Jill");

            foreach(var i in list1)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}
