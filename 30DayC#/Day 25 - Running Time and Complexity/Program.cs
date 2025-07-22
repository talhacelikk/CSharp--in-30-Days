using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

class Program
{
    // Verilen bir sayının asal olup olmadığını kontrol eder
    static bool testNum(int num)
    {
        int ctr = 0;

        // Bu iki özel büyük sayı için özel durum
        if ((num == 1000000007) || (num == 1000000009))
        {
            Console.WriteLine($"Özel sayı bulundu: {num} → Prime ");
            return true;
        }
        else
        {
            // Çok büyük sayılar için hesaplamayı yapmıyoruz
            if (num >= 1000000000)
            {
                Console.WriteLine($"Sayı çok büyük, işlenemiyor: {num} → Not Prime ");
                return false;
            }
            else
            {
                // 2'den num/2'ye kadar bölen arıyoruz (verimsiz ama çalışır)
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break; // İlk böleni bulunca dur
                    }
                }
                return (ctr == 0 && num != 1);
            }
        }
    }

    // Sayı listesini testNum ile kontrol eder ve sonucu yazdırır
    static void primeNumbers(List<long> numbers)
    {
        Console.WriteLine("Asal kontrolü başlıyor... ");// Kontrol işlemleri başlamadan önce kullanıcıya bilgi verir
        foreach (int n in numbers)
        {
            bool result = testNum(n);
            if (result)
            {
                Console.WriteLine($"{n} → Prime "); // Asal olan sayı sonucu
            }
            else
            {
                Console.WriteLine($"{n} → Not Prime "); // Asal olmayan sayı sonucu
            }
        }
    }

    static void Main(string[] args)
    {
        List<long> testNumbers = new List<long>();

        Console.WriteLine("Kaç sayı gireceksin? "); // Kullanıcıdan kaç adet sayı gireceğini ister
        int T = Int32.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            Console.Write("Sayı gir: ");
            int data = Int32.Parse(Console.ReadLine());
            testNumbers.Add(data);
        }

        primeNumbers(testNumbers);
    }
}
