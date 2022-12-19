using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class MyDictionary
    {
        public static void ShowDictionary()
        {
            Dictionary<int, string> animals = new Dictionary<int, string>();
            animals.Add(5, "Dog");
            animals.Add(3, "Cat");
            animals.Add(1, "Cow");
            animals.Add(2, "Panda");
            animals.Add(4, "Bear");
            Console.WriteLine("Dictionary :");
            foreach(KeyValuePair<int,string> pair in animals)
            {
                Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
            }

        }

        public static void showSortedDictionary()
        {
          SortedDictionary<int, string> animals = new SortedDictionary<int, string>();
            animals.Add(5, "Dog");
            animals.Add(3, "Cat");
            animals.Add(1, "Cow");
            animals.Add(2, "Panda");
            animals.Add(4, "Bear");
            Console.WriteLine("Sorted Dictionary :");
            foreach (KeyValuePair<int, string> pair in animals)
            {
                Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
            }
        }
    }
}
