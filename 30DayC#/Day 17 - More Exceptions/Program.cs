using System;
using System.Numerics;

class Calculator
{
    public Calculator() { }

    public BigInteger power(BigInteger n, BigInteger p)
    {
        if (n < 0 || p < 0)
        {
            throw new Exception("n and p should be non-negative");
        }

        return BigInteger.Pow(n, (int)p);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator myCalculator = new Calculator();

        Console.Write("Kaç işlem yapılacak? ");
        int T = Convert.ToInt32(Console.ReadLine());

        while (T-- > 0)
        {
            Console.Write("n ve p sayılarını gir (boşlukla ayır): ");
            string[] num = Console.ReadLine().Split();
            BigInteger n = BigInteger.Parse(num[0]);
            BigInteger p = BigInteger.Parse(num[1]);

            try
            {
                BigInteger ans = myCalculator.power(n, p);
                Console.WriteLine($"Sonuç: {n}^{p} = {ans}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hata: {e.Message}");
            }
        }
        Console.WriteLine("Tüm işlemler tamamlandı.");
    }
}
