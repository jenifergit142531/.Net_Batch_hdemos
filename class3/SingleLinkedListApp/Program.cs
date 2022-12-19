class Node
{
    public int data;  //variable - value type
    public Node next; // object - reference type
    public Node prev;
};

class LinkedList
{
    public Node head;

    public LinkedList()
    {
        head = null;
    }

    public void showData()
    {
        Node temp = new Node();
        temp = this.head;
        if(temp!=null)
        {
            Console.WriteLine("The list contains :");
            while(temp!=null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;

                //to break the infinite execution
                if (temp == this.head)
                    break;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The list is empty");
        }
    }
};



class Program
{
    public static void Main(string[] args)
    {


        LinkedList mylist = new LinkedList();


        //creating node 1

        Node first = new Node();
        first.data = 10;
        first.next = null;
        first.prev = null;

        //linking head node 
        mylist.head = first;

        //inserting 4th node between first & second nodes

        Node four = new Node();
        four.data = 40;
        first.next = four;
        four.prev = first;
       

        //creating node 2 

        Node second = new Node();
        second.data = 20;
        second.next = null;
        second.prev = first;
        //linking to first node
        four.next = second;



        //creating node 3
        Node third = new Node();
        third.data = 30;
        //third.next = null;
        third.prev = second;
        //linking to second node
        second.next = third;

        third.next = mylist.head;
        //mylist.head.prev = third;

       




        mylist.showData();
    }
}
