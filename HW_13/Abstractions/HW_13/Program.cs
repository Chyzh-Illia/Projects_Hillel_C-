using System;

namespace BankingSystem
{
    public abstract class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string AccountNumber { get; }
        public string AccountHolderName { get; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract void DisplayAccountInfo();
    }

    public class SavingsAccount : BankAccount
    {
        public decimal AnnualInterestRate { get; }

        public SavingsAccount(string accountHolderName, decimal annualInterestRate)
            : base(accountHolderName)
        {
            AnnualInterestRate = annualInterestRate;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount + (amount * AnnualInterestRate / 100);
            Console.WriteLine($"{amount:C} has been deposited. Balance is now {Balance:C}");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount:C} has been withdrawn. Balance is now {Balance:C}");
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine($"Annual Interest Rate: {AnnualInterestRate}%");
        }
    }

    public class SpecialAccount : BankAccount
    {
        public decimal OverdraftLimit { get; }

        public SpecialAccount(string accountHolderName, decimal overdraftLimit)
            : base(accountHolderName)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"{amount:C} has been deposited. Balance is now {Balance:C}");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return;
            }
            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine($"Insufficient balance. You can withdraw up to {Balance + OverdraftLimit:C}.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount:C} has been withdrawn. Balance is now {Balance:C}");
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit:C}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount("John Doe", 2.5m);
            savings.Deposit(1000);
            savings.Withdraw(200);
            savings.DisplayAccountInfo();

            Console.WriteLine();

            SpecialAccount special = new SpecialAccount("Jane Smith", 500);
            special.Deposit(1000);
            special.Withdraw(1200);
            special.DisplayAccountInfo();
        }
    }
}
