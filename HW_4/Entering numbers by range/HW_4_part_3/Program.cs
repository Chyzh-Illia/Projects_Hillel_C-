internal class EnteringNumbersByRange
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number from 1 to 100:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("The number must be between 1 and 100");
            return;
        }

        if (number % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}