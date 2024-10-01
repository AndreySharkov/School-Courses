using System;
using System.Collections.Generic;
using System.Linq;
namespace MoneyTRansactions
{
    public class MoneyTransactions
    {
        public static void Main(string[] args)
        {
            Dictionary<int, double> accounts = ParseAccounts(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                string command = input[0];
                int accountNumber = int.Parse(input[1]);
                double amount = double.Parse(input[2]);

                try
                {
                    switch (command)
                    {
                        case "Deposit":
                            Deposit(accounts, accountNumber, amount);
                            break;
                        case "Withdraw":
                            Withdraw(accounts, accountNumber, amount);
                            break;
                        default:
                            Console.WriteLine("Invalid command!");
                            break;
                    }
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Insufficient balance!");
                }

                Console.WriteLine("Enter another command");
            }
        }

        private static Dictionary<int, double> ParseAccounts(string input)
        {
            string[] accountData = input.Split(',');
            Dictionary<int, double> accounts = new Dictionary<int, double>();

            foreach (string accountInfo in accountData)
            {
                string[] parts = accountInfo.Split('-');
                int accountNumber = int.Parse(parts[0]);
                double balance = double.Parse(parts[1]);
                accounts.Add(accountNumber, balance);
            }

            return accounts;
        }

        private static void Deposit(Dictionary<int, double> accounts, int accountNumber, double amount)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                throw new KeyNotFoundException();
            }

            accounts[accountNumber] += amount;
            Console.WriteLine($"Account {accountNumber} has new balance: {accounts[accountNumber]:F2}");
        }

        private static void Withdraw(Dictionary<int, double> accounts, int accountNumber, double amount)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                throw new KeyNotFoundException();
            }

            if (accounts[accountNumber] < amount)
            {
                throw new ArgumentException();
            }

            accounts[accountNumber] -= amount;
            Console.WriteLine($"Account {accountNumber} has new balance: {accounts[accountNumber]:F2}");
        }
    }

}
