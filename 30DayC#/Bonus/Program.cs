using System;

class Program
{
    static void Main()
    {
        string input = "You win some. You lose some.";

        // Define delimiters: space and period
        char[] delimiters = { ' ', '.' };

        // Split the string
        string[] result = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Output each substring
        Console.WriteLine("Split Result:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }
}
//Split kullanımı