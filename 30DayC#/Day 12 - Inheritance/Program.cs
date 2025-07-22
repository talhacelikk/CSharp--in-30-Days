//C#'taki protected internal erişim tanımlayıcısı, protected ve internal ifadelerinin birleşimidir.

using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}
class Student : Person
{
    private int[] test_Score;
    public Student() { }
    public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
    {
        this.test_Score = testScores;
    }
    public char Calculate()
    {
        int avg = (int)test_Score.Average();

        if (avg >= 90) return 'A';
        else if (avg >= 80) return 'B';
        else if (avg >= 70) return 'C';
        else if (avg >= 55) return 'D';
        else if (avg >= 40) return 'E';
        else return 'F';
    }
}
class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("İsim, soyisim ve ID girin (boşluklarla ayrılmış): ");
            string[] inputs = Console.ReadLine().Split();

            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);

            Console.Write("Kaç not gireceksiniz?: ");
            int numScores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Lütfen {numScores} adet notu boşluklarla girin:");
            inputs = Console.ReadLine().Split();

            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
        Console.WriteLine("Diğer Öğrenciye geçiniz")
    }
}