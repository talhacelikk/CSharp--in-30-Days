using System;
using System.Collections.Generic;

class Node
{
    public int data;      // Düğümdeki veri
    public Node next;     // Bir sonraki düğüme referans

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

class Program
{
    // Bağlı listedeki ardışık tekrar eden düğümleri kaldırır
    public static Node removeDuplicates(Node head)
    {
        Console.WriteLine("Tekrar eden elemanlar siliniyor...");

        Node start = head;
        Node checkDup = null;

        while (start != null)
        {
            if (start.next != null)
            {
                checkDup = start.next;

                // Eğer ardışık düğümler aynı değere sahipse, tekrar eden düğüm atlanır
                if (start.data == checkDup.data)
                {
                    Console.WriteLine($"Tekrar eden değer bulundu: {checkDup.data}, düğüm kaldırıldı.");
                    Node deletedNode = checkDup;
                    checkDup = null;
                    start.next = deletedNode.next; // Silinen düğümün bağlantısı atlanır
                }
                else
                {
                    start = start.next; // Değer farklıysa bir sonraki düğüme geç
                }
            }
            else
            {
                start = start.next; // Listenin sonuna gelindiyse çık
            }
        }
        return head;
    }

    // Listeye yeni düğüm ekler (başa değil, sona)
    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);

        if (head == null)
        {
            Console.WriteLine($"İlk düğüm eklendi: {data}");
            head = p;
        }
        else if (head.next == null)
        {
            Console.WriteLine($"İkinci düğüm eklendi: {data}");
            head.next = p;
        }
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;

            Console.WriteLine($"Yeni düğüm sona eklendi: {data}");
            start.next = p;
        }
        return head;
    }

    // Listeyi ekrana yazdırır
    public static void display(Node head)
    {
        Console.WriteLine("Güncel Liste:");
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
        Console.WriteLine(); // Yeni satıra geç
    }

    static void Main(String[] args)
    {
        Node head = null;

        Console.WriteLine("Kaç sayı gireceksin?");
        int T = Int32.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            Console.Write("Sayı gir: ");
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }

        head = removeDuplicates(head);
        display(head);
    }
}
