using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (day < 1 || day > 31 || month < 1 || month > 12 || year < 0)
        {
            Console.WriteLine("The entered values ​​are incorrect.");
            return;
        }

        StringBuilder dateBuilder = new StringBuilder();
        dateBuilder.Append(day.ToString("D2"));
        dateBuilder.Append("-");
        dateBuilder.Append(month.ToString("D2"));
        dateBuilder.Append("-");
        dateBuilder.Append(year);

        Console.WriteLine($"Your date: {dateBuilder.ToString()}");

        Console.ReadLine();
    }
}