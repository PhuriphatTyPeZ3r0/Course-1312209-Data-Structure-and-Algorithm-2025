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

class CircularSinglyLinkedList
{
    private Node? head;
    private Node? tail;

    public CircularSinglyLinkedList()
    {
        head = null;
        tail = null;
    }

    // เพิ่มโหนดที่ท้ายลิสต์ (Add last)
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            newNode.Next = head; // circular to itself
        }
        else
        {
            tail!.Next = newNode;
            tail = newNode;
            tail.Next = head; // keep circular link
        }
    }

    // ลบโหนดแรกของลิสต์ (Remove first) - คืนค่า int? ของข้อมูลที่ถูกลบ
    public int? RemoveFirst()
    {
        if (head == null)
        {
            return null; // empty
        }

        int removed = head.Data;

        if (head == tail) // only one node
        {
            head = null;
            tail = null;
            return removed;
        }

        head = head.Next;
        tail!.Next = head; // maintain circular link
        return removed;
    }

    // แสดงข้อมูลทั้งหมด (วนรอบได้แต่หยุดเมื่อครบ 1 รอบ)
    public void PrintOnce()
    {
        if (head == null)
        {
            Console.WriteLine("ลิสต์ว่าง");
            return;
        }

        Node current = head;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Next!;
        } while (current != head);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        var list = new CircularSinglyLinkedList();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("--- Circular Singly Linked List ---");
            Console.WriteLine("1. เพิ่มโหนดที่ท้ายลิสต์");
            Console.WriteLine("2. ลบโหนดแรกของลิสต์");
            Console.WriteLine("3. แสดงข้อมูลทั้งหมด (วนรอบ 1 รอบ)");
            Console.WriteLine("4. ออกจากโปรแกรม");
            Console.Write("กรุณาเลือก: ");
            string? choice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choice)) continue;

            switch (choice.Trim())
            {
                case "1":
                    Console.Write("ใส่ค่าจำนวนเต็มที่ต้องการเพิ่ม: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int val))
                    {
                        list.AddLast(val);
                        Console.WriteLine($"เพิ่ม {val} เรียบร้อย");
                    }
                    else
                    {
                        Console.WriteLine("ค่าที่ป้อนไม่ถูกต้อง");
                    }
                    break;
                case "2":
                    var removed = list.RemoveFirst();
                    if (removed is null)
                        Console.WriteLine("ลิสต์ว่าง ไม่มีอะไรให้ลบ");
                    else
                        Console.WriteLine($"ลบค่า {removed} ออกแล้ว");
                    break;
                case "3":
                    Console.WriteLine("ข้อมูลในลิสต์ (หยุดเมื่อครบ 1 รอบ):");
                    list.PrintOnce();
                    break;
                case "4":
                    Console.WriteLine("ออกจากโปรแกรม");
                    return;
                default:
                    Console.WriteLine("ตัวเลือกไม่ถูกต้อง");
                    break;
            }
        }
    }
}