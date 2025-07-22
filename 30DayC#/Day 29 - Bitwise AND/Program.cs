using System;
using System.Collections.Generic;

class Program
{
    // testData: Her elemanı "n k" şeklinde string içeren dizi
    // Her test için 1..n arası sayılar arasında bitwise AND sonucu k'dan küçük olan maksimum değeri bulur
    public static void maxBitwise(string[] testData)
    {
        int testCases = testData.Length; // Toplam test sayısı

        for (int index = 0; index < testCases; index++)
        {
            string[] nk = testData[index].Split(' ');
            int n = Convert.ToInt32(nk[0]); // 1'den n'ye kadar sayılar
            int k = Convert.ToInt32(nk[1]); // Limit k

            int[] sNumbers = new int[n]; // Sayılar dizisi
            List<int> bitwiseNumbers = new List<int>(); // Bitwise sonuçları

            // Diziyi dolduruyoruz: 1, 2, ..., n
            for (int i = 1; i <= n; i++)
                sNumbers[i - 1] = i;

            int indexA = 0;
            int indexB = 1;

            // Tüm çift kombinasyonları dene
            while (indexA < n)
            {
                while (indexB < n)
                {
                    Console.WriteLine($"İşlemde olan sayılar: {sNumbers[indexA]} & {sNumbers[indexB]}");

                    int c = sNumbers[indexA] & sNumbers[indexB]; // Bitwise AND

                    if (c < k)
                        bitwiseNumbers.Add(c); // Koşulu sağlayan sonuçları ekle

                    indexB++;
                }
                indexA++;
                indexB = indexA + 1;
            }

            // Sonuçları sırala ve en büyüğünü al
            var resultData = bitwiseNumbers.ToArray();
            Array.Sort(resultData);

            Console.WriteLine($"Test {index + 1} sonucu (maksimum bitwise AND < {k}): {resultData[resultData.Length - 1]}");
            Console.WriteLine("------------------------------------------------------------");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Kaç test yapmak istiyorsunuz?");
        int t = Convert.ToInt32(Console.ReadLine());

        string[] testData = new string[t];

        for (int i = 0; i < t; i++)
        {
            Console.WriteLine($"{i + 1}. test için 'n k' değerlerini aralarına boşluk koyarak girin:");
            testData[i] = Console.ReadLine();
        }

        maxBitwise(testData);
    }
}
