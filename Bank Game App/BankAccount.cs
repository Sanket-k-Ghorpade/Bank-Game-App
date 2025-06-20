using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Game_App
{
    public class BankAccount
    {
        private string accountholder;
        private double balance;

        // Getters and Setters
        public string Accountholder {  get { return accountholder; } set { accountholder = value; }}
        public double Balance { get { return balance; } set { balance = value; }}


        // Constructor
        public BankAccount(string accountholder, double balance)
        {
            this.accountholder = accountholder;
            this.balance = balance;
        }

        // Deposit method
        private void Deposit(double amount)
        {
            balance += amount;
            balance = Math.Round(balance, 2);
        }

        // public method DepositCaller() to access private method Deposit() -> following encapsulation principles
        public void DepositCaller()
        {
            // Input amount validation to check if its in the range 1 - 1000, if not then prompts the user to enter it repeatadly until valid amount is entered
            double amount;
            do
            {
                Console.Write("Amount to deposit: ");
                amount = double.Parse(Console.ReadLine());
                if (amount < 0 || amount > 1000) Console.WriteLine("Invalid amount! Please enter again");
            }
            while (amount < 0 || amount > 1000);

            Deposit(amount);
        }

        // Withdraw method
        private void Withdraw(double amount)
        { 
            balance -= amount; 
            balance = Math.Round(balance,2);
        }

        // public method WithdrawCaller() to access private method Withdraw() -> following encapsulation principles
        public void WithdrawCaller()
        {
            // Input amount validation to check if its in the range 1 - 1000, if not then prompts the user to enter it repeatadly until valid amount is entered
            double amount;
            do
            {
                Console.Write("Amount to Withdraw: ");
                amount = double.Parse(Console.ReadLine());
                if (amount < 0 || amount > 1000) Console.WriteLine("Invalid amount! Please enter again");
            }
            while (amount < 0 || amount > 1000);
            Withdraw(amount);
        }
    }
}
