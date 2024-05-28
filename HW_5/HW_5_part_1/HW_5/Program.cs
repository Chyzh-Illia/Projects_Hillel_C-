using System;

namespace PasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "root";
            string input;

            do
            {
                Console.Write("Enter the password: ");
                input = Console.ReadLine();
                if (input != correctPassword)
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            } while (input != correctPassword);

            Console.WriteLine("Access granted.");
        }
    }
}