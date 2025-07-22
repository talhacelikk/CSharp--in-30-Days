using System;

class Program
{
    static int factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }

    static void Main(String[] args)
    {
        Console.Write("Faktöriyeli alınacak sayı: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int result = factorial(n);
        Console.WriteLine("Sonuç: " + result);
    }
}
