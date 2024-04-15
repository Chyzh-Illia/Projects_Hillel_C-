internal class FindNumberPermuted
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entering the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        int resultNumber = secondDigit * 100 + firstDigit * 10 + thirdDigit;

        Console.WriteLine("The number obtained when permuting the first and second digits: " + resultNumber);
    }
}