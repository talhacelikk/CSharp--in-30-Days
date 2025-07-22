using System;
using System.Collections.Generic;

class Node
{
    public Node left, right; // Sol ve sağ çocuklar
    public int data;         // Düğümdeki değer

    public Node(int data)
    {
        this.data = data;
        left = right = null; // Başlangıçta çocuk yok
    }
}

class Program
{
    // Ağaçta seviyeye göre (level-order) gezinti ve elemanları yazdırma
    static void LevelOrder(Node root)
    {
        if (root == null)
        {
            Console.WriteLine("Ağaç boş, yazdırılacak düğüm yok.");
            return; // Ağaç boşsa işlemi sonlandır
        }

        Queue<Node> nodeQueue = new Queue<Node>(); // Kuyruk oluşturuyoruz
        nodeQueue.Enqueue(root); // Kökü kuyruğa ekle

        Console.WriteLine("Level order traversal (seviye sırasıyla):");
        while (nodeQueue.Count > 0) // Kuyruk boşalana kadar devam et
        {
            Node currentNode = nodeQueue.Dequeue(); // Sıradaki düğümü al
            Console.Write(currentNode.data + " "); // Düğüm değerini yazdır

            if (currentNode.left != null)           // Sol çocuk varsa
                nodeQueue.Enqueue(currentNode.left); // Kuyruğa ekle

            if (currentNode.right != null)          // Sağ çocuk varsa
                nodeQueue.Enqueue(currentNode.right); // Kuyruğa ekle
        }
        Console.WriteLine(); // Son satırda boşluk bırak
    }

    // Binary Search Tree'ye yeni düğüm ekleme metodu
    static Node Insert(Node root, int data)
    {
        if (root == null) // Eğer ağaç boşsa yeni düğüm oluştur
        {
            Console.WriteLine($"Yeni düğüm oluşturuldu: {data}");
            return new Node(data);
        }

        if (data <= root.data)
        {
            Console.WriteLine($"{data} <= {root.data} → Sola gidiliyor");
            root.left = Insert(root.left, data); // Küçük veya eşitse sola ekle
        }
        else
        {
            Console.WriteLine($"{data} > {root.data} → Sağa gidiliyor");
            root.right = Insert(root.right, data); // Büyükse sağa ekle
        }

        return root; // Güncellenmiş ağacı geri döndür
    }

    static void Main(string[] args)
    {
        Console.Write("Kaç tane sayı gireceksin? ");
        int T = int.Parse(Console.ReadLine()); // Kaç tane sayı gireceksin?

        Node root = null; // Başlangıçta boş ağaç

        Console.WriteLine("Lütfen sayıları sırayla girin:");
        for (int i = 0; i < T; i++)
        {
            int data = int.Parse(Console.ReadLine()); // Sayıyı oku
            root = Insert(root, data); // Ağaca ekle
        }

        LevelOrder(root); // Ağacı seviyelere göre yazdır
    }
}
