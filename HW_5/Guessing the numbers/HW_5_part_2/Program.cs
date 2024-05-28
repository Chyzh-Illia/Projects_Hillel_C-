using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 147);
            int userGuess = 0;

            Console.WriteLine("Я загадав число від 1 до 146. Спробуйте його вгадати.");

            while (userGuess != numberToGuess)
            {
                Console.Write("Ваше припущення: ");
                if (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.WriteLine("Будь ласка, введіть число.");
                    continue;
                }

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Більше.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Менше.");
                }
            }

            Console.WriteLine("Вітаю! Ви вгадали число.");
        }
    }
}