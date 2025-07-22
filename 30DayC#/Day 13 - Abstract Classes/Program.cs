using System.IO;
using System.Collections.Generic;
using System;


//abstract: C#' ta soyutlama; diğer Object Oriented dillerde olduğu gibi iç detayları gizleyerek sadece işlevleri göstermeye denir.
//Direkt olarak kullanılamaz miras alan sınıflar üzerinden tamamlanmak zorundadır.
abstract class Book
{
    protected String title;
    protected String author;
    
    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

class MyBook : Book
{
    int price;

    public MyBook(string t,string a,int p) :base(t , a)
    {
        
        price = p;

    }
    //C# Override, oluşturmuş olduğumuz sınıf yapılarında kalıtım sayesinde üst sınıftan,
    //alt sınıfa geçiş sağlayacak metot yapılarının aktarıldığı alt sınıf yapısına uygun bir şekilde gövdesinin değiştirilmesine ve
    //kod satırlarının yeniden şekil almasına imkan sağlayan yapıya override denmektedir.
    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price + " TL");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        while (true)
        {
            Console.WriteLine(" Yeni bir kitap oluşturacağız!");
            Console.WriteLine("Lütfen sırasıyla aşağıdaki bilgileri girin:");

            Console.Write("Kitap İsmi: ");
            string title = Console.ReadLine().Trim();
            Console.Write("Yazar adı: ");
            string author = Console.ReadLine().Trim();
            int price;
            while (true)
            {
                Console.Write("Fiyat(TL): ");
                string priceInput = Console.ReadLine().Trim();
                if (int.TryParse(priceInput, out price))
                    break;
                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }
            Book new_novel = new MyBook(title, author, price);
            books.Add(new_novel);
            Console.WriteLine("\nKitap bilgileri başarıyla alındı. İşte detaylar:");
            new_novel.display();

            Console.Write("Devam etmek için : 1, Çıkış yapmak için : 2 >>> ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                Console.WriteLine("\n Tüm Kayıtlı Kitaplar:");
                foreach (Book book in books)
                {
                    Console.WriteLine("------------");
                    book.display();
                }
                Console.WriteLine("\n Tüm kitap kayıt işlemleri tamamlandı. Görüşmek üzere!");
                break;
            }
            else if (input != "1")
            {
                Console.WriteLine("Geçersiz giriş. Devam ediliyor...");
            }

            Console.WriteLine("\n---------------------------------\n");
        }
    }
}

