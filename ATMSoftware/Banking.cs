using System;

namespace ATMSoftware
{
    public static class Banking
    {
        public static void Main(string[] args)
        {
            int bankpin, pinverification, depositamount, withdrawamount;
            int newaccountgift = 150;
            string accountchoice;

            Console.WriteLine("Let's verify your identity.");

            do
            {
                Console.WriteLine("What is your pin number?");
                Console.ForegroundColor = ConsoleColor.Black;
                bankpin = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Again.");
                Console.ForegroundColor = ConsoleColor.Black;
                pinverification = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (pinverification == bankpin)
                {
                    continue;
                }
                if (pinverification != bankpin)
                {
                    Console.WriteLine("Access Denied!");
                    return;
                }
            }
            while (bankpin != pinverification);

            Console.WriteLine("We are here to make banking safer, together.");
            Console.WriteLine("Type \"Check Balance\" to see the funds in your account. Type \"Withdraw\" to withdraw funds. Or type \"Deposit\" to deposit funds.");
            accountchoice = Console.ReadLine();
            do
            {
                Console.WriteLine("Your current balance is " + newaccountgift + ".");
                break;
            }
            while (accountchoice == "Check Balance");
            do
            {
                Console.WriteLine("How much would you like to deposit?");
                depositamount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your new balance is: " + (depositamount + newaccountgift));
                break;
            }
            while (accountchoice == "Deposit");
            do
            {
                Console.WriteLine("How much would you like to withdraw?");
                withdrawamount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You withdrew " + withdrawamount + ". Your account currently has " + (newaccountgift - withdrawamount) + ", left.");
                break;
            }
            while (accountchoice == "Withdraw");
        }
    }
}