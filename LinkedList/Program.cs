using System;
using LinkedList;

class Program
{
    public Node head;
    public void AddNode(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        head = new_node;
    }
    public void Peek()
    {
        Node lastnode = head;
            Console.Write(lastnode.data);
    }
    public void Print()
    {
        Node tnode = head;
        while (tnode != null)
        {
            Console.Write(tnode.data + " ");
            tnode = tnode.next;
        }
    }
    public static void Main(String[] args)
    {
        Program llist = new Program();

        llist.AddNode(7);
        llist.AddNode(1);
        llist.AddNode(3);
        llist.AddNode(5);
        llist.AddNode(6);
        llist.AddNode(1);

        Console.Write("Created Linked list is: ");
        llist.Print();
        Console.Write("\n\nLast added value is:");
        llist.Peek();
        Console.Write("\n");
    }
}