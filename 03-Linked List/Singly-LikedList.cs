using System;
class Node
{
    public int Data;
    public Node? Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
class LinkedList
{
    private Node? head;
    public LinkedList()
    {
        head = null;
    }
    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    public void PrintList()
    {
        Node? current = head;
        while (current != null)
        {
            Console.Write(current.Data + " --> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.AddLast(70);
            list.AddLast(80);
            list.AddLast(90);
            list.AddLast(100);

            Console.WriteLine("Show Data in LinkedList: ");
            list.PrintList();
        }
    }
}