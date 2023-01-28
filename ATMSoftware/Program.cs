﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftware
{
    class ATMSoftware
    {
        static void Main(string[] args)
        {
            string accountowner, address, ssn, confirmssn;
            int dob;
            long telephonenumber;

            Console.WriteLine("Welcome to Polestar National Bank. I see you're new here. Let's open an account for you...");
            Console.WriteLine("Polestar is dedicated to providing you fast, secure banking.");
            Console.WriteLine("What's your name?"); accountowner = Console.ReadLine();
            Console.WriteLine("Okay " + accountowner + ". I'll need your address."); address = Console.ReadLine();
            Console.WriteLine("Great. Your phone number next..."); telephonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Last, I'll need your date of birth."); dob = Convert.ToInt32(Console.ReadLine());
            if (dob <= 2004)
            {
                Console.WriteLine("Alright, " + accountowner + ". I'll start you on Polestar's Convenience Checking Account.");
                
            }
            else if (dob >= 2004)
            {
                Console.WriteLine("Alright, " + accountowner + ", I'll start you on Polestar's Junior Checking Account.");
                Console.WriteLine("When you turn 18, you're account will automatically change to our Convenience Account.");
            }
            Console.WriteLine("I'll need your 9-digit social security number in order to activate your account, " + accountowner + ".");
            Console.WriteLine("Please type it like so: XXX-XX-XXXX");
            ssn = Console.ReadLine();
            Console.WriteLine("Confirm that for me please, " + accountowner + ".");
            confirmssn = Console.ReadLine();
            do
            {
                Console.WriteLine("Sorry, that won't work. Please try again.");
            }
            while (confirmssn != ssn);

            Console.WriteLine("");


        }
    }
}
