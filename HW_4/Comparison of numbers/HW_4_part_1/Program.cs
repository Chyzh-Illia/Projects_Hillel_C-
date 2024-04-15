internal class ComparisonOfNumbers
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("The entered numbers are equal.");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("The first number is greater than the second number.");
        }
        else
        {
            Console.WriteLine("The second number is greater than the first number.");
        }
    }
}