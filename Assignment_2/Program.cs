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
            Bank DBBL = new Bank("Developers bank", 100);
            DBBL.AddAccount(new Account("Ali", 10000, new Address("50", "23", "Dhaka", "Bangladesh"),new Birthday(3,2,1999)));
            DBBL.AddAccount(new Account("faisal", 5000, new Address("21", "10", "Gazipur", "Bangladesh"),new Birthday(4, 3, 1989)));
            DBBL.AddAccount(new Account("Moin", 5000, new Address("51", "30", "Mirzapur", "Bangladesh"), new Birthday(4, 3, 1989)));

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

            DBBL.PrintAccountDetailes();
            //mB.DeleteAccount(1);
            //mB.DeleteAccount(2);

            // mB.PrintAccountDetail
            //Console.WriteLine("Enter 1 for withdraw");
            //Console.WriteLine("Enter 2 for deposit");
            //Console.WriteLine("Enter 3 for transfer");
            choice = Convert.ToInt32(Console.ReadLine());
            DBBL.Transaction(choice);

            DBBL.PrintAccountDetailes();
            Console.ReadKey();

        }
        //    Address address = new Address();
        //    Console.WriteLine(address.GetAddress());
        //    Console.ReadKey();
        //}

    }
}
