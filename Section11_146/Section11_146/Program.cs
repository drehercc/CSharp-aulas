using System;
using System.Globalization;
using Section11_146.Entities;
using Section11_146.Entities.Exceptions;

namespace Section11_146
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine();
            Console.Write("Enter the amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            try
            {
                account.Withdraw(amount);
                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));


            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpeted error: " + e.Message);
            }
        }
    }
}
