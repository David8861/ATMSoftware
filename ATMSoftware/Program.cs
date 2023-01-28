using System;
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
            string accountowner, address;
            int phonenumber, dob, ssn;

            Console.WriteLine("Welcome to Polestar National Bank. I see you're new here. Let's open an account for you...");
            Console.WriteLine("We'll need your name, address, date of birth, phone number, and social security number.");
            Console.WriteLine("What's your name?"); accountowner = Console.ReadLine();
            Console.WriteLine("Okay " + accountowner + ". I'll need your address next."); address = Console.ReadLine();
            Console.WriteLine("Great. Your phone number next..."); phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last, I'll need your date of birth."); dob = Convert.ToInt32(Console.ReadLine());
            


        }
    }
}
