using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test etmek istediğiniz iki sayıyı girin.");

        Console.Write("Sayı 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Sayı 2: ");
        int b = int.Parse(Console.ReadLine());

        int actual = Topla(a, b);

        Console.Write("Beklediğiniz sonuç nedir? ");
        int expected = int.Parse(Console.ReadLine());

        RunTest(actual, expected, $"Test: {a} + {b}");
    }

    // Toplama işlemi yapan metot
    static int Topla(int x, int y)
    {
        return x + y;
    }

    // Test çıktısını kontrol eden metot
    static void RunTest(int actual, int expected, string testName)
    {
        Console.WriteLine("\nTest Sonucu:");
        if (actual == expected)
        {
            Console.WriteLine($"[GEÇTİ] {testName} → Beklenen = {expected}, Gerçek = {actual}");
        }
        else
        {
            Console.WriteLine($"[KALDI] {testName} → Beklenen = {expected}, Gerçek = {actual}");
        }
    }
}
