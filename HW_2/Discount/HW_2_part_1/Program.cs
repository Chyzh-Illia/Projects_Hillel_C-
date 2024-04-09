public class Program
{
    private static void Main(string[] args)
    {
        int cost = 532123; 
        double discountPercentage = 13; 

        var discountAmount = cost * (discountPercentage / 100); 

        Console.WriteLine("Величина знижки: " + discountAmount);
    }
}