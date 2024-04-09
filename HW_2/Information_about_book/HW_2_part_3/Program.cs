internal class Program
{
    private static void Main(string[] args)
    {
        string title = "Чистий код";
        string author = "Мартін Роберт";
        var price = "14.99 $"; 

        string bookInfo = string.Format($"Title: {title}, Author: {author}, Price: {price}");

        Console.WriteLine(bookInfo);
    }
}