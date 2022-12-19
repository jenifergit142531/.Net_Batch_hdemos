
using System.Collections;
using System.ComponentModel.DataAnnotations;

class Movie
{
    public string MovieName { get; set; }
    public int TicketPrice { get; set; }

}
class Program
{

    public static void showHashSet()
    {
        HashSet<string> hs1 = new HashSet<string>();
        hs1.Add("C#");
        hs1.Add("Java");
        hs1.Add("go");

         foreach(var i in hs1)
        {
            Console.WriteLine("HASHSET1: " +i);
        }

        HashSet<string> hs2 = new HashSet<string>();
        hs2.Add("C#");
        hs2.Add("C#");
        hs2.Add("PHP");

        foreach (var i in hs2)
        {
            Console.WriteLine("Hahset2 :"+i);
        }

        //hs1.UnionWith(hs2);
        // hs1.IntersectWith(hs2);
        hs1.ExceptWith(hs2);
        foreach (var i in hs1)
        {
            Console.WriteLine("after union  :" + i);
        }

    }

    public static void showHashtable()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "aaa");
        ht.Add(2, "aaa");
        ht.Add(3, null);
        ht.Add("a", "aaa");

        foreach(var i in ht.Keys)
        {
            Console.WriteLine(ht[i]);
        }


    }














    public static void showStack()
    {
        //non generic stack
        Stack st1 = new Stack();
        st1.Push(10);
        st1.Push("abc");
        st1.Push(12.45);

        //generic stack of int type
        Stack<int> st2 = new Stack<int>();
        st2.Push(10);
        st2.Push(20);

        Console.WriteLine("Non generic stack :");
        foreach(var i in st1)
        {
            Console.WriteLine(i);
        }
        st1.Pop();
        Console.WriteLine("after pop Non generic stack :");
        foreach (var i in st1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Generic stack :");
        foreach (var i in st2)
        {
            Console.WriteLine(i);
        }


    }
    public static void showQueue()
    {
        
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(23.12f);
            q.Enqueue("hello");
            q.Enqueue(45.64d);

            Queue<string> s = new Queue<string>();
            s.Enqueue("hello");
            s.Enqueue("world");
            s.Enqueue("generic queue");
            Console.WriteLine("non Generic queue:");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Generic queue:");
            foreach (string j in s)
            {
                Console.WriteLine(j);
            }
            s.Dequeue();
            Console.WriteLine("after popping:");
            foreach (string j in s)
            {
                Console.WriteLine(j);
            }
        

    }
    public static void ShowList()
    {
        var movies = new List<Movie>()
      {
          new Movie(){MovieName="avatar",TicketPrice=300},
          new Movie(){MovieName="tenet",TicketPrice=200},
          new Movie(){MovieName="Inception",TicketPrice=250}

      };
        Console.WriteLine("Total elements :" + movies.Count);
        foreach(var i in movies)
        {
            Console.WriteLine("Movie Name :" + i.MovieName);
            Console.WriteLine("Ticketprice :" + i.TicketPrice);
        }
    }
   public static void showArrayList()
    {
        ArrayList ar = new ArrayList();
        ar.Add(10);
        ar.Add("jeni");
        ar.Add(12.45);
        ar.Add(1234);
        ar.Add(20);
        ar.Add("abcd");
        ar.Add(1234);
        ar.Add(20);
        ar.Add("abcd");

        Console.WriteLine("Length :" + ar.Count);
        Console.WriteLine("Capacity :" + ar.Capacity);

        foreach(var i in ar)
        {
            Console.WriteLine(i);
        }

    }
    public static void Main(string[] args)
    {

        showHashtable();
        //showHashSet();
        //showQueue();
        //showStack();
        //ShowList();
        //showArrayList();
    }
}
