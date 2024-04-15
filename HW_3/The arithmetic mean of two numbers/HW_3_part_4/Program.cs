internal class TheArithmeticMeanOfTwoNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double average = (number1 + number2) / 2;

        Console.WriteLine("Arithmetic average of numbers {0} and {1} is equal to {2}", number1, number2, average);
    }
}