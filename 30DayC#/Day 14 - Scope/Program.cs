using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] numbers)
    {
        elements = numbers;
        maximumDifference = 0;
    }
    public void computeDifference()
    {
        int max = elements.Max();
        int min = elements.Min();
        maximumDifference = Math.Abs(max - min);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç adet sayı gireceksin? ");
        int count =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Lütfen {count} adet sayıyı boşlukla ayırarak gir:");
        int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (a.Length != count)
        {
            Console.WriteLine($"Hatalı giriş: {count} sayı bekleniyordu ama {a.Length} sayı girildi.");
            return;
        }
        Difference d = new Difference(a);
        d.computeDifference();
        Console.WriteLine("Maximum fark: " + d.maximumDifference);

    }
}