//Bunlar 0 ve 1 dir. Bu yüzden binary sayı sisteminin tabanı 2'dir. (1011)2 şeklinde yazılır.
//Bu sayı sistemine ikili sayı anlamına gelen binary numbers yani binary sayı sistemi denilmiştir.

class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Bir sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            String number = "1101";
            int fromBase = 10;
            int toBase = 2;

            number = n.ToString();
            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("Binary karşılığı: " + result);
            char[] myTest = result.ToCharArray();

            int xMin = 0;
            int xMax = 0;

            foreach (char c in myTest)
            {
                if (c == '1')
                {
                    xMax++;
                }
                else
                {
                    if (xMin <= xMax) xMin = xMax;
                    xMax = 0;
                }
            }
            if (xMax <= xMin) xMax = xMin;
            Console.WriteLine("En uzun ardışık 1 sayısı: " + xMax);
            Console.Write("1 : devam, 2 : Çıkış >>> ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                Console.WriteLine("Çıkılıyor...");
                break;
            }
            else if (input != "1")
            {
                Console.WriteLine("Geçersiz giriş. Devam ediliyor...");
            }
        }

    }

}
