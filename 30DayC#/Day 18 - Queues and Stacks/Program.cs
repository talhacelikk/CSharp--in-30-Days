using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    Stack<char> myStack;
    Queue<char> myQueue;

    Program()
    {
        myStack = new Stack<char>();
        myQueue = new Queue<char>();
    }

    void pushCharacter(char c)
    {
        myStack.Push(c);
    }
    void enqueueCharacter(char c)
    {
        myQueue.Enqueue(c);
    }
    char popCharacter()
    {
        return myStack.Pop();
    }
    char dequeueCharacter() 
    {
        return myQueue.Dequeue();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir kelime veya cümle girin (Türkçe karakterleri destekler):");

        string s = Console.ReadLine().ToLower(new CultureInfo("tr-TR")).Trim();

        Program obj = new Program();

        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);

        }

        bool isPalindrome = true;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;
                break;
            }
        }
        Console.WriteLine("\n Sonuç:");
        if (isPalindrome) 
        {
            Console.WriteLine($"The Word, \"{s}\" , is a palindrome.", s);
        }
        else
        {

            Console.WriteLine($"The Word,\"{s}\" , is not a palindrome.", s);
        }
        Console.WriteLine("\n Uygulama sona erdi. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
