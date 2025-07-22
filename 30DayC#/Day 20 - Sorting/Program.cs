using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the length of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the space-separated array elements: ");
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        Console.WriteLine("\nStarting the bubble sort...\n");

        int numberOfSwaps = 0;

        for (int i = 0; i < n; i++)
        {
            int swapsThisRound = 0;
            Console.WriteLine($"=> Round {i + 1} begins:");

            for (int j = 0; j < n - 1; j++)
            {
                Console.Write($"Comparing: a[{j}] = {a[j]} and a[{j + 1}] = {a[j + 1]}");

                if (a[j] > a[j + 1])
                {
                    Console.Write(" => Swapping!\n");
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;

                    swapsThisRound++;
                    numberOfSwaps++;
                }
                else
                {
                    Console.WriteLine(" => No swap needed.");
                }
            }

            Console.WriteLine($"Array after round {i + 1}: [{string.Join(", ", a)}]");

            if (swapsThisRound == 0)
            {
                Console.WriteLine("No swaps in this round. Array is sorted. Exiting early.\n");
                break;
            }

            Console.WriteLine($"{swapsThisRound} swaps made in this round.\n");
        }

        Console.WriteLine("Sorting completed!\n");
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[a.Length - 1]);
    }
}
