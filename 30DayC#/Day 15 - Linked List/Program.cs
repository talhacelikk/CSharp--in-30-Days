using System;

class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}

class Program
{
    public static Node insert(Node head, int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        return head;
    }

    public static void display(Node head)
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
    }

    static void Main(string[] args)
    {
        Node head = null;
        Console.Write("Kaç sayı gireceksin? ");
        int T = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Sayıları gir:");
        while (T-- > 0)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            head = insert(head, data);
        }

        Console.WriteLine("Bağlı listen:");
        display(head);
    }
}
