using System.Security.Cryptography.X509Certificates;

namespace Bank_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------- BANK GAME APP ------------------");
            Console.WriteLine("\n** Rules of the game **");
            Console.WriteLine("-> Both players will be assigned a RANDOM Bank balance in the range 1000 - 5000");
            Console.WriteLine("-> There will be 3 rounds, in each round a player may withdraw or deposit certain amount in his balance");
            Console.WriteLine("-> Note that this amount can be in the range 1 - 1000 only");
            Console.WriteLine("-> The player with high bank balance after 3 rounds will win");

            double GetRandomNumber(double min,double max)
            {
                Random rnd = new Random();
                return rnd.NextDouble() * (max - min) + min;
            }
            BankAccount a1 = new BankAccount("Account1", GetRandomNumber(1000,5000));
            BankAccount a2 = new BankAccount("Account2", GetRandomNumber(1000,5000));

            int round = 1;

            while (round <= 3)
            {
                Console.WriteLine($"\nRound {round}:");

                string choice1, choice2;

                // Input choice validation
                do
                {
                    Console.Write($"{a1.Accountholder} Withdraw or Deposit (w/d): ");
                    choice1 = Console.ReadLine();
                    if (choice1 == "w") a1.WithdrawCaller();
                    else if (choice1 == "d") a1.DepositCaller();
                    else Console.WriteLine("Invalid Choice! Please enter again");

                }
                while (choice1 != "w" && choice1 != "d");

                // Input choice validation
                do
                {
                    Console.Write($"{a2.Accountholder} Withdraw or Deposit (w/d): ");
                    choice2 = Console.ReadLine();
                    if (choice2 == "w") a2.WithdrawCaller();
                    else if (choice2 == "d") a2.DepositCaller();
                    else Console.WriteLine("Invalid Choice! Please enter again");

                }
                while (choice2 != "w" && choice2 != "d");

                round++;
            }
            if (a1.Balance > a2.Balance) Console.WriteLine($"\n{a1.Accountholder} Won with Balance: {a1.Balance}");
            else Console.WriteLine($"\n{a2.Accountholder} Won with Balance: {a2.Balance}");
        }
    }
}
