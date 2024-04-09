internal class Program
{
    private static void Main(string[] args)
    {
        int hours = 30;
        int minutes = 10;
        int seconds = 54;

        int totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

        Console.WriteLine("Загальний час у секундах: " + totalTimeInSeconds);
    }
}