﻿using System;

namespace ATMSoftware
{
    internal class ATMSoftware
    {
        private static void Main(string[] args)
        {
            string ownerfirstname, ownerlastname, address, ssn, confirmssn, ssnretry;
            string starterATMcard = "4321 5703 4489 3400";
            int dob, bankpin, bankpinconfirm, banktryagain, pinverification;
            int newaccountgift = 150;
            long telephonenumber;

            Console.WriteLine("Welcome to Polestar National Bank. I see you're new here. Let's open an account for you...");
            Console.WriteLine("Polestar is dedicated to providing you fast, secure banking.");
            Console.WriteLine("What's your first name?"); ownerfirstname = Console.ReadLine();
            Console.WriteLine("And your last?"); ownerlastname = Console.ReadLine();
            Console.WriteLine("Okay " + ownerfirstname + ". I'll need your address."); address = Console.ReadLine();
            Console.WriteLine("Great. Your phone number next..."); telephonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Last, I'll need your date of birth."); dob = Convert.ToInt32(Console.ReadLine());
            if (dob <= 2004)
            {
                Console.WriteLine("Alright, " + ownerfirstname + ". I'll start you on Polestar's Convenience Checking Account.");
            }
            else if (dob >= 2004)
            {
                Console.WriteLine("Alright, " + ownerfirstname + ", I'll start you on Polestar's Junior Checking Account.");
                Console.WriteLine("When you turn 18, you're account will automatically change to our Convenience Account.");
            }
            Console.WriteLine("I'll need your 9-digit social security number in order to activate your account, " + ownerfirstname + " " + ownerlastname + ".");
            Console.WriteLine("Please type it like so: XXX-XX-XXXX");
            ssn = Console.ReadLine();

            do
            {
                Console.WriteLine("Confirm that for me please, " + ownerfirstname + ".");
                confirmssn = Console.ReadLine();

                if (confirmssn == ssn)
                {
                    continue;
                }
                if (confirmssn != ssn)
                {
                    Console.WriteLine("Nope. Try again!");
                    ssnretry = Console.ReadLine();
                    if (ssnretry == ssn)
                    {
                        break;
                    }
                }
            }
            while (confirmssn != ssn);

            Console.WriteLine("Great! Oh and one more thing...you're pin!");
            Console.WriteLine("Use any four numbers you like: "); bankpin = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Confirm your pin please: "); bankpinconfirm = Convert.ToInt32(Console.ReadLine());
                if (bankpinconfirm == bankpin)
                {
                    continue;
                }
                if (bankpinconfirm != bankpin)
                {
                    Console.WriteLine("You must comfirm your pin, " + ownerfirstname + " " + ownerlastname + ".");
                    banktryagain = Convert.ToInt32(Console.ReadLine());
                    if (banktryagain == bankpin)
                    {
                        break;
                    }
                }
            }
            while (bankpin != bankpinconfirm);

            Console.WriteLine("Before we give you a Polestar ATM card, we would like to gift you $" + newaccountgift + " for opening an account with us today!");
            Console.WriteLine("Here is your ATM card, " + ownerfirstname + ": " + starterATMcard + ".");
            Console.WriteLine("Account Information for " + ownerfirstname + " " + ownerlastname + ".");
            Console.WriteLine("Address: " + address + "."); Console.Write("Phone Number: " + telephonenumber + ".");
            Console.WriteLine("Date of Birth: " + dob + "."); Console.Write("Social Security Number: " + ssn + ".");

            Console.WriteLine("Let's verify your identity.");
            
            do
            {
                Console.WriteLine("What is your Pin number?"); pinverification = Convert.ToInt32(Console.ReadLine());
                if (pinverification == bankpin)
                {
                    continue;
                }
                if (pinverification != bankpin)
                {
                    Console.WriteLine("Access Denied!");
                }
            }
            while (bankpin != pinverification);

            Console.WriteLine(ownerfirstname + ", we are here to make banking safer, together. What do you need?");
        }
    }
}