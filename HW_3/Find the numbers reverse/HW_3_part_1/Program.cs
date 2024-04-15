internal class FindNumbersReverse
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть тризначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // first number
        int firstDigit = number / 100;
        // second number
        int secondDigit = (number / 10) % 10;
        // third numer
        int thirdDigit = number % 10;

        int reversedNumber = thirdDigit * 100 + secondDigit * 10 + firstDigit;

        Console.WriteLine("Число, отримане під час прочитання його цифр справа наліво: " + reversedNumber);
    }
}