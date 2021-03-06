using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int choice;
            Bank mB = new Bank("Developers bank", 100);
            mB.AddAccount(new Account("Ali", 10000, new Address("50", "23", "Dhaka", "Bangladesh")));
            mB.AddAccount(new Account("anik", 5000, new Address("21", "10", "Gazipur", "Bangladesh")));
            // declare variables here

            Console.WriteLine("Welcome to DEVELOPERS BANK");
            Console.WriteLine("1. Open a Bank Account");
            Console.WriteLine("2. Perform a Transaction");
            Console.WriteLine("3. Perform a Transaction");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool exit = true;
            while (exit)
            {
                switch (choice)
                {
                    case 1:
                        {
                            
                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            mB.PrintAccountDetailes();
            //mB.DeleteAccount(1);
            //mB.DeleteAccount(2);

            // mB.PrintAccountDetail
            //Console.WriteLine("Enter 1 for withdraw");
            //Console.WriteLine("Enter 2 for deposit");
            //Console.WriteLine("Enter 3 for transfer");
            choice = Convert.ToInt32(Console.ReadLine());
            mB.Transaction(choice);

            mB.PrintAccountDetailes();
            Console.ReadKey();

        }
        //    Address address = new Address();
        //    Console.WriteLine(address.GetAddress());
        //    Console.ReadKey();
        //}

    }
}
