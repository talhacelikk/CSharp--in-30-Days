using System;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class Program
{
    static int GetHeight(Node node)
    {
        if (node == null)
            return -1; // kenar sayısı için -1, seviye sayısı için 0 yaparsın

        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);

        return 1 + Math.Max(leftHeight, rightHeight);
    }


    static Node Insert(Node root, int data)
    {
        if (root == null)
        {
            Console.WriteLine($"Yeni düğüm eklendi: {data}");
            return new Node(data);
        }
        else
        {
            if (data <= root.data)
            {
                Console.WriteLine($"{data} <= {root.data} → sola gidiliyor");
                root.left = Insert(root.left, data);
            }
            else
            {
                Console.WriteLine($"{data} > {root.data} → sağa gidiliyor");
                root.right = Insert(root.right, data);
            }
            return root;
        }
    }


    static void Main(String[] args)
    {
        Node root = null;
        Console.Write("Kaç sayı gireceksin: ");
        int T = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen sayıları sırayla girin:");
        while (T-- > 0)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            root = Insert(root, data);
        }

        int height = GetHeight(root);
        Console.WriteLine("Ağacın yüksekliği: " + height);

 
    }
}

