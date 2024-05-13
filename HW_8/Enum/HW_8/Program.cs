
enum ProductType
{
    Food,
    Clothing,
    Electronics,
    Books
}

class Enum1
{
    static void Main(string[] args)
    {
        double totalCost = 0;

        while (true)
        {
            Console.WriteLine("Enter the product type (Food, Clothing, Electronics, Books) or enter 'stop' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "stop")
                break;

            if (!Enum.TryParse(input, true, out ProductType productType))
            {
                Console.WriteLine("Incorrectly entered product type. Please enter a valid type.");
                continue;
            }

            Console.Write("Enter the price of the product:");
            if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
            {
                Console.WriteLine("Incorrectly entered price. Please enter a positive number.");
                continue;
            }

            totalCost += price;

            Console.WriteLine($"Total cost in the cart: {totalCost:F2} грн\n");
        }

        Console.WriteLine($"The total cost of all products in the basket: {totalCost:F2} грн");

        Console.ReadLine();
    }
}
