using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Назва книги: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Рік видання: {Year}");
        Console.WriteLine($"Кількість сторінок: {Pages}");
    }

    public void CheckThickness()
    {
        if (Pages > 500)
        {
            Console.WriteLine("Ця книга товста");
        }
        else
        {
            Console.WriteLine("Ця книга не така товста");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "Три товариші";
        book.Author = "Еріх Марія Ремарк";
        book.Year = 1936;
        book.Pages = 624;

        Console.WriteLine("Інформація про книгу:");
        book.PrintInfo();
        Console.WriteLine("\nПеревірка товстоти книги:");
        book.CheckThickness();

        Console.ReadLine();
    }
}