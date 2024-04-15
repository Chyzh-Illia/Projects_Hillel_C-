internal class CalculatingTheSquare
{
    private static void Main(string[] args)
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            double number = Convert.ToDouble(Console.ReadLine());

            double square = Math.Pow(number, 2);

            Console.WriteLine("The square of the number {0} is equal to {1}", number, square);
        }
    }
}