using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(String[] args)
    {
        // Kullanıcıdan iki tarih alıyoruz: gerçek teslim tarihi ve beklenen teslim tarihi
        Console.WriteLine("Gerçek teslim tarihini gir (gün ay yıl): "); // cwl
        string aDate = Console.ReadLine();

        Console.WriteLine("Beklenen teslim tarihini gir (gün ay yıl): "); // cwl
        string eDate = Console.ReadLine();

        // Girilen tarihleri parçalayıp gün, ay, yıl olarak ayrıştırıyoruz
        string[] actDate = aDate.Split(' ');
        string[] expDate = eDate.Split(' ');

        int actDay = int.Parse(actDate[0]);
        int actMonth = int.Parse(actDate[1]);
        int actYear = int.Parse(actDate[2]);

        int expDay = int.Parse(expDate[0]);
        int expMonth = int.Parse(expDate[1]);
        int expYear = int.Parse(expDate[2]);

        int charges = 0; // Gecikme cezası

        // Teslim tarihi zamanında veya erkense ceza yok
        if ((actDay <= expDay) && (actMonth <= expMonth) && (actYear <= expYear))
        {
            Console.WriteLine("Teslimat zamanında yapıldı, ceza yok."); // cwl
            Console.WriteLine(charges);
        }
        else
        {
            // Yıl gecikmişse sabit 10000 ceza
            if (actYear > expYear)
                charges = 10000;

            // Aynı yıl ama ay gecikmişse her ay için 500 ceza
            else if ((actYear == expYear) && (actMonth > expMonth))
                charges = 500 * (actMonth - expMonth);

            // Aynı yıl ve ay ama gün gecikmişse her gün için 15 ceza
            else if ((actYear == expYear) && (actMonth == expMonth) && (actDay > expDay))
                charges = 15 * (actDay - expDay);

            Console.WriteLine($"Gecikme cezası: {charges}"); 
        }
    }
}
