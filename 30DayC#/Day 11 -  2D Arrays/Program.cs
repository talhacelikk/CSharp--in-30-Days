using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        long[][] arr = new long[6][];

        for (int i = 0; i < 6; i++)
        {                                               //Boşluk karakterine göre parçalar, boşlukları filtreler.
            string[] input = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

           
            if (input.Length != 6)
            {
                Console.WriteLine("Hatalı giriş! Lütfen her satıra 6 adet sayı girin.");
                return;
            }

            try
            {
                arr[i] = Array.ConvertAll(input, long.Parse); //	string diziyi long/int dizisine çevirir
            }
            catch
            {
                Console.WriteLine("Geçersiz sayı girişi! Lütfen sadece rakam kullanın.");
                return;
            }
        }
        long[] sum = new long[16];
        int h = 0;

        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 4; j++)
            {//"kum saati" şeklinin toplamını alıyor.
                sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                       + arr[i + 1][j + 1]
                       + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                h++; // diyerek, bir sonraki toplamın dizide nereye yazılacağını hazırlıyor.
            }
        }
        //sum adlı dizi içinde bulunan tüm değerleri küçükten büyüğe sıralıyor.
        Array.Sort(sum);
        //sonra sum[15] diyerek en büyük 16.elemanı(yani en büyük toplamı) alıyorsun.
        Console.WriteLine(sum[15]);
    }
}