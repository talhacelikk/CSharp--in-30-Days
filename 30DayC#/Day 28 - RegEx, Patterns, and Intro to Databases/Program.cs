using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan kaç veri girişi yapılacağını alıyoruz
        Console.WriteLine("Kaç kişi bilgisi gireceksiniz?");
        int N = Convert.ToInt32(Console.ReadLine());

        List<string> validNames = new List<string>(); // Geçerli Gmail kullanıcılarının isimlerini tutan liste

        // Kullanıcıdan ad ve e-posta adresi alıyoruz
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{i + 1}. kişi için ad ve e-posta girin (örn: Ahmet ahmet@gmail.com)");
            string[] input = Console.ReadLine().Trim().Split(' ');

            if (input.Length != 2)
            {
                Console.WriteLine("Hatalı giriş. Lütfen sadece ad ve e-posta adresi giriniz.");
                i--; // Hatalı giriş durumunda aynı turu tekrar et
                continue;
            }

            string name = input[0];
            string email = input[1];

            
            // Gmail, Yahoo, Hotmail, Outlook e-postalarını yakalayacak doğru regex
            if (Regex.IsMatch(email, "@(gmail|yahoo|hotmail|outlook)\\.com$", RegexOptions.IgnoreCase))
            {
                validNames.Add(name);
            }

        }

        // Kullanıcı adlarını alfabetik sıraya göre sıralıyoruz
        validNames.Sort();

        // Geçerli Mail kullanıcılarının adlarını ekrana yazdırıyoruz
        Console.WriteLine("Geçerli Mail kullanıcıları:");
        foreach (var name in validNames)
        {
            Console.WriteLine(name);
        }
    }
}

