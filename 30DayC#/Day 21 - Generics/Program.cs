using System;

class Printer
{
    // CWL: Generic method that can print any type of array
    public void PrintArray<E>(E[] inputArray)
    {
        foreach (E element in inputArray)
        {
            Console.WriteLine(element); // CWL: Print each element
        }
    }
}

public class Generics
{
    public static void Main(string[] args)
    {
        // CWL: Read number of integers
        Console.Write("Kaç tane sayı gireceksin? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] intArray = new int[n];
        Console.WriteLine("Lütfen sayıları girin:");
        for (int i = 0; i < n; i++)
        {
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        // CWL: Read number of strings
        Console.Write("Kaç tane string gireceksin? ");
        n = Convert.ToInt32(Console.ReadLine());

        string[] stringArray = new string[n];
        Console.WriteLine("Lütfen string'leri girin:");
        for (int i = 0; i < n; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        // CWL: Create printer instance and print arrays
        Printer printer = new Printer();

        Console.WriteLine("\nYazdırılan Sayılar:");
        printer.PrintArray(intArray); // int[] gönderildi

        Console.WriteLine("\nYazdırılan Stringler:");
        printer.PrintArray(stringArray); // string[] gönderildi

      
        if (typeof(Printer).GetMethods().Length > 1)
        {
            Console.WriteLine("Printer class should only have 1 method named PrintArray.");
        }
    }
}
