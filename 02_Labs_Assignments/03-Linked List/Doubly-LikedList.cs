using System;
class Node
{
    public int Data;
    public Node? Next;
    public Node? Prev;
    public Node(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

class DoublyLinkedList
{
    private Node? head;
    private Node? tail;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
    }
    public void InsertAtHead(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
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
    public void DeleteAtTail()
    {
        if (tail == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        if (head == tail)
        {
            head = tail = null;
        }
        else
        {
            tail = tail.Prev;
            if (tail != null) tail.Next = null;
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
}

class Program
{
    public static void Main()
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.InsertAtHead(10);
        list.InsertAtHead(20);
        list.InsertAtHead(30);
        list.DeleteAtTail();
        list.AddLast(99);
        list.PrintList();
        
    }
}