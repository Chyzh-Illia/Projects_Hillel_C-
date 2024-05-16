class Age
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введіть ваш вік: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                throw new FormatException("Вік не може бути від'ємним числом.");
            }

            Console.WriteLine($"Ваш вік: {age}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        Console.ReadLine();
    }
}