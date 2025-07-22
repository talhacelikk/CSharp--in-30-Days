using System;
using System.Globalization;

public interface AdvancedArithmetic
{
    int divisorSum(int n);
}
public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                result += i;
        }
        return result;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");

        int n = Convert.ToInt32(Console.ReadLine());
        AdvancedArithmetic myCal = new Calculator();
        int sum = myCal.divisorSum(n);
        Console.WriteLine("I implemented : AdvancedArithmetic\n" + sum);
        Console.WriteLine($"Toplam: {sum}");
    }
}